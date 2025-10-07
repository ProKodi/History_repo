



partial class AppendCompl
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.call = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.fun = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.mode_random_true = new System.Windows.Forms.RadioButton();
            this.mode_random_false = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.x_number = new System.Windows.Forms.TextBox();
            this.y_number = new System.Windows.Forms.TextBox();
            this.number = new System.Windows.Forms.TextBox();
            this.box_input = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.arg = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.modl = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.box_input.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.arg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modl)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.fun, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.ForeColor = System.Drawing.SystemColors.Info;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 254);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(728, 104);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.call);
            this.flowLayoutPanel1.Controls.Add(this.close);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 30);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(172, 71);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // call
            // 
            this.call.AutoSize = true;
            this.call.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.call.Dock = System.Windows.Forms.DockStyle.Fill;
            this.call.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.call.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.call.Location = new System.Drawing.Point(3, 3);
            this.call.Name = "call";
            this.call.Size = new System.Drawing.Size(104, 23);
            this.call.TabIndex = 3;
            this.call.Text = "Вычислить число";
            this.call.UseVisualStyleBackColor = true;
            this.call.Click += new System.EventHandler(this.call_Click);
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.close.Dock = System.Windows.Forms.DockStyle.Fill;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.close.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.close.Location = new System.Drawing.Point(3, 32);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(97, 23);
            this.close.TabIndex = 6;
            this.close.Text = "Закрыть форму";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Выбраное действие:";
            // 
            // fun
            // 
            this.fun.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.fun.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fun.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.fun.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.fun.FormattingEnabled = true;
            this.fun.Items.AddRange(new object[] {
            "Декримент",
            "Инкримент",
            "Деление",
            "Умножение",
            "Не равно",
            "Равно"});
            this.fun.Location = new System.Drawing.Point(181, 3);
            this.fun.Name = "fun";
            this.fun.Size = new System.Drawing.Size(544, 21);
            this.fun.TabIndex = 4;
            this.fun.Tag = "";
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(728, 65);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выберете способ ввода";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.mode_random_true, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.mode_random_false, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(722, 46);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // mode_random_true
            // 
            this.mode_random_true.AutoSize = true;
            this.mode_random_true.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mode_random_true.Location = new System.Drawing.Point(3, 3);
            this.mode_random_true.Name = "mode_random_true";
            this.mode_random_true.Size = new System.Drawing.Size(716, 17);
            this.mode_random_true.TabIndex = 1;
            this.mode_random_true.TabStop = true;
            this.mode_random_true.Text = "Задать случайно";
            this.mode_random_true.UseVisualStyleBackColor = true;
            this.mode_random_true.CheckedChanged += new System.EventHandler(this.mode_random_true_CheckedChanged);
            // 
            // mode_random_false
            // 
            this.mode_random_false.AutoSize = true;
            this.mode_random_false.Checked = true;
            this.mode_random_false.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mode_random_false.Location = new System.Drawing.Point(3, 26);
            this.mode_random_false.Name = "mode_random_false";
            this.mode_random_false.Size = new System.Drawing.Size(716, 17);
            this.mode_random_false.TabIndex = 1;
            this.mode_random_false.TabStop = true;
            this.mode_random_false.Text = "Те что указал пользователь";
            this.mode_random_false.UseVisualStyleBackColor = true;
            this.mode_random_false.CheckedChanged += new System.EventHandler(this.mode_random_false_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.AutoSize = true;
            this.groupBox3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox3.Controls.Add(this.tableLayoutPanel4);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox3.Location = new System.Drawing.Point(3, 151);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(728, 97);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Вывод:";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.AutoSize = true;
            this.tableLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.x_number, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.y_number, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.number, 1, 2);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.Size = new System.Drawing.Size(722, 78);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "Действительная часть:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 26);
            this.label4.TabIndex = 1;
            this.label4.Text = "Мнимая часть:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 26);
            this.label5.TabIndex = 2;
            this.label5.Text = "Общий вид:";
            // 
            // x_number
            // 
            this.x_number.Dock = System.Windows.Forms.DockStyle.Fill;
            this.x_number.Location = new System.Drawing.Point(135, 3);
            this.x_number.Name = "x_number";
            this.x_number.ReadOnly = true;
            this.x_number.Size = new System.Drawing.Size(584, 20);
            this.x_number.TabIndex = 3;
            // 
            // y_number
            // 
            this.y_number.Dock = System.Windows.Forms.DockStyle.Fill;
            this.y_number.Location = new System.Drawing.Point(135, 29);
            this.y_number.Name = "y_number";
            this.y_number.ReadOnly = true;
            this.y_number.Size = new System.Drawing.Size(584, 20);
            this.y_number.TabIndex = 4;
            // 
            // number
            // 
            this.number.Dock = System.Windows.Forms.DockStyle.Fill;
            this.number.Location = new System.Drawing.Point(135, 55);
            this.number.Name = "number";
            this.number.ReadOnly = true;
            this.number.Size = new System.Drawing.Size(584, 20);
            this.number.TabIndex = 5;
            // 
            // box_input
            // 
            this.box_input.AutoSize = true;
            this.box_input.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.box_input.Controls.Add(this.tableLayoutPanel3);
            this.box_input.Dock = System.Windows.Forms.DockStyle.Fill;
            this.box_input.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.box_input.Location = new System.Drawing.Point(3, 74);
            this.box_input.Name = "box_input";
            this.box_input.Size = new System.Drawing.Size(728, 71);
            this.box_input.TabIndex = 5;
            this.box_input.TabStop = false;
            this.box_input.Text = "Введите:";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.arg, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label7, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.modl, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(722, 52);
            this.tableLayoutPanel3.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 26);
            this.label6.TabIndex = 2;
            this.label6.Text = "Модуль числа:";
            // 
            // arg
            // 
            this.arg.AutoSize = true;
            this.arg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.arg.Location = new System.Drawing.Point(99, 29);
            this.arg.Maximum = new decimal(new int[] {
            322767,
            0,
            0,
            0});
            this.arg.Minimum = new decimal(new int[] {
            322768,
            0,
            0,
            -2147483648});
            this.arg.Name = "arg";
            this.arg.Size = new System.Drawing.Size(620, 20);
            this.arg.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(3, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 26);
            this.label7.TabIndex = 3;
            this.label7.Text = "Аргумент числа:";
            // 
            // modl
            // 
            this.modl.AutoSize = true;
            this.modl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.modl.Location = new System.Drawing.Point(99, 3);
            this.modl.Maximum = new decimal(new int[] {
            322767,
            0,
            0,
            0});
            this.modl.Minimum = new decimal(new int[] {
            322768,
            0,
            0,
            -2147483648});
            this.modl.Name = "modl";
            this.modl.Size = new System.Drawing.Size(620, 20);
            this.modl.TabIndex = 4;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.AutoScroll = true;
            this.tableLayoutPanel5.AutoSize = true;
            this.tableLayoutPanel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel1, 0, 3);
            this.tableLayoutPanel5.Controls.Add(this.groupBox3, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.box_input, 0, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 4;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.Size = new System.Drawing.Size(734, 361);
            this.tableLayoutPanel5.TabIndex = 6;
            // 
            // AppendCompl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(734, 361);
            this.Controls.Add(this.tableLayoutPanel5);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(750, 400);
            this.Name = "AppendCompl";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Дополнительный действия для комплексного числа";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.box_input.ResumeLayout(false);
            this.box_input.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.arg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modl)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button call;
    private System.Windows.Forms.ComboBox fun;
    private System.Windows.Forms.Button close;
    private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    private System.Windows.Forms.RadioButton mode_random_true;
    private System.Windows.Forms.RadioButton mode_random_false;
    private System.Windows.Forms.GroupBox groupBox3;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox x_number;
    private System.Windows.Forms.TextBox y_number;
    private System.Windows.Forms.TextBox number;
    private System.Windows.Forms.GroupBox box_input;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.NumericUpDown arg;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.NumericUpDown modl;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
}
