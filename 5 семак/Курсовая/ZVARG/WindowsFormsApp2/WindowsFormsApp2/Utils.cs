using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсовая
{
    internal class Utils
    {



        public static string ShowInputDialog(string text)
        {
            Form prompt = new Form()
            {
                Width = 400,
                Height = 180,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = "Введите данные",
                StartPosition = FormStartPosition.CenterScreen,
                BackColor = Color.FromArgb(240, 248, 255),
                ForeColor = Color.FromArgb(41, 83, 116),
                Font = new Font("Segoe UI", 9F),
                MaximizeBox = false,
                MinimizeBox = false
            };

            Label textLabel = new Label()
            {
                Left = 25,
                Top = 25,
                Text = text,
                Width = 350,
                Font = new Font("Segoe UI", 10F, FontStyle.Regular),
                ForeColor = Color.FromArgb(41, 83, 116),
                BackColor = Color.Transparent
            };

            TextBox textBox = new TextBox()
            {
                Left = 25,
                Top = 55,
                Width = 350,
                Height = 30,
                Font = new Font("Segoe UI", 10F),
                ForeColor = Color.FromArgb(41, 83, 116),
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle
            };

            Button confirmation = new Button()
            {
                Text = "OK",
                Left = 295,
                Width = 80,
                Height = 30,
                Top = 95,
                DialogResult = DialogResult.OK,
                BackColor = Color.FromArgb(135, 206, 235),
                ForeColor = Color.FromArgb(41, 83, 116),
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 9F, FontStyle.Bold)
            };

            // Стилизация кнопки
            confirmation.FlatAppearance.BorderColor = Color.FromArgb(173, 216, 230);
            confirmation.FlatAppearance.MouseOverBackColor = Color.FromArgb(175, 238, 238);
            confirmation.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 191, 255);

            confirmation.Click += (sender, e) => { prompt.Close(); };

            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;

            // Добавляем обработчики для красивого hover эффекта на текстовом поле
            textBox.Enter += (sender, e) =>
            {
                textBox.BackColor = Color.FromArgb(224, 242, 254);
                textBox.BorderStyle = BorderStyle.FixedSingle;
            };

            textBox.Leave += (sender, e) =>
            {
                textBox.BackColor = Color.White;
                textBox.BorderStyle = BorderStyle.FixedSingle;
            };

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
        }

        public static String connectionString = "Data Source=DESKTOP-60D6NP0;Initial Catalog=vlad;Integrated Security=True";

        public static void updateTableFromData(DataTable dataTable, String tableName)
        {


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();


                String selectQuery = $"SELECT * FROM {tableName}";
                SqlDataAdapter adapter = new SqlDataAdapter(selectQuery, connection);


                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);


                adapter.Update(dataTable);

                MessageBox.Show("Данные успешно обновлены!", "Успех",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        public static void executeQuerry(String query)
        {
            executeQuerry(query, new Dictionary<string, string>());
        }

        public static void executeQuerry(String query, Dictionary<String, String> parametrValues)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                foreach (var parametrs in parametrValues)
                {
                    query = query.Replace("@" + parametrs.Key, parametrs.Value);
                }

                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.ExecuteNonQuery();
                }
            }
        }

        public static DataTable executeGetQuerry(String query)
        {
            return executeGetQuerry(query, new Dictionary<string, string>());
        }

        public static DataTable executeGetQuerry(String query, Dictionary<String, String> parametrValues)
        {
            DataSet ds = new DataSet();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();


                    foreach (var parametrs in parametrValues)
                    {
                        query = query.Replace("@" + parametrs.Key, parametrs.Value);
                    }

                    using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                    {

                        using (SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand))
                        {
                            adapter.Fill(ds);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при выполнении запроса: {ex.Message}", "Ошибка",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            return ds.Tables[0];
        }

    }
}
