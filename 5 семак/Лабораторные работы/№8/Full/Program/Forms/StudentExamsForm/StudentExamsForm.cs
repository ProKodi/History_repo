using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


public partial class StudentExamsForm : Form{
    protected ulong CurentItem = 0;

    public StudentExamsForm(){
        InitializeComponent();
        this.ShowItems(this.CurentItem);
    }


    private void LeftScrollButton_Click(object sender, EventArgs e){
        if(this.CurentItem == 0){
            this.LeftScrollButton.Enabled = false;
            return;
        }
        this.ShowItems(this.CurentItem - 1);
    }

    private void RightScrollButton_Click(object sender, EventArgs e){
        this.LeftScrollButton.Enabled = true;
        this.ShowItems(this.CurentItem + 1);
    }


    protected async void ShowItems(ulong newselect){
        try{

            (StrudentShort res, List<Exam> resexm) = await DataBase.SinglDataBase.FindExam(newselect);
            this.dataGridView1.Rows.Clear();

            foreach (var res1 in resexm){
                this.dataGridView1.Rows.Add(
                    res1.IdDiscipline.ToString(), res1.Date.ToString(), res1.Mark.ToString()
                );
            }

            textBox1.Text = res.Name;
            textBox2.Text = res.Sex;
            textBox3.Text = res.passportData;
            textBox4.Text = res.Group;
            textBox5.Text = res.Birthday.ToString();

            this.CurentItem = newselect;
        }
        catch (Exception err){
            MessageBox.Show(err.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }



    }

}
