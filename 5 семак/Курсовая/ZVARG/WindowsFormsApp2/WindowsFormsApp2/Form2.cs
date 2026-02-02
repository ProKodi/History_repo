using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Курсовая;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            this.comboBox1.Items.Clear();

            DataTable dataTable = Utils.executeGetQuerry("SELECT INFORMATION_SCHEMA.TABLES.TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE INFORMATION_SCHEMA.TABLES.TABLE_TYPE = 'BASE TABLE';");

            foreach (DataRow row in dataTable.Rows)
            {
                String tableName = row["TABLE_NAME"].ToString();
                this.comboBox1.Items.Add(tableName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Выбирите элемент для начала!");
                return;
            }

            Utils.updateTableFromData(((DataView)this.dataGridView1.DataSource).Table, comboBox1.SelectedItem.ToString());
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = Utils.executeGetQuerry("SELECT * FROM " + comboBox1.SelectedItem).DefaultView;
        }
    }
}
