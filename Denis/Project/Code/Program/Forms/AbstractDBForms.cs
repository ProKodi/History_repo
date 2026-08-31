



using Autofac;
using MySql.Data.MySqlClient;
using System.Data;


class AbstractDBForms: AbstractTableForm{
    protected MySqlDataAdapter adapter;
    protected DataTable table;

    public AbstractDBForms(string table_name): base([]){
        adapter = new MySqlDataAdapter(
            $"SELECT * FROM {table_name}", 
            Program.DiConteiner.Resolve<MyDataBase.IDataBase>().Connection
        );

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

