



partial class StudentExamsForm
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
        StudentIdent = new DataGridViewTextBoxColumn();
        SexColumn = new DataGridViewTextBoxColumn();
        ParentsColumn = new DataGridViewTextBoxColumn();


        label1 = new Label();
        label2 = new Label();
        textBox1 = new TextBox();
        RightScrollButton = new Button();
        LeftScrollButton = new Button();
        dataGridView1 = new DataGridView();
        label3 = new Label();
        textBox2 = new TextBox();
        textBox3 = new TextBox();
        label4 = new Label();
        textBox4 = new TextBox();
        label5 = new Label();
        textBox5 = new TextBox();
        label6 = new Label();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(12, 9);
        label1.Name = "label1";
        label1.Size = new Size(130, 17);
        label1.TabIndex = 0;
        label1.Text = "Экзамены студента";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(13, 33);
        label2.Margin = new Padding(4, 0, 4, 0);
        label2.Name = "label2";
        label2.Size = new Size(97, 17);
        label2.TabIndex = 13;
        label2.Text = "ФИО студента";
        // 
        // textBox1
        // 
        textBox1.BackColor = SystemColors.ControlDarkDark;
        textBox1.Location = new Point(116, 30);
        textBox1.Margin = new Padding(4, 3, 4, 3);
        textBox1.Name = "textBox1";
        textBox1.ReadOnly = true;
        textBox1.Size = new Size(493, 25);
        textBox1.TabIndex = 11;
        // 
        // RightScrollButton
        // 
        RightScrollButton.FlatAppearance.BorderSize = 0;
        RightScrollButton.FlatStyle = FlatStyle.Flat;
        RightScrollButton.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold | FontStyle.Italic);
        RightScrollButton.Location = new Point(558, 391);
        RightScrollButton.Margin = new Padding(4, 3, 4, 3);
        RightScrollButton.Name = "RightScrollButton";
        RightScrollButton.Size = new Size(55, 34);
        RightScrollButton.TabIndex = 10;
        RightScrollButton.Text = ">";
        RightScrollButton.UseVisualStyleBackColor = true;
        RightScrollButton.Click += RightScrollButton_Click;
        // 
        // LeftScrollButton
        // 
        LeftScrollButton.FlatAppearance.BorderSize = 0;
        LeftScrollButton.FlatStyle = FlatStyle.Flat;
        LeftScrollButton.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold | FontStyle.Italic);
        LeftScrollButton.Location = new Point(9, 391);
        LeftScrollButton.Margin = new Padding(4, 3, 4, 3);
        LeftScrollButton.Name = "LeftScrollButton";
        LeftScrollButton.Size = new Size(55, 34);
        LeftScrollButton.TabIndex = 9;
        LeftScrollButton.Text = "<";
        LeftScrollButton.UseVisualStyleBackColor = true;
        LeftScrollButton.Click += LeftScrollButton_Click;
        // 
        // dataGridView1
        // 
        dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView1.Columns.AddRange(new DataGridViewColumn[] { StudentIdent, SexColumn, ParentsColumn});
        dataGridView1.Location = new Point(9, 185);
        dataGridView1.Margin = new Padding(4, 3, 4, 3);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.Size = new Size(600, 200);
        dataGridView1.TabIndex = 8;
        // 
        // StudentIdent
        // 
        StudentIdent.HeaderText = "Код дисциплины";
        StudentIdent.Name = "StudentIdent";
        StudentIdent.ReadOnly = true;
        // 
        // SexColumn
        // 
        SexColumn.HeaderText = "Дата экзамена";
        SexColumn.Name = "SexColumn";
        SexColumn.ReadOnly = true;
        // 
        // ParentsColumn
        // 
        ParentsColumn.HeaderText = "Оценка";
        ParentsColumn.Name = "ParentsColumn";
        ParentsColumn.ReadOnly = true;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(12, 66);
        label3.Margin = new Padding(4, 0, 4, 0);
        label3.Name = "label3";
        label3.Size = new Size(34, 17);
        label3.TabIndex = 14;
        label3.Text = "Пол";
        // 
        // textBox2
        // 
        textBox2.BackColor = SystemColors.ControlDarkDark;
        textBox2.Location = new Point(116, 63);
        textBox2.Margin = new Padding(4, 3, 4, 3);
        textBox2.Name = "textBox2";
        textBox2.ReadOnly = true;
        textBox2.Size = new Size(190, 25);
        textBox2.TabIndex = 15;
        // 
        // textBox3
        // 
        textBox3.BackColor = SystemColors.ControlDarkDark;
        textBox3.Location = new Point(116, 92);
        textBox3.Margin = new Padding(4, 3, 4, 3);
        textBox3.Name = "textBox3";
        textBox3.ReadOnly = true;
        textBox3.Size = new Size(190, 25);
        textBox3.TabIndex = 17;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(12, 95);
        label4.Margin = new Padding(4, 0, 4, 0);
        label4.Name = "label4";
        label4.Size = new Size(61, 17);
        label4.TabIndex = 16;
        label4.Text = "Паспорт";
        // 
        // textBox4
        // 
        textBox4.BackColor = SystemColors.ControlDarkDark;
        textBox4.Location = new Point(116, 123);
        textBox4.Margin = new Padding(4, 3, 4, 3);
        textBox4.Name = "textBox4";
        textBox4.ReadOnly = true;
        textBox4.Size = new Size(190, 25);
        textBox4.TabIndex = 19;
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(12, 126);
        label5.Margin = new Padding(4, 0, 4, 0);
        label5.Name = "label5";
        label5.Size = new Size(52, 17);
        label5.TabIndex = 18;
        label5.Text = "Группа";
        // 
        // textBox5
        // 
        textBox5.BackColor = SystemColors.ControlDarkDark;
        textBox5.Location = new Point(116, 154);
        textBox5.Margin = new Padding(4, 3, 4, 3);
        textBox5.Name = "textBox5";
        textBox5.ReadOnly = true;
        textBox5.Size = new Size(190, 25);
        textBox5.TabIndex = 21;
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Location = new Point(12, 157);
        label6.Margin = new Padding(4, 0, 4, 0);
        label6.Name = "label6";
        label6.Size = new Size(107, 17);
        label6.TabIndex = 20;
        label6.Text = "Дата рождения";
        // 
        // StudentExamsForm
        // 
        AutoScaleDimensions = new SizeF(8F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.ControlDarkDark;
        ClientSize = new Size(618, 428);
        Controls.Add(textBox5);
        Controls.Add(label6);
        Controls.Add(textBox4);
        Controls.Add(label5);
        Controls.Add(textBox3);
        Controls.Add(label4);
        Controls.Add(textBox2);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(textBox1);
        Controls.Add(RightScrollButton);
        Controls.Add(LeftScrollButton);
        Controls.Add(dataGridView1);
        Controls.Add(label1);
        Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        Name = "StudentExamsForm";
        Opacity = 0.97D;
        Text = "StudentExams";
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private Label label2;
    private TextBox textBox1;
    private Button RightScrollButton;
    private Button LeftScrollButton;
    private DataGridView dataGridView1;
    private Label label3;
    private TextBox textBox2;
    private TextBox textBox3;
    private Label label4;
    private TextBox textBox4;
    private Label label5;
    private TextBox textBox5;
    private Label label6;
    private DataGridViewTextBoxColumn StudentIdent;
    private DataGridViewTextBoxColumn SexColumn;
    private DataGridViewTextBoxColumn ParentsColumn;
}
