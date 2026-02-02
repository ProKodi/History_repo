



public class LoginForm : Form{
    private readonly TextBox txtLogin;
    private readonly TextBox txtPassword;
    private Button btnSubmit;

    public string? login = null;
    public string? password = null;


    public LoginForm(){
        // Настройка формы
        this.Text = "Авторизация";
        this.Width = 300;
        this.Height = 200;
        this.StartPosition = FormStartPosition.CenterScreen;
        this.TopMost = true; // делает окно верхнего уровня

        // Поле логина
        txtLogin = new TextBox(){
            PlaceholderText = "Логин",
            Left = 20,
            Top = 20,
            Width = 240
        };

        // Поле пароля
        txtPassword = new TextBox(){
            PlaceholderText = "Пароль",
            Left = 20,
            Top = 60,
            Width = 240,
            UseSystemPasswordChar = true
        };

        // Кнопка входа
        btnSubmit = new Button(){
            Text = "Войти",
            Left = 20,
            Top = 100,
            Width = 240
        };

        btnSubmit.Click += BtnSubmit_Click;

        // Добавляем элементы на форму
        this.Controls.Add(txtLogin);
        this.Controls.Add(txtPassword);
        this.Controls.Add(btnSubmit);
    }

    private void BtnSubmit_Click(object sender, EventArgs e){
        login = txtLogin.Text;
        password = txtPassword.Text;
        this.Close();
    }
}
