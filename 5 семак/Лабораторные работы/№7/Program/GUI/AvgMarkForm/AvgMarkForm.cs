using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Connection_lab
{
    public partial class AvgMarkForm : Form
    {
        public  AvgMarkForm()
        {
            InitializeComponent();

        }

        private async void AvgMarkCalc_Click(object sender, EventArgs e)
        {
            this.AvgMarkBox.Text = (await DataBase.SinglDataBase.AvgAll()).ToString();
            List<(string, float)> values = await DataBase.SinglDataBase.AvgAny();
            this.AvgMarkDataGrid.Rows.Clear();
            foreach ((string name, float avg) in values)
            {
                this.AvgMarkDataGrid.Rows.Add(name, avg.ToString());
            }
        }
    }
}
