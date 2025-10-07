using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace _3_lab
{
    public partial class Form1 : Form
    {
        LogicClass buffer_logicclass;
        LogicClass olderbuffer_logicclass;
        public Form1()
        {
            InitializeComponent();
        }

        private void ZeroInput_Button_Click(object sender, EventArgs e)
        {
            Zero_button_click_highlight.Visible = true;
            Normal_button_click_highlight.Visible = false;
            Copy_button_click_highlight.Visible = false;
            LogicClass mainlogicclass = new LogicClass();
            buffer_logicclass = new LogicClass(mainlogicclass);
            Discriminant_OutputBox.Text = Convert.ToString(mainlogicclass.Discriminant());
            Equation_OutputBox.Text = mainlogicclass.Output();
            FirstRoot_OutputBox.Text = mainlogicclass.Find_firstansw();
            SecondRoot_OutputBox.Text = mainlogicclass.Find_secondansw();
        }

        private void NormalInput_Button_Click(object sender, EventArgs e)
        {
            Zero_button_click_highlight.Visible = false;
            Normal_button_click_highlight.Visible = true;
            Copy_button_click_highlight.Visible = false;
            try
            {
                float a_input = float.Parse(A_InputBox.Text);
                float b_input = float.Parse(B_InputBox.Text);
                float c_input = float.Parse(C_InputBox.Text);
                LogicClass mainlogicclass = new LogicClass(a_input, b_input, c_input);
                buffer_logicclass = new LogicClass(mainlogicclass);
                Discriminant_OutputBox.Text = Convert.ToString(mainlogicclass.Discriminant());
                Equation_OutputBox.Text = mainlogicclass.Output();
                FirstRoot_OutputBox.Text = mainlogicclass.Find_firstansw();
                SecondRoot_OutputBox.Text = mainlogicclass.Find_secondansw();
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Неправильный формат ввода! Повторите попытку...", "Ошибка!", MessageBoxButtons.OK);
            }
        }
        
        private void Copy_Button_Click(object sender, EventArgs e)
        {
            Zero_button_click_highlight.Visible = false;
            Normal_button_click_highlight.Visible = false;
            Copy_button_click_highlight.Visible = true;
            try
            {
                LogicClass mainlogicclass = new LogicClass(buffer_logicclass);
                Discriminant_OutputBox.Text = Convert.ToString(mainlogicclass.Discriminant());
                Equation_OutputBox.Text = mainlogicclass.Output();
                FirstRoot_OutputBox.Text = mainlogicclass.Find_firstansw();
                SecondRoot_OutputBox.Text = mainlogicclass.Find_secondansw();
            }
            catch (System.NullReferenceException)
            {
                MessageBox.Show("Не с чего копировать! Воспользуйтесь другим способом ввода...", "Ошибка!", MessageBoxButtons.OK);
            }
        }
    }
}

