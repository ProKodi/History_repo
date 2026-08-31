



using System.Collections;
using MySql.Data.MySqlClient;


namespace MyDataBase;


class MySqlDataBase: IDataBase {
    /// <summary> Подключение к БД </summary>
    public MySqlConnection Connection { get; }


    public MySqlDataBase() {
        Console.WriteLine("Initializing MySqlDataBase...");
        Connection = new MySqlConnection($"Server={"localhost"};Port={"3322"};Database={"practic"};User ID={"user"};Password={"password"};");
        Connection.Open();
    }


    public List<ArrayList> GetRequest1(){
        using var command = new MySqlCommand(
            """
            SELECT id, name, surname, patronymic, telephone, street, house
            FROM practic.clients;
            """, this.Connection
        );
        using var reader = command.ExecuteReader();


        List<ArrayList> res = [];

        while (reader.Read()){
            res.Add(new ArrayList(){
                reader["name"].Equals( DBNull.Value ) ? null : reader["name"].ToString(), 
                reader["surname"].Equals( DBNull.Value ) ? null : reader["surname"].ToString(), 
                reader["patronymic"].Equals( DBNull.Value ) ? null : reader["patronymic"].ToString(), 
                reader["telephone"].Equals( DBNull.Value ) ? null : reader["telephone"].ToString(), 
                reader["street"].Equals( DBNull.Value ) ? null : reader["street"].ToString(), 
                reader["house"].Equals( DBNull.Value ) ? null : reader["house"].ToString()
            });
        }
        return res;
    }


    public List<ArrayList> GetRequest2(){
        using var command = new MySqlCommand(
            """SELECT * FROM practic.workers; """, this.Connection
        );
        using var reader = command.ExecuteReader();

        List<ArrayList> res = [];

        while (reader.Read()){
            res.Add(new ArrayList(){
                reader["name"].Equals( DBNull.Value ) ? null : reader["name"].ToString(), 
                reader["surname"].Equals( DBNull.Value ) ? null : reader["surname"].ToString(), 
                reader["patronymic"].Equals( DBNull.Value ) ? null : reader["patronymic"].ToString(), 
                reader["telephone"].Equals( DBNull.Value ) ? null : reader["telephone"].ToString(), 
            });
        }
        return res;
    }

    public List<ArrayList> GetRequest3(){
        using var command = new MySqlCommand(
            """
            SELECT
                c.id,
                CONCAT(c.surname, ' ', c.name) AS client,
                l.name AS language,
                ll.name_level AS level
            FROM practic.clients c
            JOIN practic.client_language cl
                ON c.id = cl.id_client
            JOIN practic.languages l
                ON cl.id_language = l.id
            LEFT JOIN practic.lenguage_levele ll
                ON cl.id_level = ll.id
            ORDER BY c.id;
            
            """, this.Connection
        );
        using var reader = command.ExecuteReader();

        List<ArrayList> res = [];

        while (reader.Read()){
            res.Add(new ArrayList(){
                reader["client"].Equals( DBNull.Value ) ? null : reader["client"].ToString(), 
                reader["language"].Equals( DBNull.Value ) ? null : reader["language"].ToString(), 
                reader["level"].Equals( DBNull.Value ) ? null : reader["level"].ToString(), 
            });
        }
        return res;
    }


    public List<ArrayList> GetRequest4(){
        using var command = new MySqlCommand(
            """
            SELECT
                l.name AS language,
                COUNT(cl.id_client) AS client_count
            FROM practic.languages l
            LEFT JOIN practic.client_language cl
                ON l.id = cl.id_language
            GROUP BY l.id, l.name
            ORDER BY client_count DESC;
            
            """, this.Connection
        );
        using var reader = command.ExecuteReader();

        List<ArrayList> res = [];

        while (reader.Read()){
            res.Add(new ArrayList(){
                reader["language"].Equals( DBNull.Value ) ? null : reader["language"].ToString(), 
                reader["client_count"].Equals( DBNull.Value ) ? null : reader["client_count"].ToString(), 
            });
        }
        return res;
    }


    public List<ArrayList> GetRequest5(){
        using var command = new MySqlCommand(
            """
            SELECT
                l.name AS language,
                COUNT(wl.id_worker) AS worker_count
            FROM practic.languages l
            LEFT JOIN practic.worker_language wl
                ON l.id = wl.id_language
            GROUP BY l.id, l.name
            ORDER BY worker_count DESC;
            
            """, this.Connection
        );
        using var reader = command.ExecuteReader();

        List<ArrayList> res = [];

        while (reader.Read()){
            res.Add(new ArrayList(){
                reader["language"].Equals( DBNull.Value ) ? null : reader["language"].ToString(), 
                reader["worker_count"].Equals( DBNull.Value ) ? null : reader["worker_count"].ToString(), 
            });
        }
        return res;
    }

    public void Dispose() {
        Console.WriteLine("Disposing MySqlDataBase...");
        Connection.Dispose();
    }
}


