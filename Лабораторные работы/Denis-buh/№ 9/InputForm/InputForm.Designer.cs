



static partial class Input{

partial class InputForm{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing){
        if (disposing && (components != null)){
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent(){
        this.groupBox1 = new System.Windows.Forms.GroupBox();
        this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
        this.label1 = new System.Windows.Forms.Label();
        this.input_data = new System.Windows.Forms.Button();
        this.Name_input = new System.Windows.Forms.TextBox();
        this.Hp_input = new System.Windows.Forms.NumericUpDown();
        this.label2 = new System.Windows.Forms.Label();
        this.label5 = new System.Windows.Forms.Label();
        this.Name_group_input = new System.Windows.Forms.TextBox();
        this.Age_input = new System.Windows.Forms.NumericUpDown();
        this.Number_cout_input = new System.Windows.Forms.NumericUpDown();
        this.label4 = new System.Windows.Forms.Label();
        this.label3 = new System.Windows.Forms.Label();
        this.groupBox1.SuspendLayout();
        this.tableLayoutPanel1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.Hp_input)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.Age_input)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.Number_cout_input)).BeginInit();
        this.SuspendLayout();
        // 
        // groupBox1
        // 
        this.groupBox1.AutoSize = true;
        this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        this.groupBox1.Controls.Add(this.tableLayoutPanel1);
        this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
        this.groupBox1.Location = new System.Drawing.Point(0, 0);
        this.groupBox1.Name = "groupBox1";
        this.groupBox1.Size = new System.Drawing.Size(284, 211);
        this.groupBox1.TabIndex = 0;
        this.groupBox1.TabStop = false;
        this.groupBox1.Text = "Введите данные";
        // 
        // tableLayoutPanel1
        // 
        this.tableLayoutPanel1.AutoScroll = true;
        this.tableLayoutPanel1.AutoSize = true;
        this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        this.tableLayoutPanel1.ColumnCount = 2;
        this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
        this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
        this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
        this.tableLayoutPanel1.Controls.Add(this.input_data, 0, 5);
        this.tableLayoutPanel1.Controls.Add(this.Name_input, 1, 0);
        this.tableLayoutPanel1.Controls.Add(this.Hp_input, 1, 4);
        this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
        this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
        this.tableLayoutPanel1.Controls.Add(this.Name_group_input, 1, 3);
        this.tableLayoutPanel1.Controls.Add(this.Age_input, 1, 1);
        this.tableLayoutPanel1.Controls.Add(this.Number_cout_input, 1, 2);
        this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
        this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
        this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
        this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
        this.tableLayoutPanel1.Name = "tableLayoutPanel1";
        this.tableLayoutPanel1.RowCount = 7;
        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
        this.tableLayoutPanel1.Size = new System.Drawing.Size(278, 192);
        this.tableLayoutPanel1.TabIndex = 12;
        // 
        // label1
        // 
        this.label1.AutoSize = true;
        this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
        this.label1.Location = new System.Drawing.Point(3, 0);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(94, 26);
        this.label1.TabIndex = 1;
        this.label1.Text = "ФИО";
        // 
        // input_data
        // 
        this.input_data.AutoSize = true;
        this.input_data.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        this.input_data.Dock = System.Windows.Forms.DockStyle.Fill;
        this.input_data.Location = new System.Drawing.Point(3, 133);
        this.input_data.Name = "input_data";
        this.input_data.Size = new System.Drawing.Size(94, 23);
        this.input_data.TabIndex = 11;
        this.input_data.Text = "Ввести данные";
        this.input_data.UseVisualStyleBackColor = true;
        this.input_data.Click += new System.EventHandler(this.input_data_Click);
        // 
        // Name_input
        // 
        this.Name_input.Dock = System.Windows.Forms.DockStyle.Fill;
        this.Name_input.Location = new System.Drawing.Point(103, 3);
        this.Name_input.Name = "Name_input";
        this.Name_input.Size = new System.Drawing.Size(172, 20);
        this.Name_input.TabIndex = 2;
        // 
        // Hp_input
        // 
        this.Hp_input.AutoSize = true;
        this.Hp_input.Dock = System.Windows.Forms.DockStyle.Fill;
        this.Hp_input.Location = new System.Drawing.Point(103, 107);
        this.Hp_input.Name = "Hp_input";
        this.Hp_input.Size = new System.Drawing.Size(172, 20);
        this.Hp_input.TabIndex = 10;
        // 
        // label2
        // 
        this.label2.AutoSize = true;
        this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
        this.label2.Location = new System.Drawing.Point(3, 26);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(94, 26);
        this.label2.TabIndex = 3;
        this.label2.Text = "Количество лет";
        // 
        // label5
        // 
        this.label5.AutoSize = true;
        this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
        this.label5.Location = new System.Drawing.Point(3, 104);
        this.label5.Name = "label5";
        this.label5.Size = new System.Drawing.Size(94, 26);
        this.label5.TabIndex = 6;
        this.label5.Text = "Процент hp";
        // 
        // Name_group_input
        // 
        this.Name_group_input.Dock = System.Windows.Forms.DockStyle.Fill;
        this.Name_group_input.Location = new System.Drawing.Point(103, 81);
        this.Name_group_input.Name = "Name_group_input";
        this.Name_group_input.Size = new System.Drawing.Size(172, 20);
        this.Name_group_input.TabIndex = 9;
        // 
        // Age_input
        // 
        this.Age_input.AutoSize = true;
        this.Age_input.Dock = System.Windows.Forms.DockStyle.Fill;
        this.Age_input.Location = new System.Drawing.Point(103, 29);
        this.Age_input.Maximum = new decimal(new int[] {
        200,
        0,
        0,
        0});
        this.Age_input.Minimum = new decimal(new int[] {
        1,
        0,
        0,
        0});
        this.Age_input.Name = "Age_input";
        this.Age_input.Size = new System.Drawing.Size(172, 20);
        this.Age_input.TabIndex = 7;
        this.Age_input.Value = new decimal(new int[] {
        1,
        0,
        0,
        0});
        // 
        // Number_cout_input
        // 
        this.Number_cout_input.AutoSize = true;
        this.Number_cout_input.Dock = System.Windows.Forms.DockStyle.Fill;
        this.Number_cout_input.Location = new System.Drawing.Point(103, 55);
        this.Number_cout_input.Maximum = new decimal(new int[] {
        20,
        0,
        0,
        0});
        this.Number_cout_input.Minimum = new decimal(new int[] {
        1,
        0,
        0,
        0});
        this.Number_cout_input.Name = "Number_cout_input";
        this.Number_cout_input.Size = new System.Drawing.Size(172, 20);
        this.Number_cout_input.TabIndex = 8;
        this.Number_cout_input.Value = new decimal(new int[] {
        1,
        0,
        0,
        0});
        // 
        // label4
        // 
        this.label4.AutoSize = true;
        this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
        this.label4.Location = new System.Drawing.Point(3, 78);
        this.label4.Name = "label4";
        this.label4.Size = new System.Drawing.Size(94, 26);
        this.label4.TabIndex = 5;
        this.label4.Text = "Номер группы";
        // 
        // label3
        // 
        this.label3.AutoSize = true;
        this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
        this.label3.Location = new System.Drawing.Point(3, 52);
        this.label3.Name = "label3";
        this.label3.Size = new System.Drawing.Size(94, 26);
        this.label3.TabIndex = 4;
        this.label3.Text = "Номер курса";
        // 
        // InputForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(284, 211);
        this.Controls.Add(this.groupBox1);
        this.MinimumSize = new System.Drawing.Size(300, 250);
        this.Name = "InputForm";
        this.Text = "InputForm";
        this.groupBox1.ResumeLayout(false);
        this.groupBox1.PerformLayout();
        this.tableLayoutPanel1.ResumeLayout(false);
        this.tableLayoutPanel1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)(this.Hp_input)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.Age_input)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.Number_cout_input)).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox Name_input;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.NumericUpDown Age_input;
    private System.Windows.Forms.NumericUpDown Number_cout_input;
    private System.Windows.Forms.TextBox Name_group_input;
    private System.Windows.Forms.NumericUpDown Hp_input;
    private System.Windows.Forms.Button input_data;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
}


}