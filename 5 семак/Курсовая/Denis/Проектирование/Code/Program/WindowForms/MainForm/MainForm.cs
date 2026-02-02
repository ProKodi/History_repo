



partial class MainForm : Form{
    public MainForm(){ InitializeComponent(); }

    private void GetClients_Click(object sender, EventArgs e){
        var form = new FormClients(); // Создаем экземпляр второй формы
        form.Text = "Таблица с клиентами";
        form.ShowDialog(this); 
    }

    private void GetMenuItem_Click(object sender, EventArgs e){
        var form = new FormMenuItem(); // Создаем экземпляр второй формы
        form.Text = "Таблица с позициями меню";
        form.ShowDialog(this); 
    }

    private void GetOrders_Click(object sender, EventArgs e){
        var form = new FormOrders(); // Создаем экземпляр второй формы
        form.Text = "Таблица с заказами";
        form.ShowDialog(this); 
    }

    private void GetPositions_Click(object sender, EventArgs e){
        var form = new FormPositions(); // Создаем экземпляр второй формы
        form.Text = "Таблица с должностями";
        form.ShowDialog(this); 
    }

    private void GetRangeDishes_Click(object sender, EventArgs e){
        var form = new FormRangeDishes(); // Создаем экземпляр второй формы
        form.Text = "Таблица с блюдами";
        form.ShowDialog(this); 
    }

    private void GetRestaurants_Click(object sender, EventArgs e){
        var form = new FormRestaurants(); // Создаем экземпляр второй формы
        form.Text = "Таблица с ресторанами";
        form.ShowDialog(this); 
    }

    private void GetSchedule_Click(object sender, EventArgs e){
        var form = new FormSchedule(); // Создаем экземпляр второй формы
        form.Text = "Таблица с графиками работы";
        form.ShowDialog(this); 
    }

    private void GetWorkers_Click(object sender, EventArgs e){
        var form = new FormWorkers(); // Создаем экземпляр второй формы
        form.Text = "Таблица с работниками";
        form.ShowDialog(this); 
    }

    private void GetOrderDish_Click(object sender, EventArgs e){
        var form = new FormOrderDish(); // Создаем экземпляр второй формы
        form.Text = "Таблица с заказаными блюдами";
        form.ShowDialog(this); 
    }



    private void Request1_Click(object sender, EventArgs e){
        var form = new FormRequest1(); // Создаем экземпляр второй формы
        form.Text = "1 запрос";
        form.ShowDialog(this); 
    }


    private void Request2_Click(object sender, EventArgs e){
        var form = new FormRequest2(); // Создаем экземпляр второй формы
        form.Text = "2 запрос";
        form.ShowDialog(this); 
    }

    private void Request3_Click(object sender, EventArgs e){
        var form = new FormRequest3(); // Создаем экземпляр второй формы
        form.Text = "3 запрос";
        form.ShowDialog(this); 
    }

    private void Request4_Click(object sender, EventArgs e){
        var form = new FormRequest4(); // Создаем экземпляр второй формы
        form.Text = "4 запрос";
        form.ShowDialog(this); 
    }

    private void Request5_Click(object sender, EventArgs e){
        var form = new FormRequest5(); // Создаем экземпляр второй формы
        form.Text = "5 запрос";
        form.ShowDialog(this); 
    }

    private void Request6_Click(object sender, EventArgs e){
        var form = new FormRequest6(); // Создаем экземпляр второй формы
        form.Text = "6 запрос";
        form.ShowDialog(this); 
    }

    private void Request7_Click(object sender, EventArgs e){
        var form = new FormRequest7(); // Создаем экземпляр второй формы
        form.Text = "7 запрос";
        form.ShowDialog(this); 
    }

    private void Request8_Click(object sender, EventArgs e){
        var form = new FormRequest8(); // Создаем экземпляр второй формы
        form.Text = "8 запрос";
        form.ShowDialog(this); 
    }

    private void Request9_Click(object sender, EventArgs e){
        var form = new FormRequest81(); // Создаем экземпляр второй формы
        form.Text = "8.1 запрос";
        form.ShowDialog(this); 
    }

    private void Request10_Click(object sender, EventArgs e){
        var form = new FormRequest9(); // Создаем экземпляр второй формы
        form.Text = "9 запрос";
        form.ShowDialog(this); 
    }

    private void Request11_Click(object sender, EventArgs e){
        var form = new FormRequest10(); // Создаем экземпляр второй формы
        form.Text = "10 запрос";
        form.ShowDialog(this); 
    }

    private void Request12_Click(object sender, EventArgs e){
        var form = new FormRequest11(); // Создаем экземпляр второй формы
        form.Text = "11 запрос";
        form.ShowDialog(this); 
    }

    private void Request13_Click(object sender, EventArgs e){
        var form = new FormRequest12(); // Создаем экземпляр второй формы
        form.Text = "12 запрос";
        form.ShowDialog(this); 
    }

    private void Request14_Click(object sender, EventArgs e){
        var form = new FormRequest14(); // Создаем экземпляр второй формы
        form.Text = "14 запрос";
        form.ShowDialog(this); 
    }

    private void Request15_Click(object sender, EventArgs e){
        var form = new FormRequest15(); // Создаем экземпляр второй формы
        form.Text = "15 запрос";
        form.ShowDialog(this); 
    }

    private void Request16_Click(object sender, EventArgs e){
        var form = new FormRequest16(); // Создаем экземпляр второй формы
        form.Text = "16 запрос";
        form.ShowDialog(this); 
    }

    private void Request17_Click(object sender, EventArgs e){
        var form = new FormRequest17(); // Создаем экземпляр второй формы
        form.Text = "17 запрос";
        form.ShowDialog(this); 
    }

    private void Request18_Click(object sender, EventArgs e){
        var form = new FormRequest18(); // Создаем экземпляр второй формы
        form.Text = "18 запрос";
        form.ShowDialog(this); 
    }
}
