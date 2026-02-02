using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


public partial class SpecialtyStudentsForm : Form{

    protected ulong CurentItem = 0;

    public SpecialtyStudentsForm(){ 
        InitializeComponent(); 
        this.ShowItems(0);
    }


    private async void LeftScrollButton_Click(object sender, EventArgs e){
        if(this.CurentItem == 0){
            this.LeftScrollButton.Enabled = false;
            return;
        }
        this.ShowItems(this.CurentItem - 1);
    }

    private async void RightScrollButton_Click(object sender, EventArgs e){
        this.LeftScrollButton.Enabled = true;
        this.ShowItems(this.CurentItem + 1);
    }

    protected async void ShowItems(ulong newselect){
        try{

            (Strudent res, string? name, string? describe) = await DataBase.SinglDataBase.FindStudent(newselect);
            this.dataGridView1.Rows.Clear();

            this.dataGridView1.Rows.Add(
                res.Name, res.Sex, res.Parents, 
                res.Address, res.PhoneNumber, res.passportData, 
                res.Group, res.Birthday, res.DateReceipt, 
                res.IsFullTime, res.NumberRecordBook, res.NuberCourse 
            );
            textBox1.Text = name;
            textBox2.Text = describe;
            
            this.CurentItem = newselect;
        }
        catch (Exception err){
            MessageBox.Show(err.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }



    }
}
