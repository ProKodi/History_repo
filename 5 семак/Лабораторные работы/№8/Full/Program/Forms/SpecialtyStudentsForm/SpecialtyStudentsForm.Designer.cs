
partial class SpecialtyStudentsForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing){
        if (disposing && (components != null)){ components.Dispose(); }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        dataGridView1 = new DataGridView();
        StudentIdent = new DataGridViewTextBoxColumn();
        SexColumn = new DataGridViewTextBoxColumn();
        ParentsColumn = new DataGridViewTextBoxColumn();
        AddressStudent = new DataGridViewTextBoxColumn();
        PhoneNumberStudent = new DataGridViewTextBoxColumn();
        PassportDataStudent = new DataGridViewTextBoxColumn();
        GroupStudent = new DataGridViewTextBoxColumn();
        BirthdayStudent = new DataGridViewTextBoxColumn();
        DateRecieptColumn = new DataGridViewTextBoxColumn();
        IsFullTimeColumn = new DataGridViewCheckBoxColumn();
        NumberRecordColumn = new DataGridViewTextBoxColumn();
        CourseNumberColumn = new DataGridViewTextBoxColumn();
        LeftScrollButton = new Button();
        RightScrollButton = new Button();
        textBox1 = new TextBox();
        textBox2 = new TextBox();
        label1 = new Label();
        label2 = new Label();
        label3 = new Label();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        SuspendLayout();
        // 
        // dataGridView1
        // 
        dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView1.Columns.AddRange(new DataGridViewColumn[] { StudentIdent, SexColumn, ParentsColumn, AddressStudent, PhoneNumberStudent, PassportDataStudent, GroupStudent, BirthdayStudent, DateRecieptColumn, IsFullTimeColumn, NumberRecordColumn, CourseNumberColumn });
        dataGridView1.Location = new Point(10, 80);
        dataGridView1.Margin = new Padding(4, 3, 4, 3);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.Size = new Size(600, 200);
        dataGridView1.TabIndex = 0;
        // 
        // StudentIdent
        // 
        StudentIdent.HeaderText = "ФИО студента";
        StudentIdent.Name = "StudentIdent";
        StudentIdent.ReadOnly = true;
        // 
        // SexColumn
        // 
        SexColumn.HeaderText = "Пол студента";
        SexColumn.Name = "SexColumn";
        SexColumn.ReadOnly = true;
        // 
        // ParentsColumn
        // 
        ParentsColumn.HeaderText = "Родители студента";
        ParentsColumn.Name = "ParentsColumn";
        ParentsColumn.ReadOnly = true;
        // 
        // AddressStudent
        // 
        AddressStudent.HeaderText = "Адрес проживания студента";
        AddressStudent.Name = "AddressStudent";
        AddressStudent.ReadOnly = true;
        // 
        // PhoneNumberStudent
        // 
        PhoneNumberStudent.HeaderText = "Телефон студента";
        PhoneNumberStudent.Name = "PhoneNumberStudent";
        PhoneNumberStudent.ReadOnly = true;
        // 
        // PassportDataStudent
        // 
        PassportDataStudent.HeaderText = "Паспортные данные студента";
        PassportDataStudent.Name = "PassportDataStudent";
        PassportDataStudent.ReadOnly = true;
        // 
        // GroupStudent
        // 
        GroupStudent.HeaderText = "Группа студента";
        GroupStudent.Name = "GroupStudent";
        GroupStudent.ReadOnly = true;
        // 
        // BirthdayStudent
        // 
        BirthdayStudent.HeaderText = "День рождения студента";
        BirthdayStudent.Name = "BirthdayStudent";
        BirthdayStudent.ReadOnly = true;
        // 
        // DateRecieptColumn
        // 
        DateRecieptColumn.HeaderText = "Дата поступления";
        DateRecieptColumn.Name = "DateRecieptColumn";
        DateRecieptColumn.ReadOnly = true;
        // 
        // IsFullTimeColumn
        // 
        IsFullTimeColumn.HeaderText = "Очное обучение?";
        IsFullTimeColumn.Name = "IsFullTimeColumn";
        IsFullTimeColumn.ReadOnly = true;
        IsFullTimeColumn.Resizable = DataGridViewTriState.True;
        IsFullTimeColumn.SortMode = DataGridViewColumnSortMode.Automatic;
        // 
        // NumberRecordColumn
        // 
        NumberRecordColumn.HeaderText = "Номер зачётной книжки";
        NumberRecordColumn.Name = "NumberRecordColumn";
        NumberRecordColumn.ReadOnly = true;
        // 
        // CourseNumberColumn
        // 
        CourseNumberColumn.HeaderText = "Номер курса";
        CourseNumberColumn.Name = "CourseNumberColumn";
        CourseNumberColumn.ReadOnly = true;
        // 
        // LeftScrollButton
        // 
        LeftScrollButton.FlatAppearance.BorderSize = 0;
        LeftScrollButton.FlatStyle = FlatStyle.Flat;
        LeftScrollButton.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold | FontStyle.Italic);
        LeftScrollButton.Location = new Point(10, 286);
        LeftScrollButton.Margin = new Padding(4, 3, 4, 3);
        LeftScrollButton.Name = "LeftScrollButton";
        LeftScrollButton.Size = new Size(36, 25);
        LeftScrollButton.TabIndex = 1;
        LeftScrollButton.Text = "<";
        LeftScrollButton.UseVisualStyleBackColor = true;
        LeftScrollButton.Click += LeftScrollButton_Click;
        // 
        // RightScrollButton
        // 
        RightScrollButton.FlatAppearance.BorderSize = 0;
        RightScrollButton.FlatStyle = FlatStyle.Flat;
        RightScrollButton.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold | FontStyle.Italic);
        RightScrollButton.Location = new Point(574, 286);
        RightScrollButton.Margin = new Padding(4, 3, 4, 3);
        RightScrollButton.Name = "RightScrollButton";
        RightScrollButton.Size = new Size(36, 25);
        RightScrollButton.TabIndex = 2;
        RightScrollButton.Text = ">";
        RightScrollButton.UseVisualStyleBackColor = true;
        RightScrollButton.Click += RightScrollButton_Click;
        // 
        // textBox1
        // 
        textBox1.BackColor = SystemColors.ControlDarkDark;
        textBox1.Location = new Point(117, 49);
        textBox1.Margin = new Padding(4, 3, 4, 3);
        textBox1.Name = "textBox1";
        textBox1.ReadOnly = true;
        textBox1.Size = new Size(114, 25);
        textBox1.TabIndex = 3;
        // 
        // textBox2
        // 
        textBox2.BackColor = SystemColors.ControlDarkDark;
        textBox2.Location = new Point(357, 49);
        textBox2.Margin = new Padding(4, 3, 4, 3);
        textBox2.Name = "textBox2";
        textBox2.ReadOnly = true;
        textBox2.Size = new Size(253, 25);
        textBox2.TabIndex = 4;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(14, 10);
        label1.Margin = new Padding(4, 0, 4, 0);
        label1.Name = "label1";
        label1.Size = new Size(105, 17);
        label1.TabIndex = 5;
        label1.Text = "Специальности";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(14, 52);
        label2.Margin = new Padding(4, 0, 4, 0);
        label2.Name = "label2";
        label2.Size = new Size(104, 17);
        label2.TabIndex = 6;
        label2.Text = "Наименование";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(279, 52);
        label3.Margin = new Padding(4, 0, 4, 0);
        label3.Name = "label3";
        label3.Size = new Size(70, 17);
        label3.TabIndex = 7;
        label3.Text = "Описание";
        // 
        // SpecialtyStudentsForm
        // 
        AutoScaleDimensions = new SizeF(8F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.ControlDarkDark;
        ClientSize = new Size(618, 323);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(textBox2);
        Controls.Add(textBox1);
        Controls.Add(RightScrollButton);
        Controls.Add(LeftScrollButton);
        Controls.Add(dataGridView1);
        Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);

        Margin = new Padding(4, 3, 4, 3);
        Name = "SpecialtyStudentsForm";
        Opacity = 0.97D;
        Text = "SpecialtyStudentsForm";
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private DataGridView dataGridView1;
    private Button LeftScrollButton;
    private Button RightScrollButton;
    private TextBox textBox1;
    private TextBox textBox2;
    private Label label1;
    private Label label2;
    private Label label3;
    private DataGridViewTextBoxColumn StudentIdent;
    private DataGridViewTextBoxColumn SexColumn;
    private DataGridViewTextBoxColumn ParentsColumn;
    private DataGridViewTextBoxColumn AddressStudent;
    private DataGridViewTextBoxColumn PhoneNumberStudent;
    private DataGridViewTextBoxColumn PassportDataStudent;
    private DataGridViewTextBoxColumn GroupStudent;
    private DataGridViewTextBoxColumn BirthdayStudent;
    private DataGridViewTextBoxColumn DateRecieptColumn;
    private DataGridViewCheckBoxColumn IsFullTimeColumn;
    private DataGridViewTextBoxColumn NumberRecordColumn;
    private DataGridViewTextBoxColumn CourseNumberColumn;
}
