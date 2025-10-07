using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5_lab___C_
{
    public partial class ModalOutputWindow : Form
    {
        Fish[] allfish = new Fish[]
        {
            new Fish ("Esox lucius", "Евразия, Сев. Америка", "щуки", true),
            new Fish ("Mugil", "Чёрное, Азовское, Японское моря", "кефали (серые)", false),
            new Fish ("Cyprinus carpio", "Евразия, Сев. Америка", "карпы", true),
            new Fish ("Silurus glanis", "Европа", "сомы", true),
            new Fish ("Takifugu rubripes", "западные акватории Японского моря", "такифугу", false),
            new Fish ("Amphiprion percula", "западная часть Тихого океана", "рыбы-клоуны", false)
        };
        Point moveStart;
        public ModalOutputWindow()
        {
            InitializeComponent();
            System.Drawing.Drawing2D.GraphicsPath myPath = new System.Drawing.Drawing2D.GraphicsPath();
            myPath.AddEllipse(0, 0, this.Width, this.Height);
            Region myRegion = new Region(myPath);
            this.Region = myRegion;
            for (int i = 0; i < allfish.Length; i++)
            {
                OutputBox.Items.Add(allfish[i].ShowInfo());
            }
            this.MouseDown += ModalOutputWindow_MouseDown;
            this.MouseMove += ModalOutputWindow_MouseMove;
        }
        private void ModalOutputWindow_MouseDown(object sender, MouseEventArgs e)
        {
            // если нажата левая кнопка мыши
            if (e.Button == MouseButtons.Left)
            {
                moveStart = new Point(e.X, e.Y);
            }
        }

        private void ModalOutputWindow_MouseMove(object sender, MouseEventArgs e)
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

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Modify_Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Список отсортирован. Сначала записана пресноводная рыба.", "Сортировка выполнена.");
            OutputBox.Items.Clear();
            for (int i = 0; i < allfish.Length; i++)
            {
                if (allfish[i].is_it_freshwater)
                {
                    OutputBox.Items.Add(allfish[i].ShowInfo());
                }
            }
            for (int i = 0; i < allfish.Length; i++)
            {
                if (!(allfish[i].is_it_freshwater))
                {
                    OutputBox.Items.Add(allfish[i].ShowInfo());
                }
            }
        }
    }
}
