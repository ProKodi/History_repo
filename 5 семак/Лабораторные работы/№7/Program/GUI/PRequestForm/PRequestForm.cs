using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mysqlx;

namespace Connection_lab
{
    public partial class PRequestForm : Form
    {
        public PRequestForm()
        {
            InitializeComponent();
        }


        private async void EditingData_Click(object sender, EventArgs e){
            try
            {
                string? inputchar = this.InputBox.Text;
                if (inputchar == null || inputchar == "")
                {
                    throw new Exception("Некорректные данные");
                }
                List<Strudent> res = await DataBase.SinglDataBase.FindStudent(inputchar[0]);
                this.DataGrid.Rows.Clear();
                foreach (Strudent st in res){
                    this.DataGrid.Rows.Add(
                        st.Name, st.Sex, st.Parents, 
                        st.Address, st.PhoneNumber, st.passportData, 
                        st.Group, st.Birthday, st.DateReceipt, 
                        st.IsFullTime, st.NumberRecordBook, st.NuberCourse, 
                        st.NameSpecialty 
                    );
                }
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
