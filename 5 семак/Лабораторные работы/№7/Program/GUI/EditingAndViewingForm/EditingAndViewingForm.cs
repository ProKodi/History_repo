using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace Connection_lab{
    public partial class EditingAndViewingForm : Form{
        protected MySqlDataAdapter adapter;
        protected DataTable table;


        List<string> list_Spet = [];

        List<(long, Strudent)> original_data = [];

        public EditingAndViewingForm(){
            InitializeComponent();

        }

        public async Task Init(){
            adapter = new MySqlDataAdapter($"SELECT * FROM students", DataBase.SinglDataBase.connection);

            table = new DataTable();
            adapter.Fill(table);
            this.MainDataGrid.Rows.Clear();

            this.MainDataGrid.DataSource = table;
            
            try{
                // Команд builder автоматически генерирует команды INSERT/UPDATE/DELETE
                MySqlCommandBuilder builder = new MySqlCommandBuilder(adapter);
                adapter.Update(table); // Сохраняем все изменения в БД
            }
            catch (Exception ex){
                MessageBox.Show($"Ошибка при открытии: {ex.Message}");
            }
        }


        private  void UpdateDataButton_Click(object sender, EventArgs e){
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
}
