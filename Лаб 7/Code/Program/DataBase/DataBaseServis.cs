


/// <summary>
/// Стат класс для работы с БД
/// </summary>
public partial class DataBase{


/// <summary> 
/// работа с БД (Сервис)
/// </summary>
public static class DataBaseServis{
    private static MongoDataBase DB;

    static DataBaseServis(){
        DB = new MongoDataBase();
    }

    public static async Task Write(string message, bool is_user = true){
        await DB.Write(message, is_user);
    }

    public static async Task<List<(string, bool)>> Read(Index ind, int count = 1){
        return await DB.Read(ind, count);
    }

    public static async Task Clear(){
        await DB.Clear();
    }



    public static void Init(){}
    public static void Dispose(){ DB.Dispose(); }
}




}



