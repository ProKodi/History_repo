using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void Exit_Click(object sender, EventArgs e){Application.Exit(); } // Завершение работы

        private void settings_graphics_Click(object sender, EventArgs e)
        {
            // Параметры графиков
        }

        private void build_graphics_Click(object sender, EventArgs e)
        {
            // Перестроить графики
        }

        private void clean_Click(object sender, EventArgs e)
        {
            // Очистить поля
        }

        private void inform_graphics_Click(object sender, EventArgs e)
        {
            // Информация о графиках
        }
    }
}
