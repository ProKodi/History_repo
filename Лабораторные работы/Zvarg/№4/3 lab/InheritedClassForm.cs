using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


    public partial class InheritedClassForm : Form
    {
        InheritedClass bufferInheritedClass;
        InheritedClass olderbufferInheritedClass;
        InheritedClass classforcompar;
        Random rand = new Random();

        public InheritedClassForm()
        {
            InitializeComponent();
        }

        public InheritedClassForm(InheritedClass inheritedClass)
        {
            InitializeComponent();
            this.bufferInheritedClass = inheritedClass;
        }

    private void ComparisonButton_Click(object sender, EventArgs e)
    {
        ComparisonButtonHighlight.Visible = true;
        AltComparisonButtonHighlight.Visible = false;
        Main_ComputingButtonHightlight.Visible = false;
        try
        {
            if (Equation_Setup_Method_ListBox.CheckedItems.Count > 1 || Equation_Setup_Method_ListBox.CheckedItems.Count == 0)
            {
                MessageBox.Show("Пожалуйста, выберите 1 вариант из предоставленных и повторите попытку.", "Ошибка!", MessageBoxButtons.OK);
            }
            else
            {
                if (Equation_Setup_Method_ListBox.SelectedIndex == 0)
                {
                    classforcompar = new InheritedClass();
                }
                if (Equation_Setup_Method_ListBox.SelectedIndex == 1)
                {
                    float a_inhinput = float.Parse(InhA_InputBox.Text);
                    float b_inhinput = float.Parse(InhB_InputBox.Text);
                    float c_inhinput = float.Parse(InhC_InputBox.Text);
                    classforcompar = new InheritedClass(a_inhinput, b_inhinput, c_inhinput);
                    olderbufferInheritedClass = classforcompar;
                }
                if (Equation_Setup_Method_ListBox.SelectedIndex == 2)
                {
                    classforcompar = olderbufferInheritedClass;
                }
                if (Equation_Setup_Method_ListBox.SelectedIndex == 3)
                {
                    classforcompar = new InheritedClass(rand.Next(), rand.Next(), rand.Next());
                }
                if (this.classforcompar == bufferInheritedClass)
                {
                    MessageBox.Show("Выражения равны!", "Результат.", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Выражения неравны!", "Результат.", MessageBoxButtons.OK);
                }
            }
        }
        catch (NullReferenceException)
        {
            MessageBox.Show("Не с чем сравнивать! Введите второе выражение и повторите попытку.", "Ошибка!", MessageBoxButtons.OK);
        }
        catch (FormatException)
        {
            MessageBox.Show("Кажется, вы не ввели предполагаемые параметры. Повторите попытку.", "Ошибка!", MessageBoxButtons.OK);
        }
    }

    private void AltComparisonButton_Click(object sender, EventArgs e)
    {
        ComparisonButtonHighlight.Visible = false;
        AltComparisonButtonHighlight.Visible = true;
        Main_ComputingButtonHightlight.Visible = false;
        try
        {
            if (Equation_Setup_Method_ListBox.CheckedItems.Count > 1 || Equation_Setup_Method_ListBox.CheckedItems.Count == 0)
            {
                MessageBox.Show("Пожалуйста, выберите 1 вариант из предоставленных и повторите попытку.", "Ошибка!", MessageBoxButtons.OK);
            }
            else
            {
                if (Equation_Setup_Method_ListBox.SelectedIndex == 0)
                {
                    classforcompar = new InheritedClass();
                }
                if (Equation_Setup_Method_ListBox.SelectedIndex == 1)
                {
                    float a_inhinput = float.Parse(InhA_InputBox.Text);
                    float b_inhinput = float.Parse(InhB_InputBox.Text);
                    float c_inhinput = float.Parse(InhC_InputBox.Text);
                    classforcompar = new InheritedClass(a_inhinput, b_inhinput, c_inhinput);
                    olderbufferInheritedClass = classforcompar;
                }
                if (Equation_Setup_Method_ListBox.SelectedIndex == 2)
                {
                    classforcompar = olderbufferInheritedClass;
                }
                if (Equation_Setup_Method_ListBox.SelectedIndex == 3)
                {
                    classforcompar = new InheritedClass(rand.Next(), rand.Next(), rand.Next());
                }
                if (this.classforcompar != bufferInheritedClass)
                {
                    MessageBox.Show("Выражения неравны!", "Результат.", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Выражения равны!", "Результат.", MessageBoxButtons.OK);
                }
            }
        }
        catch (NullReferenceException)
        {
            MessageBox.Show("Не с чем сравнивать! Введите второе выражение и повторите попытку.", "Ошибка!", MessageBoxButtons.OK);
        }
        catch (FormatException)
        {
            MessageBox.Show("Кажется, вы не ввели предполагаемые параметры. Повторите попытку.", "Ошибка!", MessageBoxButtons.OK);
        }
    }

    private void Main_ComputingButton_Click(object sender, EventArgs e)
    {
        ComparisonButtonHighlight.Visible = false;
        AltComparisonButtonHighlight.Visible = false;
        Main_ComputingButtonHightlight.Visible = true;
        if (Equation_Setup_Method_ListBox.CheckedItems.Count > 1 || Equation_Setup_Method_ListBox.CheckedItems.Count == 0)
        {
            MessageBox.Show("Пожалуйста, выберите 1 вариант из предоставленных и повторите попытку.", "Ошибка!", MessageBoxButtons.OK);
        }
        else
        {
            if (Equation_Setup_Method_ListBox.SelectedIndex == 0)
            {
                olderbufferInheritedClass = new InheritedClass();
                MessageBox.Show("Это выражение...просто равно нулю. В нём мало смысла, это просто ноль.", "Ответ.", MessageBoxButtons.OK);
            }
            if (Equation_Setup_Method_ListBox.SelectedIndex == 1)
            {
                try
                {
                    float a_inhinput = float.Parse(InhA_InputBox.Text);
                    float b_inhinput = float.Parse(InhB_InputBox.Text);
                    float c_inhinput = float.Parse(InhC_InputBox.Text);
                    classforcompar = new InheritedClass(a_inhinput, b_inhinput, c_inhinput);
                    olderbufferInheritedClass = classforcompar;
                    MessageBox.Show($"Дискриминант равен: {classforcompar.Discriminant()}, корень 1 равен: {classforcompar.Find_firstansw()}, корень 2 равен: {classforcompar.Find_secondansw()}", "Ответ.", MessageBoxButtons.OK);
                }
                catch (System.FormatException)
                {
                    MessageBox.Show("Кажется, вы не ввели предполагаемые параметры. Повторите попытку.", "Ошибка!", MessageBoxButtons.OK);
                }
            }
            if (Equation_Setup_Method_ListBox.SelectedIndex == 2)
            {
                try
                {
                    classforcompar = olderbufferInheritedClass;
                    MessageBox.Show($"Дискриминант равен: {classforcompar.Discriminant()}, корень 1 равен: {classforcompar.Find_firstansw()}, корень 2 равен: {classforcompar.Find_secondansw()}", "Ответ.", MessageBoxButtons.OK);
                }
                catch (NullReferenceException)
                {
                    MessageBox.Show("Не с чего копировать! Повторите попытку.", "Ошибка!", MessageBoxButtons.OK);
                }
            }
            if (Equation_Setup_Method_ListBox.SelectedIndex == 3)
            {
                classforcompar = new InheritedClass(rand.Next(), rand.Next(), rand.Next());
                MessageBox.Show($"Дискриминант равен: {classforcompar.Discriminant()}, корень 1 равен: {classforcompar.Find_firstansw()}, корень 2 равен: {classforcompar.Find_secondansw()}", "Ответ.", MessageBoxButtons.OK);
            }
        }
    }
    }

