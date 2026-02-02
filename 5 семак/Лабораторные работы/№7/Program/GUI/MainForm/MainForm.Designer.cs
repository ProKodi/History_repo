namespace Connection_lab
{
    partial class MainForm
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
            EditingData = new Button();
            PRequest = new Button();
            AvgMarkButton = new Button();
            SuspendLayout();
            // 
            // EditingData
            // 
            EditingData.FlatAppearance.BorderSize = 0;
            EditingData.FlatStyle = FlatStyle.Flat;
            EditingData.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            EditingData.ForeColor = SystemColors.Control;
            EditingData.Location = new Point(57, 12);
            EditingData.Name = "EditingData";
            EditingData.Size = new Size(324, 106);
            EditingData.TabIndex = 0;
            EditingData.Text = "Ввод и редактирование данных";
            EditingData.UseVisualStyleBackColor = true;
            EditingData.Click += EditingData_Click;
            // 
            // PRequest
            // 
            PRequest.FlatAppearance.BorderSize = 0;
            PRequest.FlatStyle = FlatStyle.Flat;
            PRequest.Font = new Font("Segoe UI", 18F);
            PRequest.ForeColor = SystemColors.Control;
            PRequest.Location = new Point(57, 146);
            PRequest.Name = "PRequest";
            PRequest.Size = new Size(324, 106);
            PRequest.TabIndex = 1;
            PRequest.Text = "Запрос на фамилии с буквой П";
            PRequest.UseVisualStyleBackColor = true;
            PRequest.Click += PRequest_Click;
            // 
            // AvgMarkButton
            // 
            AvgMarkButton.FlatAppearance.BorderSize = 0;
            AvgMarkButton.FlatStyle = FlatStyle.Flat;
            AvgMarkButton.Font = new Font("Segoe UI", 18F);
            AvgMarkButton.ForeColor = SystemColors.Control;
            AvgMarkButton.Location = new Point(57, 282);
            AvgMarkButton.Name = "AvgMarkButton";
            AvgMarkButton.Size = new Size(324, 106);
            AvgMarkButton.TabIndex = 2;
            AvgMarkButton.Text = "Расчёт среднего балла";
            AvgMarkButton.UseVisualStyleBackColor = true;
            AvgMarkButton.Click += AvgMarkButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(561, 405);
            Controls.Add(AvgMarkButton);
            Controls.Add(PRequest);
            Controls.Add(EditingData);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "MainForm";
            Opacity = 0.95D;
            Text = "Лабораторная работа (9-12)";
            ResumeLayout(false);
        }

        #endregion

        private Button EditingData;
        private Button PRequest;
        private Button AvgMarkButton;
    }
}
