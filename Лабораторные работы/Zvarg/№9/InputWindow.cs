using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9_lab___C_
{
    public partial class InputWindow : Form
    {
        public InputWindow()
        {
            InitializeComponent();
        }
        public string GetName()
        {
            return Name_InputBox.Text;
        }
        public string GetSurname()
        {
            return Surname_InputBox.Text;
        }
        public string GetAge()
        {
            return Age_InputBox.Text;
        }
        public string GetTrait()
        {
            return Trait_InputBox.Text;
        }
        public string GetKey()
        {
            return Key_InputBox.Text;
        }

        private void Confirm_Button_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
