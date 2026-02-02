



using MySql.Data.MySqlClient;
using System.Data;


abstract class AbstractDBForms: AbstractTableForm{
    protected MySqlDataAdapter adapter;
    protected DataTable table;

    public AbstractDBForms(string table_name): base(){
        adapter = new MySqlDataAdapter($"SELECT * FROM {table_name}", DataBase.SinglDataBase.connection);

        table = new DataTable();
        adapter.Fill(table);
        this.DataGrid.DataSource = table;
    }

    public override  void BtGetData_Click(object sender, EventArgs e){
        try{
            // Команд builder автоматически генерирует команды INSERT/UPDATE/DELETE
            MySqlCommandBuilder builder = new MySqlCommandBuilder(adapter);
            adapter.Update(table); // Сохраняем все изменения в БД
            MessageBox.Show("Данные успешно обновлены!");
        }
        catch (Exception ex){
            MessageBox.Show($"Ошибка при сохранении: {ex.Message}");
        }
    }
}


class FormClients: AbstractDBForms{
    public FormClients(): base("customer"){}
}

class FormMenuItem: AbstractDBForms{
    public FormMenuItem(): base("department"){}
}


class FormOrders: AbstractDBForms{
    public FormOrders(): base("`order`"){}
}

class FormPositions: AbstractDBForms{
    public FormPositions(): base("possessions"){
        // INSERT
        adapter.InsertCommand = new MySqlCommand(
            "INSERT INTO possessions (adress, city, square, id_type, cost, id_rieltor, state, id_salesmans) " +
            "VALUES (@adress, @city, @square, @id_type, @cost, @id_rieltor, @state, @id_salesmans)",
            DataBase.SinglDataBase.connection);

        adapter.InsertCommand.Parameters.Add("@adress", MySqlDbType.VarChar, 0, "adress");
        adapter.InsertCommand.Parameters.Add("@city", MySqlDbType.VarChar, 0, "city");
        adapter.InsertCommand.Parameters.Add("@square", MySqlDbType.Float, 0, "square");
        adapter.InsertCommand.Parameters.Add("@id_type", MySqlDbType.UInt64, 0, "id_type");
        adapter.InsertCommand.Parameters.Add("@cost", MySqlDbType.UInt32, 0, "cost");

        adapter.InsertCommand.Parameters.Add("@id_rieltor", MySqlDbType.UInt64, 0, "id_rieltor");
        adapter.InsertCommand.Parameters.Add("@state", MySqlDbType.VarChar, 0, "state");
        adapter.InsertCommand.Parameters.Add("@id_salesmans", MySqlDbType.UInt64, 0, "id_salesmans");

        // UPDATE
        adapter.UpdateCommand = new MySqlCommand(
            "UPDATE possessions SET adress = @adress, city = @city, square = @square, id_type = @id_type, cost = @cost," +
            " id_rieltor = @id_rieltor, state = @state, id_salesmans = @id_salesmans " +
            "WHERE id=@id;",
            DataBase.SinglDataBase.connection
        );

        // SET — новые значения
        adapter.UpdateCommand.Parameters.Add("@adress", MySqlDbType.VarChar, 0, "adress").SourceVersion = DataRowVersion.Current;
        adapter.UpdateCommand.Parameters.Add("@city", MySqlDbType.VarChar, 0, "city").SourceVersion = DataRowVersion.Current;
        adapter.UpdateCommand.Parameters.Add("@square", MySqlDbType.Float, 0, "square").SourceVersion = DataRowVersion.Current;
        adapter.UpdateCommand.Parameters.Add("@id_type", MySqlDbType.UInt64, 0, "id_type").SourceVersion = DataRowVersion.Current;
        adapter.UpdateCommand.Parameters.Add("@cost", MySqlDbType.UInt32, 0, "cost").SourceVersion = DataRowVersion.Current;
        adapter.UpdateCommand.Parameters.Add("@id_rieltor", MySqlDbType.UInt64, 0, "id_rieltor").SourceVersion = DataRowVersion.Current;
        adapter.UpdateCommand.Parameters.Add("@state", MySqlDbType.VarChar, 0, "state").SourceVersion = DataRowVersion.Current;
        adapter.UpdateCommand.Parameters.Add("@id_salesmans", MySqlDbType.UInt64, 0, "id_salesmans").SourceVersion = DataRowVersion.Current;

        // WHERE — старое значение PK
        adapter.UpdateCommand.Parameters.Add("@id", MySqlDbType.Int64, 0, "id").SourceVersion = DataRowVersion.Original;

        // DELETE
        adapter.DeleteCommand = new MySqlCommand(
            "DELETE FROM possessions WHERE id=@id",
            DataBase.SinglDataBase.connection
        );

        adapter.DeleteCommand.Parameters.Add("@id", MySqlDbType.Int64, 0, "id").SourceVersion = DataRowVersion.Original;

        // Привязываем DataTable к DataGridView
        this.DataGrid.DataSource = table;
    }
}

class FormRangeDishes: AbstractDBForms{
    public FormRangeDishes(): base("rieltor"){}
}

class FormRestaurants: AbstractDBForms{
    public FormRestaurants(): base("salesmans"){}
}

class FormSchedule: AbstractDBForms{
    public FormSchedule(): base("type_position"){}
}

class FormWorkers: AbstractDBForms{
    public FormWorkers(): base("vision"){}
}
