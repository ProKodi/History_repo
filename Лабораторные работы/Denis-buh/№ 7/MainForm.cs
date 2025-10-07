



/// <summary>Делигат который будет ссылатся на метод</summary>
delegate void Paint_fun(ref Graphics g);

partial class MainForm : Form{
    /// <summary>Обьект отвечающий за разметку полей в окне</summary>
    Fields new_fild; 

    /// <summary> Действие при перерисовании формы</summary>
    protected Paint_fun? funct = null; 

    /// <summary>Форма ввода. В ней же хранятся и данные</summary>
    protected InputForm form_input = new InputForm(); 

    public MainForm(){
        InitializeComponent();
        new_fild = new Fields(900, 900); 
    }


    /// <summary>Отчистка графиков</summary>
    /// <param name="g"></param>
    protected void Clean_Form(ref Graphics g){
        g.Clear(Color.White);
        if(form_input.Used_drid){this.new_fild.DrawDrid(ref g);}
    }


    /// <summary>Построение графиков</summary>
    protected void Build_Chart(ref Graphics g){
        if(!form_input.Flag_input){return;}
        this.Clean_Form(ref g); 

        double step = 0.0001; 
        int charts_width = this.form_input.Charts_width; 

        {
            Point zero = new_fild[0].Zero;
            Color colr;
            First_Chart chart;
            {
                (int, Color) res = this.form_input.First_chart(); 
                chart = new First_Chart(res.Item1);
                colr = res.Item2; 
            }
            for(double x = -zero.X; x < zero.X; x += step){
                try{
                    (double, double) res = chart.function(x);
                    (double, double) res1 = chart.function(x + step);
    
                    FPoint st = new FPoint(x, res.Item1);
                    FPoint en = new FPoint(x + step, res1.Item1);
                    new_fild[0].DrawLine(ref g, st, en, charts_width, colr);
                    st = new FPoint(x, res.Item2);
                    en = new FPoint(x + step, res1.Item2);
                    new_fild[0].DrawLine(ref g, st, en, charts_width, colr);
                }
                catch(Exception){}
            }
        };

        {
            Point zero = new_fild[1].Zero;
            Color colr;
            Second_Chart chart;
            {
                (int, Color) res = this.form_input.Second_chart(); 
                chart = new Second_Chart(res.Item1);
                colr = res.Item2; 
            }
    
            for(double x = -zero.X; x < zero.X; x += step){
                try{
                    FPoint st = new FPoint(x, chart.function(x));
                    FPoint en = new FPoint(x + step, chart.function(x + step));
                    new_fild[1].DrawLine(ref g, st, en, charts_width, colr);
                }
                catch(Exception){}
            }
        };
        
        {
            Point zero = new_fild[2].Zero;
            Color colr;
            Third_Chart chart;
            {
                (int, int, Color) res = this.form_input.Third_chart(); 
                chart = new Third_Chart(res.Item1, res.Item2);
                colr = res.Item3; 
            }

            for(double x = -zero.X; x < zero.X; x += step){
                try{
                    FPoint st = new FPoint(x, chart.function(x));
                    FPoint en = new FPoint(x + step, chart.function(x + step));
                    new_fild[2].DrawLine(ref g, st, en, charts_width, colr);
                }
                catch(Exception){}
            }
        };

        {
            Point zero = new_fild[3].Zero;
            Color colr;
            Fourth_Chart chart;
            {
                (int, Color) res = this.form_input.Fourth_Chart(); 
                chart = new Fourth_Chart(res.Item1);
                colr = res.Item2; 
            }
            for(double x = -zero.X; x < zero.X; x += step){
                try{
                    (double, double) res = chart.function(x);
                    (double, double) res1 = chart.function(x + step);
                    FPoint st = new FPoint(x, res.Item1);
                    FPoint en = new FPoint(x + step, res1.Item1);
                    new_fild[3].DrawLine(ref g, st, en, charts_width, colr);

                    st = new FPoint(x, res.Item2);
                    en = new FPoint(x + step, res1.Item2);
                    new_fild[3].DrawLine(ref g, st, en, charts_width, colr);
                }
                catch(Exception){}
            }
        };

    }



    // Рисование на форме
    private void MainForm_Paint(object sender, PaintEventArgs e){
        Graphics g = e.Graphics;
        if(this.funct == null){return;}
        this.funct(ref g);
        this.funct = null; 
    }


    // Завершение работы
    private void Exit_Click(object sender, EventArgs e){Application.Exit();}

    // Очистить поля
    private void clean_Click(object sender, EventArgs e){
        this.funct = this.Clean_Form; this.Refresh();
    }

    // Перестроить графики
    private void build_graphics_Click(object sender, EventArgs e){
        this.funct = this.Build_Chart; this.Refresh();
    }

    // Параметры графиков
    private void settings_graphics_Click(object sender, EventArgs e){
        this.form_input.ShowDialog(); 

    }

    // Информация о графиках
    private void inform_graphics_Click(object sender, EventArgs e){
        ShowInform show_form = new ShowInform();
        {
            (int, Color) res = this.form_input.First_chart(); 
            show_form.set_inform_chart_1($"y = x^3 * (x - {res.Item1})", res.Item2.Name); 
        }
        {
            (int, Color) res = this.form_input.Second_chart(); 
            show_form.set_inform_chart_2(
                $"({res.Item1} / 2) * (e ^ (x / {res.Item1}) + e ^ (-x / {res.Item1}))", res.Item2.Name
            );
        }
        {
            (int, int, Color) res = this.form_input.Third_chart();  
            show_form.set_inform_chart_3($"{res.Item1} * x + {res.Item2}", res.Item3.Name);
        }
        {
            (int, Color) res = this.form_input.Fourth_Chart();   
            show_form.set_inform_chart_4($"y^2 + x^2 = {res.Item1}^2", res.Item2.Name);
        }
        show_form.ShowDialog(); 
    }
}

