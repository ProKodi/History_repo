

partial class InputForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.first_color = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.charts_width = new System.Windows.Forms.NumericUpDown();
            this.used_drid = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.g = new System.Windows.Forms.NumericUpDown();
            this.set_g = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.a = new System.Windows.Forms.NumericUpDown();
            this.set_a = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.second_color = new System.Windows.Forms.ComboBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.fouth_color = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.r = new System.Windows.Forms.NumericUpDown();
            this.set_r = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.b = new System.Windows.Forms.NumericUpDown();
            this.set_b = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.k = new System.Windows.Forms.NumericUpDown();
            this.set_k = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.third_color = new System.Windows.Forms.ComboBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.charts_width)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.g)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.a)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.r)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.b)).BeginInit();
            this.flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.k)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // first_color
            // 
            this.first_color.Dock = System.Windows.Forms.DockStyle.Fill;
            this.first_color.FormattingEnabled = true;
            this.first_color.Location = new System.Drawing.Point(117, 38);
            this.first_color.Name = "first_color";
            this.first_color.Size = new System.Drawing.Size(230, 21);
            this.first_color.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Цвет графика";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Толщина графика";
            // 
            // charts_width
            // 
            this.charts_width.AutoSize = true;
            this.charts_width.Dock = System.Windows.Forms.DockStyle.Fill;
            this.charts_width.Location = new System.Drawing.Point(198, 3);
            this.charts_width.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.charts_width.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.charts_width.Name = "charts_width";
            this.charts_width.ReadOnly = true;
            this.charts_width.Size = new System.Drawing.Size(523, 20);
            this.charts_width.TabIndex = 3;
            this.charts_width.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // used_drid
            // 
            this.used_drid.AutoSize = true;
            this.used_drid.Checked = true;
            this.used_drid.CheckState = System.Windows.Forms.CheckState.Checked;
            this.used_drid.Dock = System.Windows.Forms.DockStyle.Top;
            this.used_drid.Location = new System.Drawing.Point(3, 29);
            this.used_drid.Name = "used_drid";
            this.used_drid.Size = new System.Drawing.Size(189, 17);
            this.used_drid.TabIndex = 4;
            this.used_drid.Text = "Указывать координатную сетку";
            this.used_drid.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(730, 68);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Общее для графиков";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.used_drid, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.charts_width, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(724, 49);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox2.Controls.Add(this.tableLayoutPanel6);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 77);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(730, 257);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Параметры для конкретных графиков";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.AutoSize = true;
            this.tableLayoutPanel6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.groupBox3, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.groupBox4, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.groupBox6, 1, 1);
            this.tableLayoutPanel6.Controls.Add(this.groupBox5, 0, 1);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.Size = new System.Drawing.Size(724, 238);
            this.tableLayoutPanel6.TabIndex = 28;
            // 
            // groupBox3
            // 
            this.groupBox3.AutoSize = true;
            this.groupBox3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox3.Controls.Add(this.tableLayoutPanel2);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(356, 81);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "График вида: x^3 * (x - g)";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.first_color, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(350, 62);
            this.tableLayoutPanel2.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 35);
            this.label3.TabIndex = 8;
            this.label3.Text = "Введите значение g";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.g);
            this.flowLayoutPanel1.Controls.Add(this.set_g);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(117, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(230, 29);
            this.flowLayoutPanel1.TabIndex = 32;
            // 
            // g
            // 
            //this.g.AutoSize = true;
            this.g.Dock = System.Windows.Forms.DockStyle.Fill;
            this.g.Location = new System.Drawing.Point(3, 3);
            this.g.Name = "g";
            this.g.Size = new System.Drawing.Size(60, 23);
            this.g.TabIndex = 9;
            this.g.Maximum = 20;
            this.g.Minimum = -20;
            // 
            // set_g
            // 
            this.set_g.AutoSize = true;
            this.set_g.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.set_g.Dock = System.Windows.Forms.DockStyle.Fill;
            this.set_g.Location = new System.Drawing.Point(50, 3);
            this.set_g.Name = "set_g";
            this.set_g.Size = new System.Drawing.Size(106, 23);
            this.set_g.TabIndex = 10;
            this.set_g.Text = "Задать рандомно";
            this.set_g.UseVisualStyleBackColor = true;
            this.set_g.Click += new System.EventHandler(this.set_g_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.AutoSize = true;
            this.groupBox4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox4.Controls.Add(this.tableLayoutPanel3);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(365, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(356, 81);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "График вида: (a / 2) * (e ^ (x / a) + e ^ (-x / a)  ) ";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.flowLayoutPanel2, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.second_color, 1, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(350, 62);
            this.tableLayoutPanel3.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 35);
            this.label4.TabIndex = 12;
            this.label4.Text = "Введите значение a";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel2.Controls.Add(this.a);
            this.flowLayoutPanel2.Controls.Add(this.set_a);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(117, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(230, 29);
            this.flowLayoutPanel2.TabIndex = 32;
            // 
            // a
            // 
           // this.a.AutoSize = true;
            this.a.Dock = System.Windows.Forms.DockStyle.Fill;
            this.a.Location = new System.Drawing.Point(3, 3);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(60, 23);
            this.a.TabIndex = 13;
            this.a.Maximum = 20;
            this.a.Minimum = -20;
            // 
            // set_a
            // 
            this.set_a.AutoSize = true;
            this.set_a.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.set_a.Dock = System.Windows.Forms.DockStyle.Fill;
            this.set_a.Location = new System.Drawing.Point(50, 3);
            this.set_a.Name = "set_a";
            this.set_a.Size = new System.Drawing.Size(106, 23);
            this.set_a.TabIndex = 14;
            this.set_a.Text = "Задать рандомно";
            this.set_a.UseVisualStyleBackColor = true;
            this.set_a.Click += new System.EventHandler(this.set_a_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 27);
            this.label5.TabIndex = 16;
            this.label5.Text = "Цвет графика";
            // 
            // second_color
            // 
            this.second_color.Dock = System.Windows.Forms.DockStyle.Fill;
            this.second_color.FormattingEnabled = true;
            this.second_color.Location = new System.Drawing.Point(117, 38);
            this.second_color.Name = "second_color";
            this.second_color.Size = new System.Drawing.Size(230, 21);
            this.second_color.TabIndex = 15;
            // 
            // groupBox6
            // 
            this.groupBox6.AutoSize = true;
            this.groupBox6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox6.Controls.Add(this.tableLayoutPanel5);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox6.Location = new System.Drawing.Point(365, 90);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(356, 145);
            this.groupBox6.TabIndex = 26;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "График вида: y^2 + x^2 = r^2";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.AutoSize = true;
            this.tableLayoutPanel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.Controls.Add(this.label10, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.fouth_color, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.flowLayoutPanel5, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.label9, 0, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.Size = new System.Drawing.Size(350, 126);
            this.tableLayoutPanel5.TabIndex = 33;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Location = new System.Drawing.Point(3, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 35);
            this.label10.TabIndex = 27;
            this.label10.Text = "Введите значение r";
            // 
            // fouth_color
            // 
            this.fouth_color.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fouth_color.FormattingEnabled = true;
            this.fouth_color.Location = new System.Drawing.Point(114, 38);
            this.fouth_color.Name = "fouth_color";
            this.fouth_color.Size = new System.Drawing.Size(233, 21);
            this.fouth_color.TabIndex = 30;
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.AutoSize = true;
            this.flowLayoutPanel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel5.Controls.Add(this.r);
            this.flowLayoutPanel5.Controls.Add(this.set_r);
            this.flowLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel5.Location = new System.Drawing.Point(114, 3);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(233, 29);
            this.flowLayoutPanel5.TabIndex = 32;
            // 
            // r
            // 
            //this.r.AutoSize = true;
            this.r.Dock = System.Windows.Forms.DockStyle.Fill;
            this.r.Location = new System.Drawing.Point(3, 3);
            this.r.Name = "r";
            this.r.Size = new System.Drawing.Size(60, 23);
            this.r.TabIndex = 28;
            this.r.Maximum = 20;
            // 
            // set_r
            // 
            this.set_r.AutoSize = true;
            this.set_r.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.set_r.Dock = System.Windows.Forms.DockStyle.Fill;
            this.set_r.Location = new System.Drawing.Point(50, 3);
            this.set_r.Name = "set_r";
            this.set_r.Size = new System.Drawing.Size(106, 23);
            this.set_r.TabIndex = 29;
            this.set_r.Text = "Задать рандомно";
            this.set_r.UseVisualStyleBackColor = true;
            this.set_r.Click += new System.EventHandler(this.set_r_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Location = new System.Drawing.Point(3, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 91);
            this.label9.TabIndex = 31;
            this.label9.Text = "Цвет графика";
            // 
            // groupBox5
            // 
            this.groupBox5.AutoSize = true;
            this.groupBox5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox5.Controls.Add(this.tableLayoutPanel4);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(3, 90);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(356, 145);
            this.groupBox5.TabIndex = 17;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "График вида: k * x + b";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.AutoSize = true;
            this.tableLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.Controls.Add(this.flowLayoutPanel4, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.flowLayoutPanel3, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.label7, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.third_color, 1, 2);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.Size = new System.Drawing.Size(350, 126);
            this.tableLayoutPanel4.TabIndex = 33;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.AutoSize = true;
            this.flowLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel4.Controls.Add(this.b);
            this.flowLayoutPanel4.Controls.Add(this.set_b);
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(117, 38);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(230, 29);
            this.flowLayoutPanel4.TabIndex = 34;
            // 
            // b
            // 
            //this.b.AutoSize = true;
            this.b.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b.Location = new System.Drawing.Point(3, 3);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(60, 23);
            this.b.TabIndex = 19;
            this.b.Maximum = 20;
            this.b.Minimum = -20;
            // 
            // set_b
            // 
            this.set_b.AutoSize = true;
            this.set_b.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.set_b.Dock = System.Windows.Forms.DockStyle.Fill;
            this.set_b.Location = new System.Drawing.Point(50, 3);
            this.set_b.Name = "set_b";
            this.set_b.Size = new System.Drawing.Size(106, 23);
            this.set_b.TabIndex = 20;
            this.set_b.Text = "Задать рандомно";
            this.set_b.UseVisualStyleBackColor = true;
            this.set_b.Click += new System.EventHandler(this.set_b_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 35);
            this.label8.TabIndex = 23;
            this.label8.Text = "Введите значение k";
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.AutoSize = true;
            this.flowLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel3.Controls.Add(this.k);
            this.flowLayoutPanel3.Controls.Add(this.set_k);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(117, 3);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(230, 29);
            this.flowLayoutPanel3.TabIndex = 32;
            // 
            // k
            // 
            //this.k.AutoSize = true;
            this.k.Dock = System.Windows.Forms.DockStyle.Fill;
            this.k.Location = new System.Drawing.Point(3, 3);
            this.k.Name = "k";
            this.k.Size = new System.Drawing.Size(60, 23);
            this.k.TabIndex = 24;
            this.k.Maximum = 20;
            this.k.Minimum = -20;
            // 
            // set_k
            // 
            this.set_k.AutoSize = true;
            this.set_k.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.set_k.Dock = System.Windows.Forms.DockStyle.Fill;
            this.set_k.Location = new System.Drawing.Point(50, 3);
            this.set_k.Name = "set_k";
            this.set_k.Size = new System.Drawing.Size(106, 23);
            this.set_k.TabIndex = 25;
            this.set_k.Text = "Задать рандомно";
            this.set_k.UseVisualStyleBackColor = true;
            this.set_k.Click += new System.EventHandler(this.set_k_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(3, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 35);
            this.label7.TabIndex = 18;
            this.label7.Text = "Введите значение b";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(3, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 56);
            this.label6.TabIndex = 22;
            this.label6.Text = "Цвет графика";
            // 
            // third_color
            // 
            this.third_color.Dock = System.Windows.Forms.DockStyle.Fill;
            this.third_color.FormattingEnabled = true;
            this.third_color.Location = new System.Drawing.Point(117, 73);
            this.third_color.Name = "third_color";
            this.third_color.Size = new System.Drawing.Size(230, 21);
            this.third_color.TabIndex = 21;
            // 
            // groupBox7
            // 
            this.groupBox7.AutoSize = true;
            this.groupBox7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox7.Controls.Add(this.tableLayoutPanel7);
            this.groupBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox7.Location = new System.Drawing.Point(0, 0);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox7.Size = new System.Drawing.Size(742, 384);
            this.groupBox7.TabIndex = 7;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Параметры графиков";
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.AutoScroll = true;
            this.tableLayoutPanel7.AutoSize = true;
            this.tableLayoutPanel7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel7.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.save, 0, 2);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 3;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(736, 365);
            this.tableLayoutPanel7.TabIndex = 8;
            // 
            // save
            // 
            this.save.AutoSize = true;
            this.save.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.save.Dock = System.Windows.Forms.DockStyle.Fill;
            this.save.Location = new System.Drawing.Point(3, 340);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(730, 22);
            this.save.TabIndex = 7;
            this.save.Text = "сохранить параметры";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 384);
            this.Controls.Add(this.groupBox7);
            this.MinimumSize = new System.Drawing.Size(450, 400);
            this.Name = "InputForm";
            this.Text = "InputForm";
            ((System.ComponentModel.ISupportInitialize)(this.charts_width)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.g)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.a)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.r)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.b)).EndInit();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.k)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ComboBox first_color;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.NumericUpDown charts_width;
    private System.Windows.Forms.CheckBox used_drid;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.GroupBox groupBox3;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.NumericUpDown g;
    private System.Windows.Forms.Button set_g;
    private System.Windows.Forms.GroupBox groupBox4;
    private System.Windows.Forms.Button set_a;
    private System.Windows.Forms.NumericUpDown a;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.ComboBox second_color;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.GroupBox groupBox5;
    private System.Windows.Forms.ComboBox third_color;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Button set_b;
    private System.Windows.Forms.NumericUpDown b;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Button set_k;
    private System.Windows.Forms.NumericUpDown k;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.GroupBox groupBox6;
    private System.Windows.Forms.ComboBox fouth_color;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.Button set_r;
    private System.Windows.Forms.NumericUpDown r;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
    private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
    private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
    private System.Windows.Forms.GroupBox groupBox7;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
    private System.Windows.Forms.Button save;
}
