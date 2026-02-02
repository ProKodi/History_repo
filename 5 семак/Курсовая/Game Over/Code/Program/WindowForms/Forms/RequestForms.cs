



using MySql.Data.MySqlClient;
using System.Data;


class FormRequest1: AbstractTableForm{
    public override async void BtGetData_Click(object sender, EventArgs e){
        var adapter = new MySqlDataAdapter(
            $"select * FROM possessions p " +
            "WHERE p.state = 'Выставлен на продажу'", 
            DataBase.SinglDataBase.connection
        );

        DataTable table = new DataTable();
        adapter.Fill(table);
        this.DataGrid.DataSource = table;
    }
}

class FormRequest2: AbstractTableForm{
    protected TableLayoutPanel InputLayout = new TableLayoutPanel();
    protected TextBox name_city = new TextBox();

    public FormRequest2(): base() {
        // label1
        Label label1 = new Label();
        label1.AutoSize = true;
        label1.Dock = DockStyle.Top;
        label1.Text = "Введите название города";

        // InputLayout
        InputLayout.AutoSize = true;
        InputLayout.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        InputLayout.ColumnCount = 2;
        InputLayout.ColumnStyles.Add(new ColumnStyle());
        InputLayout.ColumnStyles.Add(new ColumnStyle());
        InputLayout.Controls.Add(label1, 0, 0);
        InputLayout.Controls.Add(name_city, 1, 0);
        InputLayout.Dock = DockStyle.Top;
        InputLayout.RowCount = 1;
        InputLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));

        // id_restorant
        name_city.AutoSize = true;
        name_city.Dock = DockStyle.Top;
        name_city.Text = "Москва";

        InputLayout.ResumeLayout(false);
        InputLayout.PerformLayout();
        this.AppendNewWidget(InputLayout);
    }

    public override async void BtGetData_Click(object sender, EventArgs e){
        using var adapter = new MySqlDataAdapter(
            $"select * FROM possessions p " +
            $"WHERE p.city = '{name_city.Text}'", 
            DataBase.SinglDataBase.connection
        );
        

        DataTable table = new DataTable();
        adapter.Fill(table);
        this.DataGrid.DataSource = table;
    }
}

class FormRequest3: AbstractTableForm{
    public override async void BtGetData_Click(object sender, EventArgs e){
        using var adapter = new MySqlDataAdapter(
            $"select r.name, COUNT(*) FROM rieltor r " +
            $"  LEFT JOIN possessions p " + 
            "  ON r.id = p.id_rieltor " +
            "  GROUP BY r.id", 
            DataBase.SinglDataBase.connection
        );
        
        DataTable table = new DataTable();
        adapter.Fill(table);
        this.DataGrid.DataSource = table;
    }
}

class FormRequest4: AbstractTableForm{
    public override async void BtGetData_Click(object sender, EventArgs e){
        using var adapter = new MySqlDataAdapter(
            $"select c.* FROM customer c " +
            "  JOIN type_position tp " + 
            "  ON c.id_type = tp.id" +
            "  WHERE tp.name = 'Квартира'", 
            DataBase.SinglDataBase.connection
        );
        
        DataTable table = new DataTable();
        adapter.Fill(table);
        this.DataGrid.DataSource = table;
    }
}

class FormRequest5: AbstractTableForm{
    protected TableLayoutPanel InputLayout = new TableLayoutPanel();
    protected NumericUpDown id = new NumericUpDown();

    public FormRequest5(): base() {
        // label1
        Label label1 = new Label();
        label1.AutoSize = true;
        label1.Dock = DockStyle.Top;
        label1.Text = "Введите id объекта недвижемости";

        // InputLayout
        InputLayout.AutoSize = true;
        InputLayout.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        InputLayout.ColumnCount = 2;
        InputLayout.ColumnStyles.Add(new ColumnStyle());
        InputLayout.ColumnStyles.Add(new ColumnStyle());
        InputLayout.Controls.Add(label1, 0, 0);
        InputLayout.Controls.Add(id, 1, 0);
        InputLayout.Dock = DockStyle.Top;
        InputLayout.RowCount = 1;
        InputLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));

        // id_restorant
        id.AutoSize = true;
        id.Dock = DockStyle.Top;
        id.Value = 1;

        InputLayout.ResumeLayout(false);
        InputLayout.PerformLayout();
        this.AppendNewWidget(InputLayout);
    }

    public override async void BtGetData_Click(object sender, EventArgs e){
        using var adapter = new MySqlDataAdapter(
            $"select * FROM vision v " +
            $"  WHERE v.id_possetions = {id.Value}", 
            DataBase.SinglDataBase.connection
        );
        
        DataTable table = new DataTable();
        adapter.Fill(table);
        this.DataGrid.DataSource = table;
    }
}


class FormRequest6: AbstractTableForm{
    public override async void BtGetData_Click(object sender, EventArgs e){
        using var adapter = new MySqlDataAdapter(
            $"select * FROM possessions p " +
            "  ORDER BY p.cost DESC" + 
            "  LIMIT 0, 5", 
            DataBase.SinglDataBase.connection
        );
        
        DataTable table = new DataTable();
        adapter.Fill(table);
        this.DataGrid.DataSource = table;
    }
}


class FormRequest7: AbstractTableForm{
    public override async void BtGetData_Click(object sender, EventArgs e){
        using var adapter = new MySqlDataAdapter(
            "select * FROM `order` o " + 
            "  WHERE MONTH(date) = MONTH(Date(NOW()))", 
            DataBase.SinglDataBase.connection
        );
        
        DataTable table = new DataTable();
        adapter.Fill(table);
        this.DataGrid.DataSource = table;
    }
}


class FormRequest8: AbstractTableForm{
    public override async void BtGetData_Click(object sender, EventArgs e){
        using var adapter = new MySqlDataAdapter(
            "SELECT SUM(p.cost) FROM `order` o " + 
            "  JOIN possessions p" + 
            "  ON o.id_position = p.id" + 
            "  WHERE o.direction = 'Продажа'", 
            DataBase.SinglDataBase.connection
        );
        
        DataTable table = new DataTable();
        adapter.Fill(table);
        this.DataGrid.DataSource = table;
    }
}

class FormRequest81: AbstractTableForm{
    public override async void BtGetData_Click(object sender, EventArgs e){
        using var adapter = new MySqlDataAdapter(
            "SELECT * FROM possessions p " + 
            "  WHERE NOT EXISTS (" + 
            "    select * FROM vision v" + 
            "      WHERE v.id_possetions = p.id" +
            "  )", 
            DataBase.SinglDataBase.connection
        );
        
        DataTable table = new DataTable();
        adapter.Fill(table);
        this.DataGrid.DataSource = table;
    }
}


class FormRequest9: AbstractTableForm{
    public override async void BtGetData_Click(object sender, EventArgs e){
        using var adapter = new MySqlDataAdapter(
            "select * FROM salesmans s" + 
            "  WHERE (" + 
            "    SELECT COUNT(*) FROM possessions p" + 
            "      WHERE p.state = 'Выставлен на продажу' AND p.id_salesmans = s.id" +
            "  ) > 1", 
            DataBase.SinglDataBase.connection
        );
        
        DataTable table = new DataTable();
        adapter.Fill(table);
        this.DataGrid.DataSource = table;
    }
}


class FormRequest10: AbstractShowForm{
    protected TableLayoutPanel InputLayout = new TableLayoutPanel();
    protected TextBox adress = new TextBox();
    protected TextBox city = new TextBox();
    protected NumericUpDown square = new NumericUpDown();
    protected NumericUpDown id_type = new NumericUpDown();
    protected NumericUpDown cost = new NumericUpDown();
    protected NumericUpDown id_rieltor = new NumericUpDown();
    protected ComboBox state = new ComboBox();
    protected NumericUpDown id_salesmans = new NumericUpDown();


    public FormRequest10(): base() {
        // label1
        Label label1 = new Label();
        label1.AutoSize = true;
        label1.Dock = DockStyle.Top;
        label1.Text = "Введите адресс";

        adress.AutoSize = true;
        adress.Dock = DockStyle.Top;

        // label2
        Label label2 = new Label();
        label2.AutoSize = true;
        label2.Dock = DockStyle.Top;
        label2.Text = "Введите город";

        city.AutoSize = true;
        city.Dock = DockStyle.Top;

        // label3
        Label label3 = new Label();
        label3.AutoSize = true;
        label3.Dock = DockStyle.Top;
        label3.Text = "Введите площадь";

        square.AutoSize = true;
        square.Maximum = int.MaxValue;
        square.Dock = DockStyle.Top;

        // label4
        Label label4 = new Label();
        label4.AutoSize = true;
        label4.Dock = DockStyle.Top;
        label4.Text = "Введите код типа недвижимости";

        id_type.AutoSize = true;
        id_type.Dock = DockStyle.Top;


        // label5
        Label label5 = new Label();
        label5.AutoSize = true;
        label5.Dock = DockStyle.Top;
        label5.Text = "Введите стоимость";

        cost.AutoSize = true;
        cost.Maximum = int.MaxValue;
        cost.Dock = DockStyle.Top;

        // label6
        Label label6 = new Label();
        label6.AutoSize = true;
        label6.Dock = DockStyle.Top;
        label6.Text = "Введите код релтора";

        id_rieltor.AutoSize = true;
        id_rieltor.Dock = DockStyle.Top;

        // label7
        Label label7 = new Label();
        label7.AutoSize = true;
        label7.Dock = DockStyle.Top;
        label7.Text = "Введите состояние объекта (продано/выставлено на продажу)";

        state.AutoSize = true;
        state.Dock = DockStyle.Top;
        state.Items.AddRange(["Продан", "Выставлен на продажу", "Снят с продажи"]);
        state.SelectedIndex = 0; 

        // label7
        Label label8 = new Label();
        label8.AutoSize = true;
        label8.Dock = DockStyle.Top;
        label8.Text = "Введите код владельца имущества";

        id_salesmans.AutoSize = true;
        id_salesmans.Dock = DockStyle.Top;

        // InputLayout
        InputLayout.AutoSize = true;
        InputLayout.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        InputLayout.ColumnCount = 2;
        InputLayout.ColumnStyles.Add(new ColumnStyle());
        InputLayout.ColumnStyles.Add(new ColumnStyle());
        InputLayout.Controls.Add(label1, 0, 0);
        InputLayout.Controls.Add(adress, 1, 0);

        InputLayout.Controls.Add(label2, 0, 1);
        InputLayout.Controls.Add(city, 1, 1);

        InputLayout.Controls.Add(label3, 0, 2);
        InputLayout.Controls.Add(square, 1, 2);

        InputLayout.Controls.Add(label4, 0, 3);
        InputLayout.Controls.Add(id_type, 1, 3);

        InputLayout.Controls.Add(label5, 0, 4);
        InputLayout.Controls.Add(cost, 1, 4);

        InputLayout.Controls.Add(label6, 0, 5);
        InputLayout.Controls.Add(id_rieltor, 1, 5);

        InputLayout.Controls.Add(label7, 0, 6);
        InputLayout.Controls.Add(state, 1, 6);

        InputLayout.Controls.Add(label8, 0, 7);
        InputLayout.Controls.Add(id_salesmans, 1, 7);


        InputLayout.Dock = DockStyle.Top;
        InputLayout.RowCount = 8;

        InputLayout.ResumeLayout(false);
        InputLayout.PerformLayout();
        this.AppendNewWidget(InputLayout);
    }


    public override async void BtGetData_Click(object sender, EventArgs e){
        try{
            using var command = new MySqlCommand($"""
                INSERT INTO possessions (`adress`, `city`, `square`, `id_type`, `cost`, `id_rieltor`, `state`, `id_salesmans`)
                    VALUE ('{this.adress.Text}', '{this.city.Text}', {this.square.Value}, {this.id_type.Value}, {this.cost.Value}, {this.id_rieltor.Value}, '{this.state.Text}', {this.id_salesmans.Value})
                """, DataBase.SinglDataBase.connection
            );
            using var reader = command.ExecuteReader();
        }
        catch{
            MessageBox.Show(
                "Вы ввели не верные данные или ввели не все необходимые данные",
                "Ошибка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
        }
    }
}

class FormRequest11: AbstractShowForm{
    protected TableLayoutPanel InputLayout = new TableLayoutPanel();
    protected NumericUpDown id_possessions = new NumericUpDown();


    public FormRequest11(): base() {
        // label1
        Label label1 = new Label();
        label1.AutoSize = true;
        label1.Dock = DockStyle.Top;
        label1.Text = "Введите код имущества";

        id_possessions.AutoSize = true;
        id_possessions.Dock = DockStyle.Top;


        // InputLayout
        InputLayout.AutoSize = true;
        InputLayout.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        InputLayout.ColumnCount = 2;
        InputLayout.ColumnStyles.Add(new ColumnStyle());
        InputLayout.ColumnStyles.Add(new ColumnStyle());
        InputLayout.Controls.Add(label1, 0, 0);
        InputLayout.Controls.Add(id_possessions, 1, 0);

        InputLayout.Dock = DockStyle.Top;
        InputLayout.RowCount = 1;

        InputLayout.ResumeLayout(false);
        InputLayout.PerformLayout();
        this.AppendNewWidget(InputLayout);
    }


    public override async void BtGetData_Click(object sender, EventArgs e){
        try{
            using var command = new MySqlCommand($"""
                UPDATE possessions
                    set state = "Продан"
                    WHERE id = {id_possessions.Value}
                """, DataBase.SinglDataBase.connection
            );
            using var reader = command.ExecuteReader();
        }
        catch{
            MessageBox.Show(
                "Вы ввели не верные данные или ввели не все необходимые данные",
                "Ошибка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
        }
    }
}

class FormRequest12: AbstractTableForm{
    public override async void BtGetData_Click(object sender, EventArgs e){
        using var adapter = new MySqlDataAdapter(
            "select AVG(cost / p.square) FROM possessions p", 
            DataBase.SinglDataBase.connection
        );
        
        DataTable table = new DataTable();
        adapter.Fill(table);
        this.DataGrid.DataSource = table;
    }
}


class FormRequest14: AbstractTableForm{
    protected TableLayoutPanel InputLayout = new TableLayoutPanel();
    protected TextBox name_city = new TextBox();


    public FormRequest14(): base() {
        // label1
        Label label1 = new Label();
        label1.AutoSize = true;
        label1.Dock = DockStyle.Top;
        label1.Text = "Введите название города в котором филиал";

        // InputLayout
        InputLayout.AutoSize = true;
        InputLayout.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        InputLayout.ColumnCount = 2;
        InputLayout.ColumnStyles.Add(new ColumnStyle());
        InputLayout.ColumnStyles.Add(new ColumnStyle());
        InputLayout.Controls.Add(label1, 0, 0);
        InputLayout.Controls.Add(name_city, 1, 0);
        InputLayout.Dock = DockStyle.Top;
        InputLayout.RowCount = 1;
        InputLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));

        // id_restorant
        name_city.AutoSize = true;
        name_city.Dock = DockStyle.Top;
        name_city.Text = "Санкт-Петербург";

        InputLayout.ResumeLayout(false);
        InputLayout.PerformLayout();
        this.AppendNewWidget(InputLayout);
    }


    public override async void BtGetData_Click(object sender, EventArgs e){
        using var adapter = new MySqlDataAdapter(
            "SELECT * FROM rieltor r" + 
            "  WHERE r.id_company IN (" +
            "    select id FROM department rc" + 
            $"      WHERE rc.city = '{name_city.Text}'" + 
            "  )", 
            DataBase.SinglDataBase.connection
        );
        
        DataTable table = new DataTable();
        adapter.Fill(table);
        this.DataGrid.DataSource = table;
    }
}



class FormRequest15: AbstractTableForm{
    public override async void BtGetData_Click(object sender, EventArgs e){
        using var adapter = new MySqlDataAdapter(
            "SELECT * FROM customer c" + 
            "  WHERE (" +
            "    select count(*)  FROM vision v" + 
            "      WHERE v.id_customer = c.id" + 
            "    ) > 3", 
            DataBase.SinglDataBase.connection
        );
        
        DataTable table = new DataTable();
        adapter.Fill(table);
        this.DataGrid.DataSource = table;
    }
}


class FormRequest16: AbstractTableForm{
    public override async void BtGetData_Click(object sender, EventArgs e){
        using var adapter = new MySqlDataAdapter("""
            select * FROM possessions p
              WHERE p.cost < (
                SELECT AVG(cost) FROM possessions
            )
            """, 
            DataBase.SinglDataBase.connection
        );
        
        DataTable table = new DataTable();
        adapter.Fill(table);
        this.DataGrid.DataSource = table;
    }
}


class FormRequest17: AbstractTableForm{

    public FormRequest17():base(){
        this.DataBox.Dispose();
    } 

    public override async void BtGetData_Click(object sender, EventArgs e){
        using var adapter = new MySqlDataAdapter("""
                DELETE FROM vision 
                  WHERE id_possetions IN (
                  SELECT id FROM possessions
                    WHERE possessions.state = "Снят с продажи"
                );
                
                DELETE FROM `order` 
                  WHERE id_position IN (
                  SELECT id FROM possessions
                    WHERE possessions.state = "Снят с продажи"
                );
                
                DELETE FROM possessions
                  WHERE possessions.state = "Снят с продажи"
            """, 
            DataBase.SinglDataBase.connection
        );
        
        DataTable table = new DataTable();
        adapter.Fill(table);
        this.DataGrid.DataSource = table;
    }
}


class FormRequest18: AbstractTableForm{
    public override async void BtGetData_Click(object sender, EventArgs e){
        using var adapter = new MySqlDataAdapter("""
            SELECT r.name, COUNT(*) FROM `order` o
              JOIN possessions p
              ON o.id_position = p.id
            
              JOIN rieltor r 
              ON p.id_rieltor = r.id
            
              WHERE o.is_successful
              GROUP BY r.id
            """, 
            DataBase.SinglDataBase.connection
        );
        
        DataTable table = new DataTable();
        adapter.Fill(table);
        this.DataGrid.DataSource = table;
    }
}