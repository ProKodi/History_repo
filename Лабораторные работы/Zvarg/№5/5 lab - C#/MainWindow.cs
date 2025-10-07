using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5_lab___C_
{
    public partial class MainWindow : Form
    {
        Point moveStart;
        public MainWindow()
        {
            InitializeComponent();
            this.Load += MainWindow_Load;
            this.MouseDown += MainWindow_MouseDown;
            this.MouseMove += MainWindow_MouseMove;
        }
        private void MainWindow_Load(object sender, EventArgs e)
        {
            //рисуем саму форму: задаём границы и затем вырисовываем форму и её границы
            Point[] FormArray = new Point[6];
            Point center = new Point(200, 200);
            int radius = 200;
            for (int i = 0; i < 6; i++)
            {
                double angle = Math.PI / 3 * i;
                FormArray[i] = new Point(
                center.X + (int)(radius * Math.Cos(angle)),
                center.Y + (int)(radius * Math.Sin(angle))
            );
            }
            GraphicsPath FormPath = new GraphicsPath();
            FormPath.AddPolygon(FormArray);
            this.Region = new Region(FormPath);
            this.BackColor = Color.Gray;
            //создаём кнопку выхода и добавляем её на форму
            Button ExitButton = new Button
            {
                Location = new Point(102,330),
            };
            ExitButton.Click += ExitButton_Click;
            ExitButton.Text = "Выход";
            ExitButton.BackColor = Color.Aquamarine;
            ExitButton.Width = 200;
            ExitButton.Height = 40;
            this.Controls.Add(ExitButton);
            //создаём кнопку вывода информации в модальном окне и добавляем её на форму
            Button outputButton = new Button()
            {
                Location = new Point(-50,130),
                Text = "Вывод",
                BackColor = Color.Orange,
                Width = 500,
                Height = 150
            };
            outputButton.FlatAppearance.BorderColor = Color.Orange;
            outputButton.Click += OutputButton_Click;
            this.Controls.Add(outputButton);
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OutputButton_Click(object sender, EventArgs e)
        {
            ModalOutputWindow modalOutputWindow = new ModalOutputWindow();
            InitializeComponent();
            modalOutputWindow.ShowDialog();
        }
        private void MainWindow_MouseDown(object sender, MouseEventArgs e)
        {
            // если нажата левая кнопка мыши
            if (e.Button == MouseButtons.Left)
            {
                moveStart = new Point(e.X, e.Y);
            }
        }

        private void MainWindow_MouseMove(object sender, MouseEventArgs e)
        {
            // если нажата левая кнопка мыши
            if ((e.Button & MouseButtons.Left) != 0)
            {
                // получаем новую точку положения формы
                Point deltaPos = new Point(e.X - moveStart.X, e.Y - moveStart.Y);
                // устанавливаем положение формы
                this.Location = new Point(this.Location.X + deltaPos.X,
                  this.Location.Y + deltaPos.Y);
            }
        }
    }
}