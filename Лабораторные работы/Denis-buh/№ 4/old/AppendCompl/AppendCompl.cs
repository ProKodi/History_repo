



// Часть класса для работы только с интерфейсом
partial class AppendCompl: Form{
    public AppendCompl(){
        InitializeComponent();
        // Устанавливаем на comboBox значение по умолчанию
        this.fun.SelectedIndex = 0;
        // Запрещаем редактировать ComboBox
        this.fun.DropDownStyle = ComboBoxStyle.DropDownList; 
    }

    private void mode_random_true_CheckedChanged(object sender, EventArgs e){
        this.box_input.Enabled = false;
    }

    private void mode_random_false_CheckedChanged(object sender, EventArgs e){
        this.box_input.Enabled = true;
    }

    private void close_Click(object sender, EventArgs e){this.Close();}


    /// Получение чисел
    // Получение рандомного числа
    public double get_random() { return (double)(new Random()).Next(-322768, 322767); }
    // Модуль
    public double get_tem_modl(){
        if (this.mode_random_true.Checked) { return this.get_random(); }
        return Convert.ToDouble(modl.Value);
    }
    // Аргумент
    public double get_tem_arg(){
        if (this.mode_random_true.Checked) { return this.get_random(); }
        return Convert.ToDouble(arg.Value);
    }
    // Получения результата combobox
    public int get_fun(){return this.fun.SelectedIndex;}    
}


partial class AppendCompl : Form{
    protected ComplexApp compl;
    // Возращаем комплексное число
    public ComplexApp Get_compl {get{return this.compl;}}

    private ComplexApp get_inform(){
        double tem_modl =  this.get_tem_modl();
        double tem_arg = this.get_tem_arg();
        return new ComplexApp(tem_modl, tem_arg);
    }

    private void set_inform(){
        // Устанавливаем действительную часть
        x_number.Text = Convert.ToString(this.compl.X);
        // Устанавливаем комплексную часть
        y_number.Text = Convert.ToString(this.compl.Y);
        // Устанавливаем общий вид
        number.Text = this.compl.ToString();
    }

    // Расчитываем число
    private void call_Click(object sender, EventArgs e){
        // Считываем модуль и аргумент и передаем это в конструктор класс для комплексных чисел
        this.compl = this.get_inform();
        this.set_inform(); 
    }


}

