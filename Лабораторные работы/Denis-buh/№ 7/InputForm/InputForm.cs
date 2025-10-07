



public partial class InputForm : Form{
    /// <summary>Флаг отвечающий за ввод данных</summary>
    protected bool flag_input = false;

    /// <summary>Таблица доступных цветов</summary>
    protected Dictionary<string, Color> colors = new Dictionary<string, Color>{
        {"Черный", Color.Black}, {"Красный", Color.Red}, {"Зеленый", Color.Green}, {"Желтый", Color.Yellow},
        {"Синий", Color.Blue}, {"Темно-синий", Color.DarkBlue},  {"Розовый", Color.Pink},  {"Оранжевый", Color.Orange},
    };
    public bool Flag_input{get{return this.flag_input;}} 

    /// <summary>Толщина графика</summary>
    public int Charts_width{get{return (int)this.charts_width.Value;}}

    /// <summary>Указывать координатную сетку</summary>
    public bool Used_drid{get{return this.used_drid.Checked;}}

    public InputForm(){
        InitializeComponent();
        Dictionary<string, Color>.Enumerator iter = this.colors.GetEnumerator(); 
        iter.MoveNext(); 
        this.first_color.Text = iter.Current.Key; 
        this.second_color.Text = iter.Current.Key; 
        this.third_color.Text = iter.Current.Key; 
        this.fouth_color.Text = iter.Current.Key; 
        foreach(KeyValuePair<string, Color> item in this.colors){
            this.first_color.Items.Add(item.Key);
            this.second_color.Items.Add(item.Key);
            this.third_color.Items.Add(item.Key);
            this.fouth_color.Items.Add(item.Key);
        }
    }

    /// <summary>Гетер первого графика</summary>
    public (int, Color) First_chart(){ return ((int)this.g.Value, this.colors[first_color.Text]);}

    /// <summary>Гетер второго графика</summary>
    public (int, Color) Second_chart(){ return ((int)this.a.Value, this.colors[second_color.Text]);}

    /// <summary>Гетер третего графика</summary>
    public (int, int, Color) Third_chart(){ 
        return ((int)this.k.Value, (int)this.b.Value, this.colors[third_color.Text]); 
    }

    /// <summary>Гетер четвертого графика</summary>
    public (int, Color) Fourth_Chart(){ return ((int)this.r.Value, this.colors[fouth_color.Text]);}



    private void save_Click(object sender, EventArgs e){ this.flag_input = true;}

    /// <summary>Задание значения по умолчанию виджету</summary>
    protected void set_random(ref NumericUpDown widget){
        Random rend = new Random(); 
        int number =  rend.Next(); 
        widget.Value = (number % (widget.Maximum - widget.Minimum + 1)) + widget.Minimum; 

    }

    private void set_g_Click(object sender, EventArgs e){this.set_random(ref this.g);}
    private void set_a_Click(object sender, EventArgs e){this.set_random(ref this.a);}
    private void set_k_Click(object sender, EventArgs e){this.set_random(ref this.k);}
    private void set_b_Click(object sender, EventArgs e){this.set_random(ref this.b);}
    private void set_r_Click(object sender, EventArgs e){this.set_random(ref this.r);}
}

