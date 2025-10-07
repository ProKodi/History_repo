



public partial class GetNumber : Form{
    public GetNumber(){
        InitializeComponent();
        this.DialogResult = DialogResult.Cancel; 
    }

    // Метод позволяющий скрыть поле способ ввода
    public void remove_box_input_mode(){
        this.box_input_mode.Visible = false;
    }

    // Метод возращающий данные с формы
    // Первым числом передает модуль, 2 - аргумент
    public (double, double) get_modl_arg(){
        if (this.mode_random_true.Checked){
            Random temp = new Random(); 
            return ((double)temp.Next(-322768, 322767), 
                (double)temp.Next(-322768, 322767)
            );
        }
        return (Convert.ToDouble(modl.Value), Convert.ToDouble(arg.Value));
    }

    /// ДЕЙСТВИЯ КНОПОК НАХОДЯЩИЕСЯ В СПОСОБЕ ВВОДА

    private void mode_random_true_CheckedChanged(object sender, EventArgs e){
        this.set_box.Enabled = false;
    }
    private void mode_ramdom_false_CheckedChanged(object sender, EventArgs e){
        this.set_box.Enabled = true;
    }
    
    /// КНОПКИ ЗАДАНИЯ ЧИСЛА И ЗАКРЫТИЯ ФОРМЫ
    private void set_number_Click(object sender, EventArgs e){
        this.DialogResult = DialogResult.OK;
        this.Close();
    }
    private void delete_number_Click(object sender, EventArgs e){
        this.Close();
    }
}

