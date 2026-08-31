



using MongoDB.Driver;
using MongoDB.Bson;
using System.Diagnostics;



/// <summary>
/// Стат класс для работы с БД
/// </summary>
public partial class DataBase{


/// <summary> 
/// работа с БД (Для mongoDB)
/// </summary>
protected class MongoDataBase : IDisposable{
    /// <summary> Процесс для поднятия СУБД </summary>
    //private Process DBProcess;
    /// <summary> Подключение к СУБД </summary>
    protected MongoClient Client; 

    /// <summary> БД с которой ведется работа </summary>
    protected IMongoDatabase Database;

    /// <summary> Колекции для записи VPN протоколов </summary>
    protected IMongoCollection<BsonDocument> Collections;


    public MongoDataBase(){
        /*var startInfo = new ProcessStartInfo{
            FileName = "mongod.exe",
            Arguments = $"--dbpath D:\\Mondodb",
            UseShellExecute = false,
            RedirectStandardOutput = true,
            RedirectStandardError = true,
            CreateNoWindow = true
        };
        this.DBProcess = Process.Start(startInfo)!;*/

        this.Client = new MongoClient("mongodb://mongo:27017");

        this.Database = this.Client.GetDatabase("Arhitect");

        List<string> list_collection = this.Database.ListCollectionNames().ToList();

        if (list_collection.Contains("message_col")){
            this.Collections = Database.GetCollection<BsonDocument>("message_col");
        }
        else{ this.Collections = BuildCollection(); }
    }

    /// <summary> Стоительство отсутствующих коллекций </summary>
    protected IMongoCollection<BsonDocument> BuildCollection(){
        this.Database.RunCommand<BsonDocument>(new BsonDocument{
            {"create", "message_col"}, 

            {"validator", new BsonDocument{
                {"$jsonSchema", new BsonDocument{
                    {"bsonType", "object"},
                    {"required", new BsonArray{"text_message", "is_user"}},
                    {"properties", new BsonDocument{
                        {"text_message", new BsonDocument{{"bsonType", "string"}}},
                        {"is_user", new BsonDocument{{"bsonType", "bool"}}},
                    }}
                }}
            }},
            {"validationLevel", "strict"}, // строгая проверка
            {"validationAction", "error"}  // ошибка при нарушении
            
        });
        return this.Database.GetCollection<BsonDocument>("message_col");
    }

    public async Task Write(string message, bool is_user = true){
        BsonDocument res = new BsonDocument(){
            {"text_message", new BsonString(message) },
            {"is_user", new BsonBoolean(is_user)}
        };
        await this.Collections.InsertOneAsync(res);
    }

    public async Task<List<(string, bool)>> Read(Index ind, int count = 1){
        var res = new List<(string, bool)>();

        int int_index = ind.Value;
        var filter = FilterDefinition<BsonDocument>.Empty;

        if(ind.IsFromEnd){
            int_index = (-int_index) + (int) await this.Collections.CountDocumentsAsync( filter );
        }

        List<BsonDocument> temp = this.Collections
            .Find(filter).Skip(int_index)
            .Limit(count).ToList()
        ;

        foreach (BsonDocument item in temp){
            string text_message;

            BsonValue maybe_text_message = item.GetElement("text_message").Value;
            if(!maybe_text_message.IsString){ continue; }
            text_message = maybe_text_message.AsString;

            bool is_user; 
            BsonValue maybe_is_user = item.GetElement("is_user").Value;
            if(!maybe_is_user.IsBoolean){ continue; }
            is_user = maybe_is_user.AsBoolean;

            res.Add(( text_message, is_user ));
        }
        return res;
    }

    public async Task Clear(){
        var filter = FilterDefinition<BsonDocument>.Empty;
        await this.Collections.DeleteManyAsync(filter);
    }



    public void Dispose(){
        this.Client.Dispose(); 
        // this.DBProcess.Dispose();
    }
}





}



