namespace _7_lab___C_
{
    partial class MainWindow
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
            SettingsButton = new Button();
            ViewButton = new Button();
            AnimationButton = new Button();
            StopAnimButton = new Button();
            ExitButton = new Button();
            SuspendLayout();
            // 
            // SettingsButton
            // 
            SettingsButton.FlatAppearance.BorderColor = Color.FromArgb(27, 38, 49);
            SettingsButton.FlatStyle = FlatStyle.Flat;
            SettingsButton.ForeColor = Color.Silver;
            SettingsButton.Location = new Point(26, 838);
            SettingsButton.Name = "SettingsButton";
            SettingsButton.Size = new Size(236, 111);
            SettingsButton.TabIndex = 0;
            SettingsButton.Text = "Выбор параметров";
            SettingsButton.UseVisualStyleBackColor = true;
            SettingsButton.Click += SettingsButton_Click;
            // 
            // ViewButton
            // 
            ViewButton.FlatAppearance.BorderColor = Color.FromArgb(27, 38, 49);
            ViewButton.FlatStyle = FlatStyle.Flat;
            ViewButton.ForeColor = Color.Silver;
            ViewButton.Location = new Point(365, 838);
            ViewButton.Name = "ViewButton";
            ViewButton.Size = new Size(236, 111);
            ViewButton.TabIndex = 1;
            ViewButton.Text = "Показать изображение";
            ViewButton.UseVisualStyleBackColor = true;
            ViewButton.Click += ViewButton_Click;
            // 
            // AnimationButton
            // 
            AnimationButton.FlatAppearance.BorderColor = Color.FromArgb(27, 38, 49);
            AnimationButton.FlatStyle = FlatStyle.Flat;
            AnimationButton.ForeColor = Color.Silver;
            AnimationButton.Location = new Point(729, 838);
            AnimationButton.Name = "AnimationButton";
            AnimationButton.Size = new Size(236, 111);
            AnimationButton.TabIndex = 2;
            AnimationButton.Text = "Анимация";
            AnimationButton.UseVisualStyleBackColor = true;
            AnimationButton.Click += AnimationButton_Click;
            // 
            // StopAnimButton
            // 
            StopAnimButton.FlatAppearance.BorderColor = Color.FromArgb(27, 38, 49);
            StopAnimButton.FlatStyle = FlatStyle.Flat;
            StopAnimButton.ForeColor = Color.Silver;
            StopAnimButton.Location = new Point(1101, 838);
            StopAnimButton.Name = "StopAnimButton";
            StopAnimButton.Size = new Size(236, 111);
            StopAnimButton.TabIndex = 3;
            StopAnimButton.Text = "Стоп";
            StopAnimButton.UseVisualStyleBackColor = true;
            StopAnimButton.Click += StopAnimButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.FlatAppearance.BorderColor = Color.FromArgb(27, 38, 49);
            ExitButton.FlatStyle = FlatStyle.Flat;
            ExitButton.ForeColor = Color.Silver;
            ExitButton.Location = new Point(1410, 838);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(236, 111);
            ExitButton.TabIndex = 4;
            ExitButton.Text = "Выход";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(27, 38, 49);
            ClientSize = new Size(1684, 961);
            Controls.Add(ExitButton);
            Controls.Add(StopAnimButton);
            Controls.Add(AnimationButton);
            Controls.Add(ViewButton);
            Controls.Add(SettingsButton);
            Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            MaximumSize = new Size(1700, 1000);
            MinimumSize = new Size(1700, 1000);
            Name = "MainWindow";
            Text = "Корнышев В.Н. 3105-об 21 вар. 7 лаб.";
            ResumeLayout(false);
        }

        #endregion

        private Button SettingsButton;
        private Button ViewButton;
        private Button AnimationButton;
        private Button StopAnimButton;
        private Button ExitButton;
    }
}
