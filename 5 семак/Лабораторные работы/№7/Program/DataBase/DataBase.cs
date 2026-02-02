



using System.Runtime.CompilerServices;
// dotnet add package MySql.Data
using MySql.Data.MySqlClient;

using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Text;





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
        // Пользователь
        string user = "root";
        // Пароль пользователя
        string password = "123oihoihtfr43fe";
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

    /// <summary> Список специальностей </summary>
    public async Task<List<string>> GetNameSpetialitest(){
        Task<MySqlDataReader> command = Task.Run(() =>{
            using var command = new MySqlCommand("""
                SELECT name FROM specialties
                """, this.connection
            );
            return command.ExecuteReader();
        });
        List<string> res = [];
        using var reader = await command;

        while (reader.Read()){ res.Add((string)(reader["name"])); }
        return res;
    }


    /// <summary> Выдать данные о студентах </summary>
    public async Task<List<(long, Strudent)>> GetStudent(){
        Task<MySqlDataReader> command = Task.Run(() =>{
            using var command = new MySqlCommand("""
                SELECT 
                    students.id AS stud_id, students.name AS stud_name, sex,
                    parents, address, phone_number, passport_data, `group`,
                    birthday, date_receipt, is_full_time, number_record_book,
                    nuber_course, specialties.name as sp_name
                FROM students
                    JOIN specialties
                    ON students.id_specialty = specialties.id;
                """, this.connection
            );
            return command.ExecuteReader();
        });
        List<(long, Strudent)> res = [];
        using var reader = await command;

        while (reader.Read()){
            res.Add((
                Convert.ToInt64(reader["stud_id"]), 
                new Strudent(
                (string)(reader["stud_name"]), (string)(reader["sex"]), (string)(reader["parents"]),
                (string)(reader["address"]), (string)(reader["phone_number"]),
                (string)(reader["passport_data"]), (string)(reader["group"]),
                Convert.ToDateTime(reader["birthday"]), Convert.ToDateTime(reader["date_receipt"]),
                Convert.ToBoolean(reader["is_full_time"]), Convert.ToInt32(reader["number_record_book"]),
                Convert.ToInt16(reader["nuber_course"]), (string)(reader["sp_name"])
            )));
        }
        return res;
    }

    /// <summary> Удалить данные о студентах по ID (На вызов добавить обработчик на Exception) </summary>
    public async Task DeleteStudent(params long[] strudent){
        foreach(long id in strudent){
            Task command = Task.Run(() =>{
                using var command = new MySqlCommand($"""
                    DELETE FROM students 
                    WHERE
                        id = @dell_id;
                    """, this.connection
                );
                command.Parameters.AddWithValue("@dell_id", id);
            });
            await command;
        }
    }

    /// <summary> Изменить данные о студентах (На вызов добавить обработчик на Exception) </summary>
    public async Task SetStudent(params (long, Strudent)[] strudent){
        Dictionary<string, long> spet = await GetSpetialitest();
        foreach((long id, Strudent st) in strudent){
            SheckSQLIniection(st.Name, st.Sex, st.Parents, st.Address, st.PhoneNumber, st.passportData, st.Group); 

            Task command = Task.Run(() =>{
                using var command = new MySqlCommand($"""
                    UPDATE students
                    SET 
                        address = {st.Address},
                        sex = {st.Sex},
                        parents = {st.Parents}, 
                        address = {st.Address}, 
                        phone_number  = {st.PhoneNumber},
                        passport_data = {st.passportData},
                        `group` = {st.Group},
                        birthday = @new_birthday, 
                        date_receipt = @new_date_receipt, 
                        is_full_time = @new_is_full_time,
                        number_record_book = @new_number_record_book,
                        nuber_course = @new_nuber_course,
                        id_specialty = @new_id_specialty
                    WHERE id = @id_upd; 
                    """, this.connection
                );
                command.Parameters.AddWithValue("@new_birthday", st.Birthday);
                command.Parameters.AddWithValue("@new_date_receipt", st.DateReceipt);
                command.Parameters.AddWithValue("@new_is_full_time", st.IsFullTime);
                command.Parameters.AddWithValue("@new_number_record_book", st.NumberRecordBook);
                command.Parameters.AddWithValue("@new_nuber_course", st.NuberCourse);
                command.Parameters.AddWithValue("@new_id_specialty", spet[st.NameSpecialty]);

                command.Parameters.AddWithValue("@id_upd", id);
            });
            await command;
        }
    }

    /// <summary> Добавить данные о студентах (На вызов добавить обработчик на Exception) </summary>
    public async Task SetStudent(params Strudent[] strudent){
        if(strudent.Length == 0){ return; }
        Dictionary<string, long> spet = await GetSpetialitest();

        foreach(Strudent st in strudent){
            SheckSQLIniection(st.Name, st.Sex, st.Parents, st.Address, st.PhoneNumber, st.passportData, st.Group); 

            Task command = Task.Run(() =>{
                using var command = new MySqlCommand($"""
                    INSERT INTO students (
                        name, sex, parents, address, phone_number, 
                        passport_data, `group`, birthday, date_receipt, 
                        is_full_time, number_record_book, nuber_course, 
                        id_specialty
                    )
                    VALUES
                    (
                        {st.Name}, {st.Sex}, {st.Parents}, {st.Address}, {st.PhoneNumber}, {st.passportData}, {st.Group}, 
                        @new_birthday, @new_date_receipt, @new_is_full_time, @new_number_record_book, @new_nuber_course, @new_id_specialty
                    );
                    """, this.connection
                );
                command.Parameters.AddWithValue("@new_birthday", st.Birthday);
                command.Parameters.AddWithValue("@new_date_receipt", st.DateReceipt);
                command.Parameters.AddWithValue("@new_is_full_time", st.IsFullTime);
                command.Parameters.AddWithValue("@new_number_record_book", st.NumberRecordBook);
                command.Parameters.AddWithValue("@new_nuber_course", st.NuberCourse);
                command.Parameters.AddWithValue("@new_id_specialty", spet[st.NameSpecialty]);
            });
            await command;
        }
    }


    /// <summary> Выдать данные о студентах, фамилия  которых начинается на букву П. (На вызов добавить обработчик на Exception) </summary>
    public async Task<List<Strudent>> FindStudent(char firse_char_name = 'П'){
        SheckSQLIniection($"{firse_char_name}"); 

        Task<MySqlDataReader> command = Task.Run(() =>{
            using var command = new MySqlCommand("""
                SELECT 
                    students.name AS stud_name, sex, parents, 
                    address, phone_number, 
                    passport_data, `group`, 
                    birthday, date_receipt, 
                    is_full_time, number_record_book, 
                    nuber_course, specialties.name AS sp_name
                FROM students
                    JOIN specialties 
                    ON students.id_specialty = specialties.id
                    WHERE students.name REGEXP(@regl_find); 
                """, this.connection
            );
            command.Parameters.AddWithValue("@regl_find", $"^{firse_char_name}.+$");
            return command.ExecuteReader();
        });
        List<Strudent> res = [];
        using var reader = await command;

        while (reader.Read()){
            res.Add(new Strudent(
                (string)(reader["stud_name"]), (string)(reader["sex"]), (string)(reader["parents"]),
                (string)(reader["address"]), (string)(reader["phone_number"]),
                (string)(reader["passport_data"]), (string)(reader["group"]),
                Convert.ToDateTime(reader["birthday"]), Convert.ToDateTime(reader["date_receipt"]),
                Convert.ToBoolean(reader["is_full_time"]), Convert.ToInt32(reader["number_record_book"]),
                Convert.ToInt16(reader["nuber_course"]), (string)(reader["sp_name"])
            ));
        }
        return res;
    }


    /// <summary> Поиск средний балл по всем студентам </summary>
    public async Task<float> AvgAll(){
        Task<MySqlDataReader> command = Task.Run(() =>{
            using var command = new MySqlCommand("""
                SELECT AVG(mark) AS avg_mark FROM exams;
                """, this.connection
            );
            return command.ExecuteReader();
        });
        using var reader = await command; 

        reader.Read(); // Читаем полученные результаты 
        return reader.GetFloat("avg_mark");
    }

    /// <summary> Поиск средний балл по каждому студенту. </summary>
    public async Task<List<(string, float)>> AvgAny(){
        Task<MySqlDataReader> command = Task.Run(() =>{
            using var command = new MySqlCommand("""
                SELECT name, AVG(mark) AS avg_mark FROM exams
                    JOIN students
                    ON exams.id_student = students.id
                    GROUP BY name;
                """, this.connection
            );
            return command.ExecuteReader();
        });
        List<(string, float)> res = [];
        using var reader = await command; 

        while (reader.Read()) {
            res.Add((
                (string)(reader["name"]),
                Convert.ToSingle(reader["avg_mark"])
            ));
        }
        return res;
    }

    public void Dispose() {
        this.connection.Close();
        this.connection.Dispose();
        Console.WriteLine("- БД");
    }
}