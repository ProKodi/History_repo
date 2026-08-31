



using System.Collections;
using MySql.Data.MySqlClient;


namespace MyDataBase;


public interface IDataBase: IDisposable {
    public MySqlConnection Connection { get; }

    public List<ArrayList> GetRequest1();

    public List<ArrayList> GetRequest2();

    public List<ArrayList> GetRequest3();

    public List<ArrayList> GetRequest4();

    public List<ArrayList> GetRequest5();

}


