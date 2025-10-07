
    


partial class MainWindow{
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
            this.calculate = new System.Windows.Forms.Button();
            this.calculate_new = new System.Windows.Forms.Button();
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
            this.label1 = new System.Windows.Forms.Label();
            this.arg = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.modl = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.box_input.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.arg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modl)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.box_input, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(484, 261);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.calculate);
            this.flowLayoutPanel1.Controls.Add(this.calculate_new);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 183);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(478, 75);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // calculate
            // 
            this.calculate.AutoSize = true;
            this.calculate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.calculate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calculate.Location = new System.Drawing.Point(3, 3);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(181, 23);
            this.calculate.TabIndex = 2;
            this.calculate.Text = "Вычеслить обыкновенное число";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // calculate_new
            // 
            this.calculate_new.AutoSize = true;
            this.calculate_new.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.calculate_new.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calculate_new.Location = new System.Drawing.Point(190, 3);
            this.calculate_new.Name = "calculate_new";
            this.calculate_new.Size = new System.Drawing.Size(120, 23);
            this.calculate_new.TabIndex = 3;
            this.calculate_new.Text = "Производный класс";
            this.calculate_new.UseVisualStyleBackColor = true;
            this.calculate_new.Click += new System.EventHandler(this.calculate_new_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.AutoSize = true;
            this.groupBox3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox3.Controls.Add(this.tableLayoutPanel4);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 80);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(478, 97);
            this.groupBox3.TabIndex = 1;
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
            this.tableLayoutPanel4.Size = new System.Drawing.Size(472, 78);
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
            this.x_number.Size = new System.Drawing.Size(334, 20);
            this.x_number.TabIndex = 3;
            // 
            // y_number
            // 
            this.y_number.Dock = System.Windows.Forms.DockStyle.Fill;
            this.y_number.Location = new System.Drawing.Point(135, 29);
            this.y_number.Name = "y_number";
            this.y_number.ReadOnly = true;
            this.y_number.Size = new System.Drawing.Size(334, 20);
            this.y_number.TabIndex = 4;
            // 
            // number
            // 
            this.number.Dock = System.Windows.Forms.DockStyle.Fill;
            this.number.Location = new System.Drawing.Point(135, 55);
            this.number.Name = "number";
            this.number.ReadOnly = true;
            this.number.Size = new System.Drawing.Size(334, 20);
            this.number.TabIndex = 5;
            // 
            // box_input
            // 
            this.box_input.AutoSize = true;
            this.box_input.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.box_input.Controls.Add(this.tableLayoutPanel3);
            this.box_input.Dock = System.Windows.Forms.DockStyle.Fill;
            this.box_input.Location = new System.Drawing.Point(3, 3);
            this.box_input.Name = "box_input";
            this.box_input.Size = new System.Drawing.Size(478, 71);
            this.box_input.TabIndex = 1;
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
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.arg, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.modl, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(472, 52);
            this.tableLayoutPanel3.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Модуль числа:";
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
            this.arg.Size = new System.Drawing.Size(370, 20);
            this.arg.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Аргумент числа:";
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
            this.modl.Size = new System.Drawing.Size(370, 20);
            this.modl.TabIndex = 4;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(500, 300);
            this.Name = "MainWindow";
            this.Text = "Буханов Д.Е. группа 3105об. Вариант 12";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
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
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.GroupBox box_input;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.NumericUpDown arg;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.NumericUpDown modl;
    private System.Windows.Forms.GroupBox groupBox3;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox x_number;
    private System.Windows.Forms.TextBox y_number;
    private System.Windows.Forms.TextBox number;
    private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    private System.Windows.Forms.Button calculate;
    private System.Windows.Forms.Button calculate_new;
}
