partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        label1 = new Label();
        label2 = new Label();
        label3 = new Label();
        label4 = new Label();
        label5 = new Label();
        label6 = new Label();
        label7 = new Label();
        number = new TextBox();
        x_number = new TextBox();
        y_number = new TextBox();
        to_calculate = new Button();
        modl = new TextBox();
        org = new TextBox();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(12, 81);
        label1.Name = "label1";
        label1.Size = new Size(99, 15);
        label1.TabIndex = 1;
        label1.Text = "Аргумент числа:";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(12, 42);
        label2.Name = "label2";
        label2.Size = new Size(89, 15);
        label2.TabIndex = 2;
        label2.Text = "Модуль числа:";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(12, 9);
        label3.Name = "label3";
        label3.Size = new Size(53, 15);
        label3.TabIndex = 4;
        label3.Text = "Введите:";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(12, 118);
        label4.Name = "label4";
        label4.Size = new Size(45, 15);
        label4.TabIndex = 5;
        label4.Text = "Вывод:";
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(12, 147);
        label5.Name = "label5";
        label5.Size = new Size(131, 15);
        label5.TabIndex = 7;
        label5.Text = "Действительная часть:";
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Location = new Point(12, 183);
        label6.Name = "label6";
        label6.Size = new Size(89, 15);
        label6.TabIndex = 8;
        label6.Text = "Мнимая часть:";
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.Location = new Point(12, 223);
        label7.Name = "label7";
        label7.Size = new Size(73, 15);
        label7.TabIndex = 10;
        label7.Text = "Общий вид:";
        // 
        // number
        // 
        number.Location = new Point(149, 223);
        number.Name = "number";
        number.ReadOnly = true;
        number.Size = new Size(120, 23);
        number.TabIndex = 11;
        // 
        // x_number
        // 
        x_number.Location = new Point(149, 147);
        x_number.Name = "x_number";
        x_number.ReadOnly = true;
        x_number.Size = new Size(120, 23);
        x_number.TabIndex = 12;
        // 
        // y_number
        // 
        y_number.Location = new Point(149, 183);
        y_number.Name = "y_number";
        y_number.ReadOnly = true;
        y_number.Size = new Size(120, 23);
        y_number.TabIndex = 13;
        // 
        // to_calculate
        // 
        to_calculate.Location = new Point(12, 257);
        to_calculate.Name = "to_calculate";
        to_calculate.Size = new Size(131, 23);
        to_calculate.TabIndex = 14;
        to_calculate.Text = "Вычеслить число";
        to_calculate.UseVisualStyleBackColor = true;
        to_calculate.Click += to_calculate_Click;
        // 
        // modl
        // 
        modl.Location = new Point(114, 42);
        modl.Name = "modl";
        modl.Size = new Size(120, 23);
        modl.TabIndex = 15;
        modl.Text = "0";
        // 
        // org
        // 
        org.Location = new Point(114, 81);
        org.Name = "org";
        org.Size = new Size(120, 23);
        org.TabIndex = 16;
        org.Text = "0";
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(484, 311);
        Controls.Add(org);
        Controls.Add(modl);
        Controls.Add(to_calculate);
        Controls.Add(y_number);
        Controls.Add(x_number);
        Controls.Add(number);
        Controls.Add(label7);
        Controls.Add(label6);
        Controls.Add(label5);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        MinimumSize = new Size(500, 350);
        Name = "Form1";
        Text = "Буханов Д.Е. группа 3105об. Вариант 12";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private Label label1;
    private Label label2;
    private Label label3;
    private Label label4;
    private Label label5;
    private Label label6;
    private Label label7;
    private TextBox number;
    private TextBox x_number;
    private TextBox y_number;
    private Button to_calculate;
    private TextBox modl;
    private TextBox org;
}
