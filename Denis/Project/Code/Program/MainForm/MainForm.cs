



using Autofac;


partial class MainForm : Form{
    public MainForm(){ InitializeComponent(); }

    private void GetClients_Click(object sender, EventArgs e){
        var form = new AbstractDBForms("clients"); // Создаем экземпляр второй формы
        form.Text = "Таблица с клиентами";
        form.ShowDialog(this); 
    }

    private void GetMenuItem_Click(object sender, EventArgs e){
        var form = new AbstractDBForms("workers"); // Создаем экземпляр второй формы
        form.Text = "Таблица с работниками банка";
        form.ShowDialog(this); 
    }

    private void GetOrders_Click(object sender, EventArgs e){
        var form = new AbstractDBForms("languages"); // Создаем экземпляр второй формы
        form.Text = "Таблица с языками";
        form.ShowDialog(this); 
    }

    private void GetPositions_Click(object sender, EventArgs e){
        var form = new AbstractDBForms("lenguage_levele"); // Создаем экземпляр второй формы
        form.Text = "Таблица с уровнями освоения языков";
        form.ShowDialog(this); 
    }

    private void GetRangeDishes_Click(object sender, EventArgs e){
        var form = new AbstractDBForms("client_language"); // Создаем экземпляр второй формы
        form.Text = "Таблица с языками которые знают клиенты";
        form.ShowDialog(this); 
    }

    private void GetRestaurants_Click(object sender, EventArgs e){
        var form = new AbstractDBForms("worker_language"); // Создаем экземпляр второй формы
        form.Text = "Таблица с языками которые знают работники";
        form.ShowDialog(this); 
    }


    private void Request1_Click(object sender, EventArgs e){
        var form = new AbstractTableForm(
            Program.DiConteiner.Resolve<MyDataBase.IDataBase>().GetRequest1() 
        ); // Создаем экземпляр второй формы

        form.DataGridSetColumn(
            "Имя клиента", "Фамилия клиента", "Отчество клиента", 
            "Телефон клиента", "Улица на которой проживает клиент", "Дом клиента"
        );
        form.Text = "1 запрос";
        form.ShowDialog(this); 
    }


    private void Request2_Click(object sender, EventArgs e){
        var form = new AbstractTableForm(
            Program.DiConteiner.Resolve<MyDataBase.IDataBase>().GetRequest2() 
        ); // Создаем экземпляр второй формы

        form.DataGridSetColumn(
            "Имя сотрудника", "Фамилия сотрудника", "Отчество сотрудника", 
            "Телефон сотрудника"
        );
        form.Text = "2 запрос";
        form.ShowDialog(this); 
    }

    private void Request3_Click(object sender, EventArgs e){
        var form = new AbstractTableForm(
            Program.DiConteiner.Resolve<MyDataBase.IDataBase>().GetRequest3() 
        ); // Создаем экземпляр второй формы

        form.DataGridSetColumn(
            "Клиент", "Название языка", "Уровень на котором они его знают"
        );
        form.Text = "3 запрос";
        form.ShowDialog(this); 
    }

    private void Request4_Click(object sender, EventArgs e){
        var form = new AbstractTableForm(
            Program.DiConteiner.Resolve<MyDataBase.IDataBase>().GetRequest4() 
        ); // Создаем экземпляр второй формы

        form.DataGridSetColumn( "Название языка", "Количество клиентов знающих определеной язык" );
        form.Text = "4 запрос";
        form.ShowDialog(this); 
    }

    private void Request5_Click(object sender, EventArgs e){
        var form = new AbstractTableForm(
            Program.DiConteiner.Resolve<MyDataBase.IDataBase>().GetRequest5() 
        ); // Создаем экземпляр второй формы

        form.DataGridSetColumn( "Название языка", "Количество работников знающих определеной язык" );
        form.Text = "5 запрос";
        form.ShowDialog(this); 
    }
}
