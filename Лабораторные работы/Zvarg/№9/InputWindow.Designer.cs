namespace _9_lab___C_
{
    partial class InputWindow
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
            Name_label = new Label();
            Surname_label = new Label();
            Age_label = new Label();
            Trait_label = new Label();
            Key_label = new Label();
            Name_InputBox = new TextBox();
            Surname_InputBox = new TextBox();
            Age_InputBox = new TextBox();
            Trait_InputBox = new TextBox();
            Key_InputBox = new TextBox();
            Confirm_Button = new Button();
            SuspendLayout();
            // 
            // Name_label
            // 
            Name_label.AutoSize = true;
            Name_label.ForeColor = Color.Silver;
            Name_label.Location = new Point(30, 25);
            Name_label.Name = "Name_label";
            Name_label.Size = new Size(45, 21);
            Name_label.TabIndex = 0;
            Name_label.Text = "Имя:";
            // 
            // Surname_label
            // 
            Surname_label.AutoSize = true;
            Surname_label.ForeColor = Color.Silver;
            Surname_label.Location = new Point(30, 133);
            Surname_label.Name = "Surname_label";
            Surname_label.Size = new Size(80, 21);
            Surname_label.TabIndex = 1;
            Surname_label.Text = "Фамилия:";
            // 
            // Age_label
            // 
            Age_label.AutoSize = true;
            Age_label.ForeColor = Color.Silver;
            Age_label.Location = new Point(30, 246);
            Age_label.Name = "Age_label";
            Age_label.Size = new Size(73, 21);
            Age_label.TabIndex = 2;
            Age_label.Text = "Возраст:";
            // 
            // Trait_label
            // 
            Trait_label.AutoSize = true;
            Trait_label.ForeColor = Color.Silver;
            Trait_label.Location = new Point(30, 353);
            Trait_label.Name = "Trait_label";
            Trait_label.Size = new Size(114, 21);
            Trait_label.TabIndex = 3;
            Trait_label.Text = "Особая черта:";
            // 
            // Key_label
            // 
            Key_label.AutoSize = true;
            Key_label.ForeColor = Color.Silver;
            Key_label.Location = new Point(30, 463);
            Key_label.Name = "Key_label";
            Key_label.Size = new Size(81, 21);
            Key_label.TabIndex = 4;
            Key_label.Text = "Ключ БД:";
            // 
            // Name_InputBox
            // 
            Name_InputBox.BackColor = Color.FromArgb(64, 64, 64);
            Name_InputBox.BorderStyle = BorderStyle.None;
            Name_InputBox.Location = new Point(30, 69);
            Name_InputBox.Name = "Name_InputBox";
            Name_InputBox.Size = new Size(421, 22);
            Name_InputBox.TabIndex = 5;
            // 
            // Surname_InputBox
            // 
            Surname_InputBox.BackColor = Color.FromArgb(64, 64, 64);
            Surname_InputBox.BorderStyle = BorderStyle.None;
            Surname_InputBox.Location = new Point(30, 187);
            Surname_InputBox.Name = "Surname_InputBox";
            Surname_InputBox.Size = new Size(421, 22);
            Surname_InputBox.TabIndex = 6;
            // 
            // Age_InputBox
            // 
            Age_InputBox.BackColor = Color.FromArgb(64, 64, 64);
            Age_InputBox.BorderStyle = BorderStyle.None;
            Age_InputBox.Location = new Point(30, 297);
            Age_InputBox.Name = "Age_InputBox";
            Age_InputBox.Size = new Size(421, 22);
            Age_InputBox.TabIndex = 7;
            // 
            // Trait_InputBox
            // 
            Trait_InputBox.BackColor = Color.FromArgb(64, 64, 64);
            Trait_InputBox.BorderStyle = BorderStyle.None;
            Trait_InputBox.Location = new Point(30, 408);
            Trait_InputBox.Name = "Trait_InputBox";
            Trait_InputBox.Size = new Size(421, 22);
            Trait_InputBox.TabIndex = 8;
            // 
            // Key_InputBox
            // 
            Key_InputBox.BackColor = Color.FromArgb(64, 64, 64);
            Key_InputBox.BorderStyle = BorderStyle.None;
            Key_InputBox.Location = new Point(30, 512);
            Key_InputBox.Name = "Key_InputBox";
            Key_InputBox.Size = new Size(421, 22);
            Key_InputBox.TabIndex = 9;
            // 
            // Confirm_Button
            // 
            Confirm_Button.BackColor = Color.FromArgb(255, 128, 0);
            Confirm_Button.FlatStyle = FlatStyle.Popup;
            Confirm_Button.Location = new Point(30, 569);
            Confirm_Button.Name = "Confirm_Button";
            Confirm_Button.Size = new Size(421, 87);
            Confirm_Button.TabIndex = 10;
            Confirm_Button.Text = "Добавить элемент в коллекцию";
            Confirm_Button.UseVisualStyleBackColor = false;
            Confirm_Button.Click += Confirm_Button_Click;
            // 
            // InputWindow
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(27, 38, 49);
            ClientSize = new Size(494, 668);
            Controls.Add(Confirm_Button);
            Controls.Add(Key_InputBox);
            Controls.Add(Trait_InputBox);
            Controls.Add(Age_InputBox);
            Controls.Add(Surname_InputBox);
            Controls.Add(Name_InputBox);
            Controls.Add(Key_label);
            Controls.Add(Trait_label);
            Controls.Add(Age_label);
            Controls.Add(Surname_label);
            Controls.Add(Name_label);
            Font = new Font("Britannic Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "InputWindow";
            Text = "Ввод нового клиента";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Name_label;
        private Label Surname_label;
        private Label Age_label;
        private Label Trait_label;
        private Label Key_label;
        private TextBox Name_InputBox;
        private TextBox Surname_InputBox;
        private TextBox Age_InputBox;
        private TextBox Trait_InputBox;
        private TextBox Key_InputBox;
        private Button Confirm_Button;
    }
}