



class FormRequest1: AbstractTableForm{
    public override async void BtGetData_Click(object sender, EventArgs e){
        Task<List<RestarantsWithSchedule>> res = DataBase.SinglDataBase.GetRestarantsWithSchedule();

        this.DataGridSetColumn(
            "Название ресторана", "Адрес ресторана", "Время работы в понедельник", 
            "Время работы в вторник", "Время работы в среду", "Время работы в четверг", 
            "Время работы в пятницу", "Время работы в субботу", "Время работы в воскресенье"
        );

        foreach(var i in await res){
            this.DataGrid.Rows.Add(
                i.Name, i.Address, i.TimeMonday.GetString(), 
                i.TimeTuesday.GetString(), i.TimeWednesday.GetString(),  i.TimeThursday.GetString(),
                i.TimeFriday.GetString(), i.TimeSaturday.GetString(), i.TimeSunday.GetString() 
            );
        }
    }
}

class FormRequest2: AbstractTableForm{
    protected TableLayoutPanel InputLayout = new TableLayoutPanel();
    protected NumericUpDown id_restorant = new NumericUpDown();

    public FormRequest2(): base() {
        // label1
        Label label1 = new Label();
        label1.AutoSize = true;
        label1.Dock = DockStyle.Top;
        label1.Text = "Введите код ресторана";

        // InputLayout
        InputLayout.AutoSize = true;
        InputLayout.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        InputLayout.ColumnCount = 2;
        InputLayout.ColumnStyles.Add(new ColumnStyle());
        InputLayout.ColumnStyles.Add(new ColumnStyle());
        InputLayout.Controls.Add(label1, 0, 0);
        InputLayout.Controls.Add(id_restorant, 1, 0);
        InputLayout.Dock = DockStyle.Top;
        InputLayout.RowCount = 1;
        InputLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));

        // id_restorant
        id_restorant.AutoSize = true;
        id_restorant.Dock = DockStyle.Top;
        id_restorant.Maximum = ulong.MaxValue;
        id_restorant.Minimum = 1;

        InputLayout.ResumeLayout(false);
        InputLayout.PerformLayout();
        this.AppendNewWidget(InputLayout);
    }

    public override async void BtGetData_Click(object sender, EventArgs e){
        Task<List<DishInRestarant>> res = DataBase.SinglDataBase.GetDishesFromRestorant((ulong)id_restorant.Value);

        this.DataGridSetColumn(
            "Название блюда", "Описание блюда", "Пригодно для упоребления несовершенолетними", 
            "Cтоимость блюда", "Вес блюда", "Наличие товара"
        );

        foreach(var i in await res){
            this.DataGrid.Rows.Add(
                i.Name, i.Describe.GetString(), i.ForChildren.GetString(), 
                i.Cost, i.Weight.GetString(),  i.InStock.GetString()
            );
        }
    }
}

class FormRequest3: AbstractTableForm{
    protected TableLayoutPanel InputLayout = new TableLayoutPanel();
    protected TextBox email_client = new TextBox();

    public FormRequest3(): base() {
        // label1
        Label label1 = new Label();
        label1.AutoSize = true;
        label1.Dock = DockStyle.Top;
        label1.Size = new Size(208, 15);
        label1.Text = "Введите email клиента";

        // InputLayout
        InputLayout.AutoSize = true;
        InputLayout.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        InputLayout.ColumnCount = 2;
        InputLayout.ColumnStyles.Add(new ColumnStyle());
        InputLayout.ColumnStyles.Add(new ColumnStyle());
        InputLayout.Controls.Add(label1, 0, 0);
        InputLayout.Controls.Add(email_client, 1, 0);
        InputLayout.Dock = DockStyle.Top;
        InputLayout.RowCount = 1;
        InputLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        InputLayout.Size = new Size(428, 29);

        // email_client
        email_client.AutoSize = true;
        email_client.Dock = DockStyle.Top;
        email_client.Size = new Size(208, 23);

        InputLayout.ResumeLayout(false);
        InputLayout.PerformLayout();
        this.AppendNewWidget(InputLayout);
    }

    public override async void BtGetData_Click(object sender, EventArgs e){
        try{
            Task<List<ClientsOrders>> res = DataBase.SinglDataBase.GetClientsOrders( email_client.Text );

            this.DataGridSetColumn( "Название заказа", "Статус заказа", "Дата заказа" );

            foreach(var i in await res){
                this.DataGrid.Rows.Add( i.Name.GetString(), i.State.GetString(), i.Date );
            }
        } 
        catch(SQLInjection SQLInj){
            MessageBox.Show(SQLInj.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}

class FormRequest4: AbstractTableForm{
    public override async void BtGetData_Click(object sender, EventArgs e){
        Task<List<(string, long)>> res = DataBase.SinglDataBase.GetPopularDishes();

        this.DataGridSetColumn(
            "Название блюда", "Количество заказов блюда"
        );

        foreach(var i in await res){this.DataGrid.Rows.Add(i.Item1, i.Item2); }
    }
}

class FormRequest5: AbstractShowForm{
    protected TableLayoutPanel InputLayout = new TableLayoutPanel();
    protected TextBox name_restaran = new TextBox();

    protected TextBox SumLastWeek = new TextBox();

    public FormRequest5(): base() {
        // label1
        Label label1 = new Label();
        label1.AutoSize = true;
        label1.Dock = DockStyle.Top;
        label1.Text = "Введите название ресторана";

        // name_restaran
        name_restaran.AutoSize = true;
        name_restaran.Dock = DockStyle.Top;

        // label2
        Label label2 = new Label();
        label2.AutoSize = true;
        label2.Dock = DockStyle.Top;
        label2.Text = "Общая выручка по ресторану за последнюю неделю";

        // SumLastWeek
        SumLastWeek.AutoSize = true;
        SumLastWeek.Dock = DockStyle.Top;
        SumLastWeek.ReadOnly = true;

        // InputLayout
        InputLayout.AutoSize = true;
        InputLayout.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        InputLayout.ColumnCount = 2;
        InputLayout.ColumnStyles.Add(new ColumnStyle());
        InputLayout.ColumnStyles.Add(new ColumnStyle());
        InputLayout.Controls.Add(label1, 0, 0);
        InputLayout.Controls.Add(name_restaran, 1, 0);

        InputLayout.Controls.Add(label2, 0, 1);
        InputLayout.Controls.Add(SumLastWeek, 1, 1);

        InputLayout.Dock = DockStyle.Top;
        InputLayout.RowCount = 2;
        InputLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));

        InputLayout.ResumeLayout(false);
        InputLayout.PerformLayout();
        this.AppendNewWidget(InputLayout);
    }

    public override async void BtGetData_Click(object sender, EventArgs e){
        try{
            long? res = await DataBase.SinglDataBase.GetProfit(name_restaran.Text);

            if(res == null){ MessageBox.Show("Такого ресторана нет", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            SumLastWeek.Text = res.ToString(); 
        } 
        catch(SQLInjection SQLInj){
            MessageBox.Show(SQLInj.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}


class FormRequest6: AbstractTableForm{
    public override async void BtGetData_Click(object sender, EventArgs e){
        Task<List<WorkersInRestaurant>> res = DataBase.SinglDataBase.GetWorkersInRestaurant();

        this.DataGridSetColumn("ФИО работника", "Описание работника", "Зарплата работника", "Дата рождения работника");

        foreach(var i in await res){

            this.DataGrid.Rows.Add(
                i.Name, i.Describe.GetString(), i.Salary.GetString(), i.BirthdayDate.GetString()
            );
        }
    }
}


class FormRequest7: AbstractTableForm{
    public override async void BtGetData_Click(object sender, EventArgs e){
        Task<List<(string?, DateOnly)>> res = DataBase.SinglDataBase.GetDontReadyOrders(
            
        );

        this.DataGridSetColumn("Название заказа", "Дата заказа");

        foreach(var i in await res){

            this.DataGrid.Rows.Add(
                i.Item1.GetString(), i.Item2
            );
        }
    }
}


class FormRequest8: AbstractShowForm{
    protected TableLayoutPanel InputLayout = new TableLayoutPanel();
    
    protected TextBox NameDishe = new TextBox();
    protected TextBox NameRestarant = new TextBox();
    protected NumericUpDown Cost = new NumericUpDown();
    protected NumericUpDown Weight = new NumericUpDown();

    public FormRequest8(): base() {
        // label1
        Label label1 = new Label();
        label1.AutoSize = true;
        label1.Dock = DockStyle.Top;
        label1.Text = "Введите название блюда";

        NameDishe.AutoSize = true;
        NameDishe.Dock = DockStyle.Top;

        // label2
        Label label2 = new Label();
        label2.AutoSize = true;
        label2.Dock = DockStyle.Top;
        label2.Text = "Введите название ресторана";

        NameRestarant.AutoSize = true;
        NameRestarant.Dock = DockStyle.Top;

        // label3
        Label label3 = new Label();
        label3.AutoSize = true;
        label3.Dock = DockStyle.Top;
        label3.Text = "Введите стоимость блюда";

        Cost.AutoSize = true;
        Cost.Maximum = int.MaxValue;
        Cost.Dock = DockStyle.Top;

        // label4
        Label label4 = new Label();
        label4.AutoSize = true;
        label4.Dock = DockStyle.Top;
        label4.Text = "Введите вес блюда в грамах";

        Weight.AutoSize = true;
        Weight.Maximum = int.MaxValue;
        Weight.Dock = DockStyle.Top;

        // InputLayout
        InputLayout.AutoSize = true;
        InputLayout.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        InputLayout.ColumnCount = 2;
        InputLayout.ColumnStyles.Add(new ColumnStyle());
        InputLayout.ColumnStyles.Add(new ColumnStyle());
        InputLayout.Controls.Add(label1, 0, 0);
        InputLayout.Controls.Add(NameDishe, 1, 0);

        InputLayout.Controls.Add(label2, 0, 1);
        InputLayout.Controls.Add(NameRestarant, 1, 1);

        InputLayout.Controls.Add(label3, 0, 2);
        InputLayout.Controls.Add(Cost, 1, 2);

        InputLayout.Controls.Add(label4, 0, 3);
        InputLayout.Controls.Add(Weight, 1, 3);

        InputLayout.Dock = DockStyle.Top;
        InputLayout.RowCount = 4;
        InputLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));

        InputLayout.ResumeLayout(false);
        InputLayout.PerformLayout();
        this.AppendNewWidget(InputLayout);
    }

    public override async void BtGetData_Click(object sender, EventArgs e){
        try{
            await DataBase.SinglDataBase.AppendPositionMenu(NameDishe.Text, NameRestarant.Text, (int)Cost.Value, (int)Weight.Value);
        } 
        catch(SQLInjection SQLInj){
            MessageBox.Show(SQLInj.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        catch{
            MessageBox.Show("Операция не была завершина, поданны неверные данные", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}

class FormRequest81: AbstractShowForm{
    protected TableLayoutPanel InputLayout = new TableLayoutPanel();
    
    protected TextBox NameDishe = new TextBox();
    protected TextBox DescribeDishe = new TextBox();
    protected CheckBox ForChildren = new CheckBox();

    public FormRequest81(): base() {
        // label1
        Label label1 = new Label();
        label1.AutoSize = true;
        label1.Dock = DockStyle.Top;
        label1.Text = "Введите название блюда";

        NameDishe.AutoSize = true;
        NameDishe.Dock = DockStyle.Top;

        // label2
        Label label2 = new Label();
        label2.AutoSize = true;
        label2.Dock = DockStyle.Top;
        label2.Text = "Введите описание блюда";

        DescribeDishe.AutoSize = true;
        DescribeDishe.Dock = DockStyle.Top;

        ForChildren.AutoSize = true;
        ForChildren.Text = "Блюдо для несовершеннолетних";
        ForChildren.Dock = DockStyle.Top;


        // InputLayout
        InputLayout.AutoSize = true;
        InputLayout.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        InputLayout.ColumnCount = 2;
        InputLayout.ColumnStyles.Add(new ColumnStyle());
        InputLayout.ColumnStyles.Add(new ColumnStyle());
        InputLayout.Controls.Add(label1, 0, 0);
        InputLayout.Controls.Add(NameDishe, 1, 0);

        InputLayout.Controls.Add(label2, 0, 1);
        InputLayout.Controls.Add(DescribeDishe, 1, 1);

        InputLayout.Controls.Add(ForChildren, 1, 2);

        InputLayout.Dock = DockStyle.Top;
        InputLayout.RowCount = 3;
        InputLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));

        InputLayout.ResumeLayout(false);
        InputLayout.PerformLayout();
        this.AppendNewWidget(InputLayout);
    }


    public override async void BtGetData_Click(object sender, EventArgs e){
        try{
            await DataBase.SinglDataBase.AppendNewDishes(NameDishe.Text, DescribeDishe.Text, ForChildren.Checked);
 
        } 
        catch(SQLInjection SQLInj){
            MessageBox.Show(SQLInj.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        catch{
            MessageBox.Show("Операция не была завершена, поданны неверные данные", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}


class FormRequest9: AbstractShowForm{
    protected TableLayoutPanel InputLayout = new TableLayoutPanel();
    protected TextBox name_restaran = new TextBox();


    public FormRequest9(): base() {
        // label1
        Label label1 = new Label();
        label1.AutoSize = true;
        label1.Dock = DockStyle.Top;
        label1.Text = "Введите название заказа";

        // name_restaran
        name_restaran.AutoSize = true;
        name_restaran.Dock = DockStyle.Top;

        // InputLayout
        InputLayout.AutoSize = true;
        InputLayout.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        InputLayout.ColumnCount = 2;
        InputLayout.ColumnStyles.Add(new ColumnStyle());
        InputLayout.ColumnStyles.Add(new ColumnStyle());
        InputLayout.Controls.Add(label1, 0, 0);
        InputLayout.Controls.Add(name_restaran, 1, 0);
        InputLayout.Dock = DockStyle.Top;
        InputLayout.RowCount = 1;
        InputLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));

        InputLayout.ResumeLayout(false);
        InputLayout.PerformLayout();
        this.AppendNewWidget(InputLayout);
    }

    public override async void BtGetData_Click(object sender, EventArgs e){
        try{ await DataBase.SinglDataBase.ChangeState(name_restaran.Text); } 
        catch(SQLInjection SQLInj){
            MessageBox.Show(SQLInj.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}


class FormRequest10: AbstractShowForm{
    protected TableLayoutPanel InputLayout = new TableLayoutPanel();
    
    protected TextBox NameDishe = new TextBox();
    protected TextBox NameRestarant = new TextBox();


    public FormRequest10(): base() {
        // label1
        Label label1 = new Label();
        label1.AutoSize = true;
        label1.Dock = DockStyle.Top;
        label1.Text = "Введите название блюда";

        NameDishe.AutoSize = true;
        NameDishe.Dock = DockStyle.Top;

        // label2
        Label label2 = new Label();
        label2.AutoSize = true;
        label2.Dock = DockStyle.Top;
        label2.Text = "Введите название ресторана";

        NameRestarant.AutoSize = true;
        NameRestarant.Dock = DockStyle.Top;

        // InputLayout
        InputLayout.AutoSize = true;
        InputLayout.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        InputLayout.ColumnCount = 2;
        InputLayout.ColumnStyles.Add(new ColumnStyle());
        InputLayout.ColumnStyles.Add(new ColumnStyle());
        InputLayout.Controls.Add(label1, 0, 0);
        InputLayout.Controls.Add(NameDishe, 1, 0);

        InputLayout.Controls.Add(label2, 0, 1);
        InputLayout.Controls.Add(NameRestarant, 1, 1);


        InputLayout.Dock = DockStyle.Top;
        InputLayout.RowCount = 2;
        InputLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));

        InputLayout.ResumeLayout(false);
        InputLayout.PerformLayout();
        this.AppendNewWidget(InputLayout);
    }


    public override async void BtGetData_Click(object sender, EventArgs e){
        try{ await DataBase.SinglDataBase.ChangeInStock(NameDishe.Text, NameRestarant.Text); } 
        catch(SQLInjection SQLInj){ MessageBox.Show(SQLInj.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        catch{ MessageBox.Show("Операция не была завершина, поданны неверные данные", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error); }

    }
}

class FormRequest11: AbstractTableForm{
    public override async void BtGetData_Click(object sender, EventArgs e){
        Task<List<(string, double)>> res = DataBase.SinglDataBase.GetAVGReceipt();

        this.DataGridSetColumn("Название ресторана", "Средний чек заказов");

        foreach(var i in await res){
            this.DataGrid.Rows.Add( i.Item1.GetString(), i.Item2 );
        }
    }
}

class FormRequest12: AbstractTableForm{
    public override async void BtGetData_Click(object sender, EventArgs e){
        Task<List<(string, long)>> res = DataBase.SinglDataBase.GetCounterOrder();

        this.DataGridSetColumn("ФИО клиента", "Количество заказов");

        foreach(var i in await res){
            this.DataGrid.Rows.Add(
                i.Item1.GetString(), i.Item2
            );
        }
    }
}


class FormRequest14: AbstractTableForm{
    public override async void BtGetData_Click(object sender, EventArgs e){
        Task<List<(string, long)>> res = DataBase.SinglDataBase.GetTopOrders();

        this.DataGridSetColumn("ФИО клиента", "Сумма заказов");

        foreach(var i in await res){
            this.DataGrid.Rows.Add(
                i.Item1.GetString(), i.Item2
            );
        }
    }
}

class FormRequest15: AbstractTableForm{
    public override async void BtGetData_Click(object sender, EventArgs e){
        Task<List<WorkersInRestaurant>> res = DataBase.SinglDataBase.GetWorkersWithUpperSalary();

        this.DataGridSetColumn("ФИО работника", "Описание работника", "Зарплата работника", "Дата рождения работника");

        foreach(var i in await res){
            this.DataGrid.Rows.Add(
                i.Name, i.Describe.GetString(), i.Salary.GetString(), i.BirthdayDate.GetString()
            );
        }
    }
}


class FormRequest16: AbstractTableForm{
    public override async void BtGetData_Click(object sender, EventArgs e){
        Task<(string, long)[]> res = DataBase.SinglDataBase.GetOrdersOnWeek();

        this.DataGridSetColumn("День недели", "Количество заказов");

        foreach(var i in await res){ this.DataGrid.Rows.Add(i.Item1, i.Item2); }
    }
}


class FormRequest17: AbstractTableForm{
    public override async void BtGetData_Click(object sender, EventArgs e){
        Task<List<(string, long)>> res = DataBase.SinglDataBase.GetOrdersWithManyPosition();

        this.DataGridSetColumn("Название заказа", "Количество блюд в заказе");

        foreach(var i in await res){ this.DataGrid.Rows.Add(i.Item1, i.Item2); }
    }
}


class FormRequest18: AbstractTableForm{
    public override async void BtGetData_Click(object sender, EventArgs e){
        Task<List<(string?, double)>> res = DataBase.SinglDataBase.GetOrdersSum();

        this.DataGridSetColumn("Название заказа", "Общая сумма заказа");

        foreach(var i in await res){ this.DataGrid.Rows.Add(i.Item1.GetString(), i.Item2); }
    }
}