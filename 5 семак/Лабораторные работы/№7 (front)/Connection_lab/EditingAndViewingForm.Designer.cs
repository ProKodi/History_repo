namespace Connection_lab
{
    partial class EditingAndViewingForm
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
            HelpLabel = new Label();
            MainDataGrid = new DataGridView();
            DeleteDataButton = new Button();
            AddDataButton = new Button();
            UpdateDataButton = new Button();
            StudentIdent = new DataGridViewTextBoxColumn();
            SexColumn = new DataGridViewTextBoxColumn();
            ParentsColumn = new DataGridViewTextBoxColumn();
            AddressStudent = new DataGridViewTextBoxColumn();
            PhoneNumberStudent = new DataGridViewTextBoxColumn();
            PassportDataStudent = new DataGridViewTextBoxColumn();
            GroupStudent = new DataGridViewTextBoxColumn();
            BirthdayStudent = new DataGridViewButtonColumn();
            DateRecieptColumn = new DataGridViewButtonColumn();
            IsFullTimeColumn = new DataGridViewCheckBoxColumn();
            NumberRecordColumn = new DataGridViewTextBoxColumn();
            CourseNumberColumn = new DataGridViewTextBoxColumn();
            NameSpecialty = new DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)MainDataGrid).BeginInit();
            SuspendLayout();
            // 
            // HelpLabel
            // 
            HelpLabel.AutoSize = true;
            HelpLabel.Font = new Font("Segoe UI", 18F);
            HelpLabel.ForeColor = SystemColors.Control;
            HelpLabel.Location = new Point(12, 9);
            HelpLabel.Name = "HelpLabel";
            HelpLabel.Size = new Size(255, 32);
            HelpLabel.TabIndex = 0;
            HelpLabel.Text = "Данные по студентам";
            // 
            // MainDataGrid
            // 
            MainDataGrid.BorderStyle = BorderStyle.None;
            MainDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MainDataGrid.Columns.AddRange(new DataGridViewColumn[] { StudentIdent, SexColumn, ParentsColumn, AddressStudent, PhoneNumberStudent, PassportDataStudent, GroupStudent, BirthdayStudent, DateRecieptColumn, IsFullTimeColumn, NumberRecordColumn, CourseNumberColumn, NameSpecialty });
            MainDataGrid.Location = new Point(12, 44);
            MainDataGrid.Name = "MainDataGrid";
            MainDataGrid.Size = new Size(776, 288);
            MainDataGrid.TabIndex = 1;
            // 
            // DeleteDataButton
            // 
            DeleteDataButton.FlatAppearance.BorderSize = 0;
            DeleteDataButton.FlatStyle = FlatStyle.Flat;
            DeleteDataButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            DeleteDataButton.ForeColor = SystemColors.Control;
            DeleteDataButton.Location = new Point(12, 338);
            DeleteDataButton.Name = "DeleteDataButton";
            DeleteDataButton.Size = new Size(136, 106);
            DeleteDataButton.TabIndex = 3;
            DeleteDataButton.Text = "Удалить";
            DeleteDataButton.UseVisualStyleBackColor = true;
            DeleteDataButton.Click += DeleteDataButton_Click;
            // 
            // AddDataButton
            // 
            AddDataButton.FlatAppearance.BorderSize = 0;
            AddDataButton.FlatStyle = FlatStyle.Flat;
            AddDataButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            AddDataButton.ForeColor = SystemColors.Control;
            AddDataButton.Location = new Point(154, 338);
            AddDataButton.Name = "AddDataButton";
            AddDataButton.Size = new Size(162, 106);
            AddDataButton.TabIndex = 4;
            AddDataButton.Text = "Добавить";
            AddDataButton.UseVisualStyleBackColor = true;
            AddDataButton.Click += AddDataButton_Click;
            // 
            // UpdateDataButton
            // 
            UpdateDataButton.FlatAppearance.BorderSize = 0;
            UpdateDataButton.FlatStyle = FlatStyle.Flat;
            UpdateDataButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            UpdateDataButton.ForeColor = SystemColors.Control;
            UpdateDataButton.Location = new Point(298, 338);
            UpdateDataButton.Name = "UpdateDataButton";
            UpdateDataButton.Size = new Size(279, 106);
            UpdateDataButton.TabIndex = 5;
            UpdateDataButton.Text = "Обновить";
            UpdateDataButton.UseVisualStyleBackColor = true;
            UpdateDataButton.Click += UpdateDataButton_Click;
            // 
            // StudentIdent
            // 
            StudentIdent.HeaderText = "ФИО студента";
            StudentIdent.Name = "StudentIdent";
            // 
            // SexColumn
            // 
            SexColumn.HeaderText = "Пол студента";
            SexColumn.Name = "SexColumn";
            // 
            // ParentsColumn
            // 
            ParentsColumn.HeaderText = "Родители студента";
            ParentsColumn.Name = "ParentsColumn";
            // 
            // AddressStudent
            // 
            AddressStudent.HeaderText = "Адрес проживания студента";
            AddressStudent.Name = "AddressStudent";
            // 
            // PhoneNumberStudent
            // 
            PhoneNumberStudent.HeaderText = "Телефон студента";
            PhoneNumberStudent.Name = "PhoneNumberStudent";
            // 
            // PassportDataStudent
            // 
            PassportDataStudent.HeaderText = "Паспортные данные студента";
            PassportDataStudent.Name = "PassportDataStudent";
            // 
            // GroupStudent
            // 
            GroupStudent.HeaderText = "Группа студента";
            GroupStudent.Name = "GroupStudent";
            // 
            // BirthdayStudent
            // 
            BirthdayStudent.FlatStyle = FlatStyle.Flat;
            BirthdayStudent.HeaderText = "День рождения студента";
            BirthdayStudent.Name = "BirthdayStudent";
            BirthdayStudent.Resizable = DataGridViewTriState.True;
            BirthdayStudent.SortMode = DataGridViewColumnSortMode.Automatic;
            BirthdayStudent.Text = "Null";
            // 
            // DateRecieptColumn
            // 
            DateRecieptColumn.HeaderText = "Дата поступления";
            DateRecieptColumn.Name = "DateRecieptColumn";
            DateRecieptColumn.Resizable = DataGridViewTriState.True;
            DateRecieptColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            DateRecieptColumn.Text = "Null";
            // 
            // IsFullTimeColumn
            // 
            IsFullTimeColumn.HeaderText = "Очное обучение?";
            IsFullTimeColumn.Name = "IsFullTimeColumn";
            IsFullTimeColumn.Resizable = DataGridViewTriState.True;
            IsFullTimeColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // NumberRecordColumn
            // 
            NumberRecordColumn.HeaderText = "Номер зачётной книжки";
            NumberRecordColumn.Name = "NumberRecordColumn";
            // 
            // CourseNumberColumn
            // 
            CourseNumberColumn.HeaderText = "Номер курса";
            CourseNumberColumn.Name = "CourseNumberColumn";
            // 
            // NameSpecialty
            // 
            NameSpecialty.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
            NameSpecialty.HeaderText = "Название специальности";
            NameSpecialty.Name = "NameSpecialty";
            NameSpecialty.Resizable = DataGridViewTriState.True;
            NameSpecialty.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // EditingAndViewingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(800, 450);
            Controls.Add(UpdateDataButton);
            Controls.Add(AddDataButton);
            Controls.Add(DeleteDataButton);
            Controls.Add(MainDataGrid);
            Controls.Add(HelpLabel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "EditingAndViewingForm";
            Opacity = 0.95D;
            Text = "EditingAndViewingForm";
            ((System.ComponentModel.ISupportInitialize)MainDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label HelpLabel;
        private DataGridView MainDataGrid;
        private Button DeleteDataButton;
        private Button AddDataButton;
        private Button UpdateDataButton;
        private DataGridViewTextBoxColumn StudentIdent;
        private DataGridViewTextBoxColumn SexColumn;
        private DataGridViewTextBoxColumn ParentsColumn;
        private DataGridViewTextBoxColumn AddressStudent;
        private DataGridViewTextBoxColumn PhoneNumberStudent;
        private DataGridViewTextBoxColumn PassportDataStudent;
        private DataGridViewTextBoxColumn GroupStudent;
        private DataGridViewButtonColumn BirthdayStudent;
        private DataGridViewButtonColumn DateRecieptColumn;
        private DataGridViewCheckBoxColumn IsFullTimeColumn;
        private DataGridViewTextBoxColumn NumberRecordColumn;
        private DataGridViewTextBoxColumn CourseNumberColumn;
        private DataGridViewComboBoxColumn NameSpecialty;
    }
}