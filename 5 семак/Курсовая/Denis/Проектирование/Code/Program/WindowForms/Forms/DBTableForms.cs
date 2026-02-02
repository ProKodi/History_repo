



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
    public FormClients(): base("clients"){}

}

class FormMenuItem: AbstractDBForms{
    public FormMenuItem(): base("menu_item"){}
}


class FormOrders: AbstractDBForms{
    public FormOrders(): base("orders"){}
}

class FormPositions: AbstractDBForms{
    public FormPositions(): base("positions"){}
}

class FormRangeDishes: AbstractDBForms{
    public FormRangeDishes(): base("range_dishes"){}
}

class FormRestaurants: AbstractDBForms{
    public FormRestaurants(): base("restaurants"){
        // INSERT
        adapter.InsertCommand = new MySqlCommand(
            "INSERT INTO restaurants (name, mark_feedback, address, cout_star, id_schedule) " +
            "VALUES (@name, @mark_feedback, @address, @cout_star, @id_schedule)",
            DataBase.SinglDataBase.connection);

        adapter.InsertCommand.Parameters.Add("@name", MySqlDbType.VarChar, 0, "name");
        adapter.InsertCommand.Parameters.Add("@mark_feedback", MySqlDbType.Float, 0, "mark_feedback");
        adapter.InsertCommand.Parameters.Add("@address", MySqlDbType.VarChar, 0, "address");
        adapter.InsertCommand.Parameters.Add("@cout_star", MySqlDbType.Int16, 0, "cout_star");
        adapter.InsertCommand.Parameters.Add("@id_schedule", MySqlDbType.Int64, 0, "id_schedule");

        // UPDATE
        adapter.UpdateCommand = new MySqlCommand(
            "UPDATE restaurants SET name=@name, mark_feedback=@mark_feedback, address=@address, cout_star=@cout_star, id_schedule=@id_schedule " +
            "WHERE id=@id;",
            DataBase.SinglDataBase.connection);

        // SET — новые значения
        adapter.UpdateCommand.Parameters.Add("@name", MySqlDbType.VarChar, 0, "name").SourceVersion = DataRowVersion.Current;
        adapter.UpdateCommand.Parameters.Add("@mark_feedback", MySqlDbType.Float, 0, "mark_feedback").SourceVersion = DataRowVersion.Current;
        adapter.UpdateCommand.Parameters.Add("@address", MySqlDbType.VarChar, 0, "address").SourceVersion = DataRowVersion.Current;
        adapter.UpdateCommand.Parameters.Add("@cout_star", MySqlDbType.Int16, 0, "cout_star").SourceVersion = DataRowVersion.Current;
        adapter.UpdateCommand.Parameters.Add("@id_schedule", MySqlDbType.Int64, 0, "id_schedule").SourceVersion = DataRowVersion.Current;

        // WHERE — старое значение PK
        adapter.UpdateCommand.Parameters.Add("@id", MySqlDbType.Int64, 0, "id").SourceVersion = DataRowVersion.Original;

        // DELETE
        adapter.DeleteCommand = new MySqlCommand(
            "DELETE FROM restaurants WHERE id=@id",
            DataBase.SinglDataBase.connection);

        adapter.DeleteCommand.Parameters.Add("@id", MySqlDbType.Int64, 0, "id").SourceVersion = DataRowVersion.Original;

        // Привязываем DataTable к DataGridView
        this.DataGrid.DataSource = table;

    }
}

class FormSchedule: AbstractDBForms{
    public FormSchedule(): base("schedule"){}
}

class FormWorkers: AbstractDBForms{
    public FormWorkers(): base("workers"){}
}

class FormOrderDish: AbstractDBForms{
    public FormOrderDish(): base("order_dish"){

        // INSERT
        adapter.InsertCommand = new MySqlCommand(
            "INSERT INTO order_dish (id_orders, id_menu_item) " +
            "VALUES (@id_orders, @id_menu_item)",
            DataBase.SinglDataBase.connection);

        adapter.InsertCommand.Parameters.Add("@id_orders", MySqlDbType.Int64, 0, "id_orders");
        adapter.InsertCommand.Parameters.Add("@id_menu_item", MySqlDbType.Int64, 0, "id_menu_item");

        // UPDATE
        adapter.UpdateCommand = new MySqlCommand(
            "UPDATE order_dish SET id_orders = @id_orders, id_menu_item = @id_menu_item " +
            "WHERE id_orders = @id_orders AND id_menu_item=@id_menu_item",
            DataBase.SinglDataBase.connection);

        // ключи (используем значение из DataRow)
        adapter.UpdateCommand.Parameters.Add("@id_orders", MySqlDbType.Int64, 0, "id_orders")
            .SourceVersion = DataRowVersion.Original;
        adapter.UpdateCommand.Parameters.Add("@id_menu_item", MySqlDbType.Int64, 0, "id_menu_item")
            .SourceVersion = DataRowVersion.Original;

        // DELETE
        adapter.DeleteCommand = new MySqlCommand(
            "DELETE FROM order_dish WHERE id_orders=@id_orders AND id_menu_item=@id_menu_item",
            DataBase.SinglDataBase.connection);

        adapter.DeleteCommand.Parameters.Add("@id_orders", MySqlDbType.Int64, 0, "id_orders")
            .SourceVersion = DataRowVersion.Original;
        adapter.DeleteCommand.Parameters.Add("@id_menu_item", MySqlDbType.Int64, 0, "id_menu_item")
            .SourceVersion = DataRowVersion.Original;

        this.DataGrid.DataSource = table;
    }
}