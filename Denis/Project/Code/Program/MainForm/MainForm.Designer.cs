
partial class MainForm{
    private void InitializeComponent(){
        tableLayoutPanel1 = new TableLayoutPanel();
        BtExit = new Button();
        Request5 = new Button();
        Request4 = new Button();
        Request3 = new Button();
        Request2 = new Button();
        Request1 = new Button();
        label1 = new Label();
        label2 = new Label();
        GetClients = new Button();
        GetMenuItem = new Button();
        GetOrders = new Button();
        GetPositions = new Button();
        GetRangeDishes = new Button();
        GetRestaurants = new Button();
        tableLayoutPanel1.SuspendLayout();
        SuspendLayout();

        // tableLayoutPanel1
        tableLayoutPanel1.AutoSize = true;
        tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        tableLayoutPanel1.ColumnCount = 2;
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        tableLayoutPanel1.Controls.Add(BtExit, 0, 18);
        tableLayoutPanel1.Controls.Add(Request5, 1, 5);
        tableLayoutPanel1.Controls.Add(Request4, 1, 4);
        tableLayoutPanel1.Controls.Add(Request3, 1, 3);
        tableLayoutPanel1.Controls.Add(Request2, 1, 2);
        tableLayoutPanel1.Controls.Add(Request1, 1, 1);
        tableLayoutPanel1.Controls.Add(label1, 0, 0);
        tableLayoutPanel1.Controls.Add(label2, 1, 0);
        tableLayoutPanel1.Controls.Add(GetClients, 0, 1);
        tableLayoutPanel1.Controls.Add(GetMenuItem, 0, 2);
        tableLayoutPanel1.Controls.Add(GetOrders, 0, 3);
        tableLayoutPanel1.Controls.Add(GetPositions, 0, 4);
        tableLayoutPanel1.Controls.Add(GetRangeDishes, 0, 5);
        tableLayoutPanel1.Controls.Add(GetRestaurants, 0, 6);
        tableLayoutPanel1.Dock = DockStyle.Top;
        tableLayoutPanel1.Location = new Point(0, 0);
        tableLayoutPanel1.RowCount = 19;
        tableLayoutPanel1.RowStyles.Add(new RowStyle());
        tableLayoutPanel1.RowStyles.Add(new RowStyle());
        tableLayoutPanel1.RowStyles.Add(new RowStyle());
        tableLayoutPanel1.RowStyles.Add(new RowStyle());
        tableLayoutPanel1.RowStyles.Add(new RowStyle());
        tableLayoutPanel1.RowStyles.Add(new RowStyle());
        tableLayoutPanel1.RowStyles.Add(new RowStyle());
        tableLayoutPanel1.RowStyles.Add(new RowStyle());
        tableLayoutPanel1.RowStyles.Add(new RowStyle());
        tableLayoutPanel1.RowStyles.Add(new RowStyle());
        tableLayoutPanel1.RowStyles.Add(new RowStyle());
        tableLayoutPanel1.RowStyles.Add(new RowStyle());
        tableLayoutPanel1.RowStyles.Add(new RowStyle());
        tableLayoutPanel1.RowStyles.Add(new RowStyle());
        tableLayoutPanel1.RowStyles.Add(new RowStyle());
        tableLayoutPanel1.RowStyles.Add(new RowStyle());
        tableLayoutPanel1.RowStyles.Add(new RowStyle());
        tableLayoutPanel1.RowStyles.Add(new RowStyle());
        tableLayoutPanel1.RowStyles.Add(new RowStyle());
        tableLayoutPanel1.Size = new Size(399, 573);

        // BtExit
        BtExit.AutoSize = true;
        BtExit.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        BtExit.Dock = DockStyle.Top;
        BtExit.Location = new Point(3, 545);
        BtExit.Size = new Size(193, 25);
        BtExit.Text = "Выход";
        BtExit.UseVisualStyleBackColor = true;
        BtExit.Click += delegate(object sender, EventArgs e){ Application.Exit(); };

        // Request5
        Request5.AutoSize = true;
        Request5.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        Request5.Dock = DockStyle.Top;
        Request5.Location = new Point(202, 142);
        Request5.Size = new Size(194, 25);
        Request5.Text = "Запрос 5";
        Request5.UseVisualStyleBackColor = true;
        Request5.Click += Request5_Click;

        // Request4
        Request4.AutoSize = true;
        Request4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        Request4.Dock = DockStyle.Top;
        Request4.Location = new Point(202, 111);
        Request4.Size = new Size(194, 25);
        Request4.Text = "Запрос 4";
        Request4.UseVisualStyleBackColor = true;
        Request4.Click += Request4_Click;

        // Request3
        Request3.AutoSize = true;
        Request3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        Request3.Dock = DockStyle.Top;
        Request3.Location = new Point(202, 80);
        Request3.Size = new Size(194, 25);
        Request3.Text = "Запрос 3";
        Request3.UseVisualStyleBackColor = true;
        Request3.Click += Request3_Click;

        // Request2
        Request2.AutoSize = true;
        Request2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        Request2.Dock = DockStyle.Top;
        Request2.Location = new Point(202, 49);
        Request2.Size = new Size(194, 25);
        Request2.Text = "Запрос 2";
        Request2.UseVisualStyleBackColor = true;
        Request2.Click += Request2_Click;

        // Request1
        Request1.AutoSize = true;
        Request1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        Request1.Dock = DockStyle.Top;
        Request1.Location = new Point(202, 18);
        Request1.Size = new Size(194, 25);
        Request1.Text = "Запрос 1";
        Request1.UseVisualStyleBackColor = true;
        Request1.Click += Request1_Click;

        // label1
        label1.AutoSize = true;
        label1.Dock = DockStyle.Top;
        label1.Location = new Point(3, 0);
        label1.Size = new Size(193, 15);
        label1.Text = "Посмотреть таблицы БД";
        label1.TextAlign = ContentAlignment.TopCenter;

        // label2
        label2.AutoSize = true;
        label2.Dock = DockStyle.Top;
        label2.Location = new Point(202, 0);
        label2.Size = new Size(194, 15);
        label2.Text = "Выполнить запросы";
        label2.TextAlign = ContentAlignment.TopCenter;

        // GetClients
        GetClients.AutoSize = true;
        GetClients.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        GetClients.Dock = DockStyle.Top;
        GetClients.Location = new Point(3, 18);
        GetClients.Size = new Size(193, 25);
        GetClients.Text = "Клиенты";
        GetClients.UseVisualStyleBackColor = true;
        GetClients.Click += GetClients_Click;

        // GetMenuItem
        GetMenuItem.AutoSize = true;
        GetMenuItem.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        GetMenuItem.Dock = DockStyle.Top;
        GetMenuItem.Location = new Point(3, 49);
        GetMenuItem.Size = new Size(193, 25);
        GetMenuItem.Text = "Работники банка";
        GetMenuItem.UseVisualStyleBackColor = true;
        GetMenuItem.Click += GetMenuItem_Click;

        // GetOrders
        GetOrders.AutoSize = true;
        GetOrders.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        GetOrders.Dock = DockStyle.Top;
        GetOrders.Location = new Point(3, 80);
        GetOrders.Size = new Size(193, 25);
        GetOrders.Text = "Языки";
        GetOrders.UseVisualStyleBackColor = true;
        GetOrders.Click += GetOrders_Click;

        // GetPositions
        GetPositions.AutoSize = true;
        GetPositions.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        GetPositions.Dock = DockStyle.Top;
        GetPositions.Location = new Point(3, 111);
        GetPositions.Size = new Size(193, 25);
        GetPositions.Text = "Уровни освоения языков";
        GetPositions.UseVisualStyleBackColor = true;
        GetPositions.Click += GetPositions_Click;

        // GetRangeDishes
        GetRangeDishes.AutoSize = true;
        GetRangeDishes.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        GetRangeDishes.Dock = DockStyle.Top;
        GetRangeDishes.Location = new Point(3, 142);
        GetRangeDishes.Size = new Size(193, 25);
        GetRangeDishes.Text = "Языки которые знают клиенты";
        GetRangeDishes.UseVisualStyleBackColor = true;
        GetRangeDishes.Click += GetRangeDishes_Click;

        // GetRestaurants
        GetRestaurants.AutoSize = true;
        GetRestaurants.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        GetRestaurants.Dock = DockStyle.Top;
        GetRestaurants.Location = new Point(3, 173);
        GetRestaurants.Size = new Size(193, 25);
        GetRestaurants.Text = "Языки которые знают работники";
        GetRestaurants.UseVisualStyleBackColor = true;
        GetRestaurants.Click += GetRestaurants_Click;



        // MainForm
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(399, 581);
        Controls.Add(tableLayoutPanel1);
        Text = "MainForm";
        tableLayoutPanel1.ResumeLayout(false);
        tableLayoutPanel1.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }


    private TableLayoutPanel tableLayoutPanel1;
    private Label label1;
    private Label label2;
    private Button GetClients;
    private Button GetMenuItem;
    private Button GetOrders;
    private Button GetPositions;
    private Button GetRangeDishes;
    private Button GetRestaurants;
    private Button Request5;
    private Button Request4;
    private Button Request3;
    private Button Request2;
    private Button Request1;
    private Button BtExit;
}
