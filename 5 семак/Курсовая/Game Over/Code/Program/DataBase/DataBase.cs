



// dotnet add package MySql.Data
using MySql.Data.MySqlClient;
using System.Text.Json;


class DataBase: IDisposable{
    /// Одиночка для работы с БД
    public static DataBase SinglDataBase;
    
    /// <summary> Создание одиночки </summary>
    static DataBase(){ 
        ApplicationConfiguration.Initialize();

        var input_form = new LoginForm();
        Application.Run(input_form);

        if (input_form.login == null || input_form.password == null){
            MessageBox.Show("Вы не ввели логин или пароль", "Вы не ввели данные");
            Environment.Exit(0);
        }

        using var doc = JsonDocument.Parse(File.ReadAllText("../../../Program/DataBase/Conection.json"));

        // Пользователь
        string? user = doc.RootElement.GetProperty("login").GetString();
        // Пароль пользователя
        string? password = doc.RootElement.GetProperty("password").GetString();


        if(user == null || password == null){ Environment.Exit(-1); }

        // SinglDataBase = new DataBase(input_form.login, input_form.password); 
        SinglDataBase = new DataBase(user, password);
    }

    /// <summary> Подключение к БД </summary>
    public MySqlConnection connection; 

    /// <summary> Подключаемся к БД и проверяем что есть БД Lily </summary>
    protected DataBase(string user, string password){
        // Сервер с БД
        string server = "localhost";
        // Название БД
        string student = "position";
        try{
            this.connection = new MySqlConnection($"Server={server};Database={student};User ID={user};Password={password};");
            // Открываем подключение к БД
            this.connection.Open();
        }
        catch{
            MessageBox.Show("Не удалось подключится к БД", "Ошибка подключения", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Environment.Exit(0);
        }
    }


    public void Dispose() {
        this.connection.Close();
        this.connection.Dispose();
        Console.WriteLine("- DataBase");
    }
}