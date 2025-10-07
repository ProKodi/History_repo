



partial class GetNumber
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
            this.box_input_mode = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.mode_random_true = new System.Windows.Forms.RadioButton();
            this.mode_ramdom_false = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.modl = new System.Windows.Forms.NumericUpDown();
            this.arg = new System.Windows.Forms.NumericUpDown();
            this.set_number = new System.Windows.Forms.Button();
            this.delete_number = new System.Windows.Forms.Button();
            this.set_box = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.box_input_mode.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arg)).BeginInit();
            this.set_box.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // box_input_mode
            // 
            this.box_input_mode.AutoSize = true;
            this.box_input_mode.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.box_input_mode.Controls.Add(this.flowLayoutPanel1);
            this.box_input_mode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.box_input_mode.Location = new System.Drawing.Point(3, 3);
            this.box_input_mode.Name = "box_input_mode";
            this.box_input_mode.Size = new System.Drawing.Size(645, 42);
            this.box_input_mode.TabIndex = 0;
            this.box_input_mode.TabStop = false;
            this.box_input_mode.Text = "Способ ввода";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.mode_random_true);
            this.flowLayoutPanel1.Controls.Add(this.mode_ramdom_false);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(639, 23);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // mode_random_true
            // 
            this.mode_random_true.AutoSize = true;
            this.mode_random_true.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mode_random_true.Location = new System.Drawing.Point(3, 3);
            this.mode_random_true.Name = "mode_random_true";
            this.mode_random_true.Size = new System.Drawing.Size(110, 17);
            this.mode_random_true.TabIndex = 2;
            this.mode_random_true.Text = "Задать случайно";
            this.mode_random_true.UseVisualStyleBackColor = true;
            this.mode_random_true.CheckedChanged += new System.EventHandler(this.mode_random_true_CheckedChanged);
            // 
            // mode_ramdom_false
            // 
            this.mode_ramdom_false.AutoSize = true;
            this.mode_ramdom_false.Checked = true;
            this.mode_ramdom_false.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mode_ramdom_false.Location = new System.Drawing.Point(119, 3);
            this.mode_ramdom_false.Name = "mode_ramdom_false";
            this.mode_ramdom_false.Size = new System.Drawing.Size(169, 17);
            this.mode_ramdom_false.TabIndex = 3;
            this.mode_ramdom_false.TabStop = true;
            this.mode_ramdom_false.Text = "То что указал пользователь";
            this.mode_ramdom_false.UseVisualStyleBackColor = true;
            this.mode_ramdom_false.CheckedChanged += new System.EventHandler(this.mode_ramdom_false_CheckedChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.modl, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.arg, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(639, 52);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Аргумент числа";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Модуль числа";
            // 
            // modl
            // 
            this.modl.AutoSize = true;
            this.modl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.modl.Location = new System.Drawing.Point(96, 3);
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
            this.modl.Size = new System.Drawing.Size(540, 20);
            this.modl.TabIndex = 4;
            // 
            // arg
            // 
            this.arg.AutoSize = true;
            this.arg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.arg.Location = new System.Drawing.Point(96, 29);
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
            this.arg.Size = new System.Drawing.Size(540, 20);
            this.arg.TabIndex = 5;
            // 
            // set_number
            // 
            this.set_number.AutoSize = true;
            this.set_number.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.set_number.Dock = System.Windows.Forms.DockStyle.Fill;
            this.set_number.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.set_number.Location = new System.Drawing.Point(3, 3);
            this.set_number.Name = "set_number";
            this.set_number.Size = new System.Drawing.Size(316, 25);
            this.set_number.TabIndex = 2;
            this.set_number.Text = "Задать число";
            this.set_number.UseVisualStyleBackColor = true;
            this.set_number.Click += new System.EventHandler(this.set_number_Click);
            // 
            // delete_number
            // 
            this.delete_number.AutoSize = true;
            this.delete_number.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.delete_number.Dock = System.Windows.Forms.DockStyle.Fill;
            this.delete_number.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.delete_number.Location = new System.Drawing.Point(325, 3);
            this.delete_number.Name = "delete_number";
            this.delete_number.Size = new System.Drawing.Size(317, 25);
            this.delete_number.TabIndex = 3;
            this.delete_number.Text = "Закрыть форму";
            this.delete_number.UseVisualStyleBackColor = true;
            this.delete_number.Click += new System.EventHandler(this.delete_number_Click);
            // 
            // set_box
            // 
            this.set_box.AutoSize = true;
            this.set_box.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.set_box.Controls.Add(this.tableLayoutPanel1);
            this.set_box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.set_box.Location = new System.Drawing.Point(3, 51);
            this.set_box.Name = "set_box";
            this.set_box.Size = new System.Drawing.Size(645, 71);
            this.set_box.TabIndex = 4;
            this.set_box.TabStop = false;
            this.set_box.Text = "Введите";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.set_number, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.delete_number, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 128);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(645, 31);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this.box_input_mode, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.set_box, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(651, 162);
            this.tableLayoutPanel3.TabIndex = 6;
            // 
            // GetNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(651, 162);
            this.Controls.Add(this.tableLayoutPanel3);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 200);
            this.Name = "GetNumber";
            this.Text = "Ввод числа";
            this.box_input_mode.ResumeLayout(false);
            this.box_input_mode.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arg)).EndInit();
            this.set_box.ResumeLayout(false);
            this.set_box.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }
    #endregion
    private System.Windows.Forms.GroupBox box_input_mode;
    private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    private System.Windows.Forms.RadioButton mode_random_true;
    private System.Windows.Forms.RadioButton mode_ramdom_false;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.NumericUpDown modl;
    private System.Windows.Forms.NumericUpDown arg;
    private System.Windows.Forms.Button set_number;
    private System.Windows.Forms.Button delete_number;
    private System.Windows.Forms.GroupBox set_box;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
}
