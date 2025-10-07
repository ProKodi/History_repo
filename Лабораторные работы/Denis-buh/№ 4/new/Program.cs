



public partial class MainWindow : Form{
    public MainWindow(){
        InitializeComponent();
        // Устанавливаем на comboBox значение по умолчанию
        this.operation.SelectedIndex = 0;
        this.set_number1(); 
        this.set_number2();
    }

    /// Комплексные числа
    // Число 1
    Complex number1 = new Complex(0, 0); 
    // Число 2
    ComplexApp number2 = new ComplexApp(0, 0); 


    /// ФУНКЦИИ ДЛЯ КНОПОК (НАЖАТИЕ КНОПОК)

    /// ЗАДАНИЕ ЧИСЕЛ
    // Устанавливаем число number_1 на интерфейс
    private void set_number1(){
        // Устанавливаем действительную часть
        this.x_number_1.Text = Convert.ToString(this.number1.X);
        // Устанавливаем комплексную часть
        this.y_number_1.Text = Convert.ToString(this.number1.Y);
        // Устанавливаем общий вид
        this.number_1.Text = this.number1.ToString();
    }

    private void set_number_1_Click(object sender, EventArgs e){
        GetNumber get_form = new GetNumber();
        get_form.remove_box_input_mode(); 
        get_form.ShowDialog(this);

        if (get_form.DialogResult != DialogResult.OK){
            MessageBox.Show(
                "Вы не ввели данные",
                "Комплексное число 1 не изменено",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            return; 
        }
        (double, double) temp = get_form.get_modl_arg();
        this.number1 = new Complex(temp.Item1, temp.Item2); 
        this.set_number1(); 
    }


    // Устанавливаем число number_2 на интерфейс
    private void set_number2(){
        // Устанавливаем действительную часть
        this.x_number_2.Text = Convert.ToString(this.number2.X);
        // Устанавливаем комплексную часть
        this.y_number_2.Text = Convert.ToString(this.number2.Y);
        // Устанавливаем общий вид
        this.number_2.Text = this.number2.ToString();
    }

    private void set_number_2_Click(object sender, EventArgs e){
        GetNumber get_form = new GetNumber();
        get_form.ShowDialog(this);

        if (get_form.DialogResult != DialogResult.OK){
            MessageBox.Show(
                "Вы не ввели данные",
                "Комплексное число 2 не изменено",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            return; 
        }
        (double, double) temp = get_form.get_modl_arg();
        this.number2 = new ComplexApp(temp.Item1, temp.Item2); 
        this.set_number2(); 
    }

    /// УНАРНЫЕ ОПЕРАЦИИ НАД 2 ЧИСЛОМ
    // Инкримент
    private void made_increment_Click(object sender, EventArgs e){
        ++this.number2; 
        this.set_number2(); 
    }
    // Дикримент
    private void set_dicriment_Click(object sender, EventArgs e){
        --this.number2; 
        this.set_number2(); 
    }

    /// ОПЕРАЦИИ НАД 2 ЧИСЛАМИ

    private void call_operation_Click(object sender, EventArgs e){
        void Set(ComplexApp temp){
            this.x_number_res.Text = Convert.ToString(temp.X);
            this.y_number_res.Text = Convert.ToString(temp.Y);
            this.number_res.Text = temp.ToString();
        }
        int res = this.operation.SelectedIndex; 

        if (res == 0){
            if (this.number1.X == 0 && this.number1.Y == 0){
                MessageBox.Show($"Комплексное число 1 = 0", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }
            Set(number2 / number1); 
        }
        if (res == 1){Set(number2 * number1);}

        if (res == 2){
            MessageBox.Show(
                $"Число {this.number2} != {this.number1} = {this.number2 != this.number1}",
                "Неравенство чисел", MessageBoxButtons.OK, MessageBoxIcon.Information
            );
        }
        if (res == 3){
            MessageBox.Show(
                $"Число {this.number2} == {this.number1} = {this.number2 == this.number1}",
                "Равенство чисел", MessageBoxButtons.OK, MessageBoxIcon.Information
            );
        }
    }

}






internal static class Program{
    /// <summary>
    /// Главная точка входа для приложения.
    /// </summary>
    [STAThread]
    static void Main(){
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new MainWindow());
    }
}
