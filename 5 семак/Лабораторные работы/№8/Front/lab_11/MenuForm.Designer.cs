namespace lab_11
{
    partial class MenuForm
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
            Specialties_Button = new Button();
            Exams_Button = new Button();
            SuspendLayout();
            // 
            // Specialties_Button
            // 
            Specialties_Button.FlatAppearance.BorderSize = 0;
            Specialties_Button.FlatStyle = FlatStyle.Flat;
            Specialties_Button.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Specialties_Button.Location = new Point(31, 23);
            Specialties_Button.Name = "Specialties_Button";
            Specialties_Button.Size = new Size(203, 84);
            Specialties_Button.TabIndex = 0;
            Specialties_Button.Text = "Студенты специальностей";
            Specialties_Button.UseVisualStyleBackColor = true;
            Specialties_Button.Click += Specialties_Button_Click;
            // 
            // Exams_Button
            // 
            Exams_Button.FlatAppearance.BorderSize = 0;
            Exams_Button.FlatStyle = FlatStyle.Flat;
            Exams_Button.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            Exams_Button.Location = new Point(31, 113);
            Exams_Button.Name = "Exams_Button";
            Exams_Button.Size = new Size(203, 84);
            Exams_Button.TabIndex = 1;
            Exams_Button.Text = "Экзамены студентов";
            Exams_Button.UseVisualStyleBackColor = true;
            Exams_Button.Click += Exams_Button_Click;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(265, 253);
            Controls.Add(Exams_Button);
            Controls.Add(Specialties_Button);
            ForeColor = SystemColors.Control;
            Name = "MenuForm";
            Opacity = 0.97D;
            Text = "Лабораторная 11";
            ResumeLayout(false);
        }

        #endregion

        private Button Specialties_Button;
        private Button Exams_Button;
    }
}
