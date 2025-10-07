using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void NewSize(object sender, System.EventArgs e) // Метод вызывается при конце редактирования размера формы
        {
            Console.WriteLine(DisplayRectangle); 
            Console.WriteLine(DisplayRectangle.Width); // Ширина
            Console.WriteLine(DisplayRectangle.Height); // Высота
            Console.WriteLine(ClientRectangle); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // Console.WriteLine(2); 

            Graphics g = e.Graphics; //использование графическ. объекта
            Pen pen = new Pen(Color.Black, 1);
            g.DrawLine(pen, 0, 0, 10, 9);
            g.DrawLine(pen, 0, 0, 8, 900);
        }
    }
}