



using System.Runtime.CompilerServices;
// dotnet add package MySql.Data
using MySql.Data.MySqlClient;

using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Text;

using System.Text.Json;




class DataBase: IDisposable{
    /// Одиночка для работы с БД
    public static DataBase SinglDataBase;
    
    /// <summary> Создание одиночки </summary>
    static DataBase(){ SinglDataBase = new DataBase(); }


    /// <summary> Подключение к БД </summary>
    public MySqlConnection connection; 

    /// <summary> Подключаемся к БД и проверяем что есть БД Lily </summary>
    protected DataBase(){
        // Сервер с БД
        string server = "localhost";



        using var doc = JsonDocument.Parse(File.ReadAllText("../../../Program/DataBase/Conection.json"));

        // Пользователь
        string? user = doc.RootElement.GetProperty("login").GetString();
        // Пароль пользователя
        string? password = doc.RootElement.GetProperty("password").GetString();


        if(user == null || password == null){ Environment.Exit(-1); }


        // Название БД
        string student = "student";

        this.connection = new MySqlConnection($"Server={server};Database={student};User ID={user};Password={password};");
        // Открываем подключение к БД
        this.connection.Open();
    }


    /// <summary> Проверка на наличии SQL инъекций </summary>
    /// <param name="check_string"> Строка для проверки </param>
    public static void SheckSQLIniection(params string?[] strings){
        /*
            Данные для проверки:
            авааа
            ihoho
            fejiршгрр98ihoih
            myemail@gmail.com

            ihoho;
            mye@mail@gmail.com
            (ihoho)
            ihoho or 1=1;
            ihoho--
            ihoho/*
            //ihoho

            Регулярка:
            [\w\sа-я\.]+ 
            [@]{0,1}
            [\w\sа-я\.]+

            ^([\w\sа-я\.]+[@]{0,1}[\w\sа-я\.]+)$
        */

        string pattern = @"^([\w\sа-я\.]*[@]{0,1}[\w\sа-я\.]*)$"; 

        Parallel.ForEach(strings, (chec_str, pls) => {
            if(chec_str == null){ return; }

            if(Regex.IsMatch(chec_str.ToLower(), pattern)){ return; }

            throw new SQLInjection(); 
        });
    }


    /// <summary> Словарь специальностей </summary>
    public async Task<Dictionary<string, long>> GetSpetialitest(){
        Task<MySqlDataReader> command = Task.Run(() =>{
            using var command = new MySqlCommand("""
                SELECT id, name FROM specialties
                """, this.connection
            );
            return command.ExecuteReader();
        });
        Dictionary<string, long> res = new Dictionary<string, long>();

        using var reader = await command;

        while (reader.Read()){
            res[(string)(reader["name"])] = Convert.ToInt64(reader["id"]);
        }
        return res;
    }


    /// <summary> Выдать данные о студентах, фамилия  которых начинается на букву П. (На вызов добавить обработчик на Exception) </summary>
    public async Task<(Strudent, string?, string?)> FindStudent(ulong position){
        Task<(Strudent, ulong)> command = Task.Run(() =>
        {
            using var command = new MySqlCommand("""
                SELECT 
                    students.name AS stud_name, sex, parents, 
                    address, phone_number, 
                    passport_data, `group`, 
                    birthday, date_receipt, 
                    is_full_time, number_record_book, 
                    nuber_course, id_specialty
                FROM students
                    LIMIT @Position, 1;
                """, this.connection
            );
            command.Parameters.AddWithValue("@Position", position);
            using var reader = command.ExecuteReader();

            reader.Read();

            return (
                new Strudent(
                    (string)(reader["stud_name"]), (string)(reader["sex"]), (string)(reader["parents"]),
                    (string)(reader["address"]), (string)(reader["phone_number"]),
                    (string)(reader["passport_data"]), (string)(reader["group"]),
                    Convert.ToDateTime(reader["birthday"]), Convert.ToDateTime(reader["date_receipt"]),
                    Convert.ToBoolean(reader["is_full_time"]), Convert.ToInt32(reader["number_record_book"]),
                    Convert.ToInt16(reader["nuber_course"])
                ), 
                reader.GetUInt64("id_specialty")
            );
        });
        
        (Strudent student, ulong id_specialty) = await command;

        using var request = new MySqlCommand($"""
            SELECT name, `describe` FROM specialties  
                WHERE id = {id_specialty};
            """, this.connection
        );
        using var reader = request.ExecuteReader();

        reader.Read();

        return (student, (string?)reader["name"], (string?)reader["describe"]); 
    }


    public async Task<(StrudentShort, List<Exam>)> FindExam(ulong position){
        Task<(StrudentShort, ulong)> command = Task.Run(() =>
        {
            using var command = new MySqlCommand("""
                SELECT 
                    id, students.name AS stud_name, sex, 
                    passport_data, `group`, birthday
                FROM students
                    LIMIT @Position, 1;
                """, this.connection
            );
            command.Parameters.AddWithValue("@Position", position);
            using var reader = command.ExecuteReader();

            reader.Read();

            return (
                new StrudentShort(
                    (string)(reader["stud_name"]), (string)(reader["sex"]), (string)(reader["passport_data"]), 
                    (string)(reader["group"]),
                    Convert.ToDateTime(reader["birthday"])
                ), 
                reader.GetUInt64("id")
            );
        });
        
        (StrudentShort student, ulong id) = await command;

        using var request = new MySqlCommand($"""
            SELECT id_discipline, date, mark FROM exams
                WHERE id_student = {id};
            """, this.connection
        );
        using var reader = request.ExecuteReader();

        List<Exam> exams = [];

        while (reader.Read()) {
            exams.Add(new Exam(
                reader.GetUInt64("id_discipline"),
                reader.GetDateTime("date"),
                reader.GetInt16("mark")
            ));
        }

        reader.Read();

        return (student, exams); 
    }





    public void Dispose() {
        this.connection.Close();
        this.connection.Dispose();
        Console.WriteLine("- БД");
    }
}