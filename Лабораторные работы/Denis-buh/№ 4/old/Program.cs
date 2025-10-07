



partial class MainWindow : Form{
    public MainWindow(){
        InitializeComponent();
    }

    private Complex get_inform(){
        double tem_modl = Convert.ToDouble(modl.Value);
        double tem_arg = Convert.ToDouble(arg.Value);
        return new Complex(tem_modl, tem_arg);
    }

    private void set_inform(Complex obj){
        // Устанавливаем действительную часть
        x_number.Text = Convert.ToString(obj.X);
        // Устанавливаем комплексную часть
        y_number.Text = Convert.ToString(obj.Y);
        // Устанавливаем общий вид
        number.Text = obj.ToString();
    }

    private void calculate_Click(object sender, EventArgs e){
        Complex obj = this.get_inform();
        this.set_inform(obj); 
    }

    private void calculate_new_Click(object sender, EventArgs e){
        Complex obj = this.get_inform();
        this.set_inform(obj);
        ComplexApp compl;
        int fun_number; 
        {
            AppendCompl form = new AppendCompl();
            form.ShowDialog(this);
            compl = form.Get_compl;
            if (compl is null){
                MessageBox.Show(
                "Данные не были расчитаны поэтому дополнительное действие не выполнется",
                "Дополнительное действие не выполнется",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return; 
            }
            fun_number = form.get_fun();
        }
        if (fun_number == 0){
            MessageBox.Show(
                $"Число {compl}, после применения декремента: {--compl}",
                "Применение декримента",
                MessageBoxButtons.OK, MessageBoxIcon.Information
            );
        }

        if (fun_number == 1){
            MessageBox.Show(
                $"Число {compl}, после применения инкремента: {++compl}",
                "Применение инкримента",
                MessageBoxButtons.OK, MessageBoxIcon.Information
            );
        }
        if (fun_number == 2){
            if (obj.X == 0 && obj.Y == 0){
                MessageBox.Show(
                    $"Число в оригинальной форме = 0",
                    "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error
                );  
                return; 
            }
            MessageBox.Show(
                $"Число {compl} / {obj}, = {compl / obj}",
                "Деление чисел",
                MessageBoxButtons.OK, MessageBoxIcon.Information
            );
        }

        if (fun_number == 3){
            MessageBox.Show(
                $"Число {compl} * {obj}, = {compl * obj}",
                "Умножение чисел",
                MessageBoxButtons.OK, MessageBoxIcon.Information
            );
        }
        if (fun_number == 4){
            MessageBox.Show(
                $"Число {compl} != {obj}, = {compl != obj}",
                "Неравенство чисел",
                MessageBoxButtons.OK, MessageBoxIcon.Information
            );
        }

        if (fun_number == 5){
            MessageBox.Show(
                $"Число {compl} == {obj}, = {compl == obj}",
                "Равенство чисел",
                MessageBoxButtons.OK, MessageBoxIcon.Information
            );
        }
    }
}






static class Program
{
    /// <summary>
    /// Главная точка входа для приложения.
    /// </summary>
    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new MainWindow());
    }
}

