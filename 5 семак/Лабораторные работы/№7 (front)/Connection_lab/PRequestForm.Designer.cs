namespace Connection_lab
{
    partial class PRequestForm
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
            InputBox = new TextBox();
            EditingData = new Button();
            DataGrid = new DataGridView();
            StudentIdent = new DataGridViewTextBoxColumn();
            SexColumn = new DataGridViewTextBoxColumn();
            ParentsColumn = new DataGridViewTextBoxColumn();
            AddressStudent = new DataGridViewTextBoxColumn();
            PhoneNumberStudent = new DataGridViewTextBoxColumn();
            PassportDataStudent = new DataGridViewTextBoxColumn();
            GroupStudent = new DataGridViewTextBoxColumn();
            BirthdayStudent = new DataGridViewTextBoxColumn();
            DateRecieptColumn = new DataGridViewTextBoxColumn();
            IsFullTimeColumn = new DataGridViewTextBoxColumn();
            NumberRecordColumn = new DataGridViewTextBoxColumn();
            CourseNumberColumn = new DataGridViewTextBoxColumn();
            NameSpecialty = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)DataGrid).BeginInit();
            SuspendLayout();
            // 
            // InputBox
            // 
            InputBox.BackColor = SystemColors.ControlDarkDark;
            InputBox.Font = new Font("Segoe UI", 18F);
            InputBox.ForeColor = SystemColors.Control;
            InputBox.Location = new Point(636, 46);
            InputBox.MaxLength = 1;
            InputBox.Name = "InputBox";
            InputBox.Size = new Size(114, 39);
            InputBox.TabIndex = 1;
            InputBox.Text = "П";
            // 
            // EditingData
            // 
            EditingData.FlatAppearance.BorderSize = 0;
            EditingData.FlatStyle = FlatStyle.Flat;
            EditingData.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            EditingData.ForeColor = SystemColors.Control;
            EditingData.Location = new Point(12, 12);
            EditingData.Name = "EditingData";
            EditingData.Size = new Size(618, 106);
            EditingData.TabIndex = 2;
            EditingData.Text = "Введите начальную букву для поиска фамилий:";
            EditingData.UseVisualStyleBackColor = true;
            EditingData.Click += EditingData_Click;
            // 
            // DataGrid
            // 
            DataGrid.BorderStyle = BorderStyle.None;
            DataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGrid.Columns.AddRange(new DataGridViewColumn[] { StudentIdent, SexColumn, ParentsColumn, AddressStudent, PhoneNumberStudent, PassportDataStudent, GroupStudent, BirthdayStudent, DateRecieptColumn, IsFullTimeColumn, NumberRecordColumn, CourseNumberColumn, NameSpecialty });
            DataGrid.Location = new Point(12, 124);
            DataGrid.Name = "DataGrid";
            DataGrid.ReadOnly = true;
            DataGrid.Size = new Size(738, 314);
            DataGrid.TabIndex = 3;
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
            // NameSpecialty
            // 
            NameSpecialty.HeaderText = "Название специальности";
            NameSpecialty.Name = "NameSpecialty";
            NameSpecialty.ReadOnly = true;
            // 
            // PRequestForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(771, 450);
            Controls.Add(DataGrid);
            Controls.Add(EditingData);
            Controls.Add(InputBox);
            Name = "PRequestForm";
            Opacity = 0.95D;
            Text = "PRequestForm";
            ((System.ComponentModel.ISupportInitialize)DataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox InputBox;
        private Button EditingData;
        private DataGridView DataGrid;
        private DataGridViewTextBoxColumn StudentIdent;
        private DataGridViewTextBoxColumn SexColumn;
        private DataGridViewTextBoxColumn ParentsColumn;
        private DataGridViewTextBoxColumn AddressStudent;
        private DataGridViewTextBoxColumn PhoneNumberStudent;
        private DataGridViewTextBoxColumn PassportDataStudent;
        private DataGridViewTextBoxColumn GroupStudent;
        private DataGridViewTextBoxColumn BirthdayStudent;
        private DataGridViewTextBoxColumn DateRecieptColumn;
        private DataGridViewTextBoxColumn IsFullTimeColumn;
        private DataGridViewTextBoxColumn NumberRecordColumn;
        private DataGridViewTextBoxColumn CourseNumberColumn;
        private DataGridViewTextBoxColumn NameSpecialty;
    }
}