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
    public partial class OutputWindow : Form
    {
        public OutputWindow()
        {
            InitializeComponent();
        }
        public void Add_Client_Info(string client_info)
        {
            Output_TextBox.Items.Add(client_info);
        }
    }
}
