using System.Linq.Expressions;

namespace _7_lab___C_
{
    public partial class MainWindow : Form
    {
        bool direction;
        bool size;
        int Ringcolor;
        int MtnDoomColor;
        int DoomFireColor;
        Dictionary<int, Color> ColorsDict = new Dictionary<int, Color>()//словарь цветов
        {
            {0, Color.Gold},
            {1, Color.Orange},
            {2, Color.OrangeRed},
            {3, Color.Black },
            {4, Color.SaddleBrown },
            {5, Color.Yellow},
            {6, Color.DimGray}
        };
        Dictionary<bool, Point[]> MtnPoints = new Dictionary<bool, Point[]>()//словарь под размеры горы
        {
            {true, new Point[] {new Point(850,250), new Point(700,500), new Point(1000,500)} },//точки определить (это поменьше)
            {false, new Point[] {new Point(850, 250), new Point(400, 800), new Point(1300, 800) } }//тут побольше
        };
        public MainWindow()
        {
            InitializeComponent();
            direction = false;
            size = true;
            Ringcolor = 0;
            MtnDoomColor = 3;
            DoomFireColor = 5;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            OptionsForm optionsForm = new OptionsForm();
            if (optionsForm.ShowDialog() == DialogResult.OK)
            {
                size = optionsForm.SizeReturn();//поменьше == true
                Ringcolor = optionsForm.RingColorReturn();//цвет кольца
                MtnDoomColor = optionsForm.MtnDoomReturn();//цвет горы
                DoomFireColor = optionsForm.DoomFireReturn();//цвет пламени/дыма
                direction = optionsForm.DirectionReturn();//влево-вправо == true
            }
        }

        private void ViewButton_Click(object sender, EventArgs e)//просто прорисовка по нажатию
        {
            MainForm_Paint(sender, size, Ringcolor, MtnDoomColor, DoomFireColor);
        }

        async private void AnimationButton_Click(object sender, EventArgs e)
        {
            if (direction)//анимация влево-вправо
            {
                DoubleBuffered = true;
                int AnimPosition = 0;
                bool localdirection = true;//true - вправо, false - влево
                for (int i = 0; i < 10000; i++)
                {
                    this.Refresh();
                    MainForm_HorizAnimation(sender, size, Ringcolor, MtnDoomColor, DoomFireColor, AnimPosition);
                    if (localdirection)
                    {
                        AnimPosition++;
                        if (AnimPosition == 400)
                        {
                            localdirection = false;
                        }
                    }
                    else
                    {
                        AnimPosition--;
                        if (AnimPosition == -400)
                        {
                            localdirection = true;
                        }
                    }
                    await Task.Delay(1);
                    if (StopAnimButton.Focused)
                    {
                        return;
                    }
                }
            }
            else//анимация вверх-вниз
            {
                //цикл, его номер итерации будем подавать в метод прорисовки - доделать
                DoubleBuffered = true;
                int AnimPosition = 0;
                bool localdirection = true;//true - вправо, false - влево
                for (int i = 0; i < 10000; i++)
                {
                    this.Refresh();
                    MainForm_VerticAnimation(sender, size, Ringcolor, MtnDoomColor, DoomFireColor, AnimPosition);
                    if (localdirection)
                    {
                        AnimPosition++;
                        if (AnimPosition == 300)
                        {
                            localdirection = false;
                        }
                    }
                    else
                    {
                        AnimPosition--;
                        if (AnimPosition == -200)
                        {
                            localdirection = true;
                        }
                    }
                    await Task.Delay(1);
                    if (StopAnimButton.Focused)
                    {
                        return;
                    }
                }
            }
        }

        private void StopAnimButton_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }
        private void MainForm_Paint(object sender, bool size, int RingColor, int MtnDoomColor, int DoomFireColor)//метод прорисовки
        {
            Graphics g = this.CreateGraphics();//(850,500) - центр
            SolidBrush brush = new SolidBrush(ColorsDict[MtnDoomColor]);//задаём кисть под Гору, затем рисуем её (и побольше, и поменьше)
            g.FillPolygon(brush, MtnPoints[size]);
            brush.Color = ColorsDict[DoomFireColor];
            if (size)//рисуем дым поменьше
            {
                g.FillPolygon(brush, new Point[] { new Point(850, 250), new Point(815, 300), new Point(885, 300) });
                g.FillEllipse(brush, new Rectangle(825, 200, 50, 50));
                g.FillEllipse(brush, new Rectangle(825, 150, 75, 75));
                g.FillEllipse(brush, new Rectangle(825, 100, 100, 100));
            }
            else//побольше
            {
                g.FillPolygon(brush, new Point[] { new Point(850, 250), new Point(815, 300), new Point(885, 300) });
                g.FillEllipse(brush, new Rectangle(825, 200, 50, 50));
                g.FillEllipse(brush, new Rectangle(825, 150, 75, 75));
                g.FillEllipse(brush, new Rectangle(825, 100, 100, 100));
            }
            brush.Color = ColorsDict[RingColor];
            if (size)//рисуем Кольцо поменьше
            {
                g.TranslateTransform(780, 350);
                g.RotateTransform(15);
                g.FillEllipse(brush, new Rectangle(new Point(0, 0), new Size(200, 100)));
                brush.Color = ColorsDict[MtnDoomColor];
                g.FillEllipse(brush, new Rectangle(new Point(15, 15), new Size(180, 70)));
                g.ResetTransform();
            }
            else//побольше
            {
                g.TranslateTransform(700, 450);
                g.RotateTransform(15);
                g.FillEllipse(brush, new Rectangle(new Point(0,0), new Size(400, 200)));
                brush.Color = ColorsDict[MtnDoomColor];
                g.FillEllipse(brush, new Rectangle(new Point(16, 10), new Size(360, 140)));
                g.ResetTransform();
            }
            brush.Dispose();
        }
        private void MainForm_HorizAnimation(object sender, bool size, int RingColor, int MtnDoomColor, int DoomFireColor, int AnimPosition)//метод горизонтальной анимации - доделать
        {
            Graphics g = this.CreateGraphics();//(850,500) - центр
            SolidBrush brush = new SolidBrush(ColorsDict[MtnDoomColor]);
            if (size)//гора поменьше
            {
                g.FillPolygon(brush, new Point[] { new Point(850 + AnimPosition, 250), new Point(700 + AnimPosition, 500), new Point(1000 + AnimPosition, 500) });
            }
            else//гора побольше
            {
                g.FillPolygon(brush, new Point[] { new Point(850 + AnimPosition, 250), new Point(400 + AnimPosition, 800), new Point(1300 + AnimPosition, 800) });
            }
            brush.Color = ColorsDict[DoomFireColor];
            if (size)//рисуем дым поменьше
            {
                g.FillPolygon(brush, new Point[] { new Point(850 + AnimPosition, 250), new Point(815 + AnimPosition, 300), new Point(885 + AnimPosition, 300) });
                g.FillEllipse(brush, new Rectangle(825 + AnimPosition, 200, 50, 50));
                g.FillEllipse(brush, new Rectangle(825 + AnimPosition, 150, 75, 75));
                g.FillEllipse(brush, new Rectangle(825 + AnimPosition, 100, 100, 100));
            }
            else//побольше
            {
                g.FillPolygon(brush, new Point[] { new Point(850 + AnimPosition, 250), new Point(815 + AnimPosition, 300), new Point(885 + AnimPosition, 300) });
                g.FillEllipse(brush, new Rectangle(825 + AnimPosition, 200, 50, 50));
                g.FillEllipse(brush, new Rectangle(825 + AnimPosition, 150, 75, 75));
                g.FillEllipse(brush, new Rectangle(825 + AnimPosition, 100, 100, 100));
            }
            brush.Color = ColorsDict[RingColor];
            if (size)//рисуем Кольцо поменьше
            {
                g.TranslateTransform(780 + AnimPosition, 350);
                g.RotateTransform(15);
                g.FillEllipse(brush, new Rectangle(new Point(0,0), new Size(200, 100)));
                brush.Color = ColorsDict[MtnDoomColor];
                g.FillEllipse(brush, new Rectangle(new Point(15, 15), new Size(180, 70)));
                g.ResetTransform();
            }
            else//побольше
            {
                g.TranslateTransform(700 + AnimPosition, 450);
                g.RotateTransform(15);
                g.FillEllipse(brush, new Rectangle(new Point(0, 0), new Size(400, 200)));
                brush.Color = ColorsDict[MtnDoomColor];
                g.FillEllipse(brush, new Rectangle(new Point(16, 10), new Size(360, 140)));
                g.ResetTransform();
            }
            brush.Dispose();
        }
        private void MainForm_VerticAnimation(object sender, bool size, int RingColor, int MtnDoomColor, int DoomFireColor, int AnimPosition)//метод вертикальной анимации - доделать
        {
            Graphics g = this.CreateGraphics();//(850,500) - центр
            SolidBrush brush = new SolidBrush(ColorsDict[MtnDoomColor]);
            if (size)//гора поменьше
            {
                g.FillPolygon(brush, new Point[] { new Point(850, 250 + AnimPosition), new Point(700, 500 + AnimPosition), new Point(1000, 500 + AnimPosition) });
            }
            else//гора побольше
            {
                g.FillPolygon(brush, new Point[] { new Point(850, 250 + AnimPosition), new Point(400, 800 + AnimPosition), new Point(1300, 800 + AnimPosition) });
            }
            brush.Color = ColorsDict[DoomFireColor];
            if (size)//рисуем дым поменьше
            {
                g.FillPolygon(brush, new Point[] { new Point(850, 250 + AnimPosition), new Point(815, 300 + AnimPosition), new Point(885, 300 + AnimPosition) });
                g.FillEllipse(brush, new Rectangle(825, 200 + AnimPosition, 50, 50));
                g.FillEllipse(brush, new Rectangle(825, 150 + AnimPosition, 75, 75));
                g.FillEllipse(brush, new Rectangle(825, 100 + AnimPosition, 100, 100));
            }
            else//побольше
            {
                g.FillPolygon(brush, new Point[] { new Point(850, 250 + AnimPosition), new Point(815, 300 + AnimPosition), new Point(885, 300 + AnimPosition) });
                g.FillEllipse(brush, new Rectangle(825, 200 + AnimPosition, 50, 50));
                g.FillEllipse(brush, new Rectangle(825, 150 + AnimPosition, 75, 75));
                g.FillEllipse(brush, new Rectangle(825, 100 + AnimPosition, 100, 100));
            }
            brush.Color = ColorsDict[RingColor];
            if (size)//рисуем Кольцо поменьше
            {
                g.TranslateTransform(780, 350 + AnimPosition);
                g.RotateTransform(15);
                g.FillEllipse(brush, new Rectangle(new Point(0, 0), new Size(200, 100)));
                brush.Color = ColorsDict[MtnDoomColor];
                g.FillEllipse(brush, new Rectangle(new Point(15, 15), new Size(180, 70)));
                g.ResetTransform();
            }
            else//побольше
            {
                g.TranslateTransform(700, 450 + AnimPosition);
                g.RotateTransform(15);
                g.FillEllipse(brush, new Rectangle(new Point(0, 0), new Size(400, 200)));
                brush.Color = ColorsDict[MtnDoomColor];
                g.FillEllipse(brush, new Rectangle(new Point(16, 10), new Size(360, 140)));
                g.ResetTransform();
            }
            brush.Dispose();
        }
    }
}


//это под буферизацию, если пригодится
//BufferedGraphics myBuffer;
//currentContext = BufferedGraphicsManager.Current;
//myBuffer = currentContext.Allocate(this.CreateGraphics(), this.DisplayRectangle);
//myBuffer.Render(g);
//BufferedGraphicsContext currentContext;