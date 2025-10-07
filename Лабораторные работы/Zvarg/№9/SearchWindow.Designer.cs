namespace _9_lab___C_
{
    partial class SearchWindow
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
            Search_Label = new Label();
            KeySearch_InputBox = new TextBox();
            Confirm_Button = new Button();
            SuspendLayout();
            // 
            // Search_Label
            // 
            Search_Label.AutoSize = true;
            Search_Label.ForeColor = Color.Silver;
            Search_Label.Location = new Point(23, 31);
            Search_Label.Name = "Search_Label";
            Search_Label.Size = new Size(177, 21);
            Search_Label.TabIndex = 1;
            Search_Label.Text = "Введите ключ клиента:";
            // 
            // KeySearch_InputBox
            // 
            KeySearch_InputBox.BackColor = Color.FromArgb(64, 64, 64);
            KeySearch_InputBox.BorderStyle = BorderStyle.None;
            KeySearch_InputBox.Location = new Point(23, 76);
            KeySearch_InputBox.Name = "KeySearch_InputBox";
            KeySearch_InputBox.Size = new Size(421, 22);
            KeySearch_InputBox.TabIndex = 6;
            // 
            // Confirm_Button
            // 
            Confirm_Button.BackColor = Color.FromArgb(255, 128, 0);
            Confirm_Button.FlatStyle = FlatStyle.Popup;
            Confirm_Button.Location = new Point(23, 128);
            Confirm_Button.Name = "Confirm_Button";
            Confirm_Button.Size = new Size(421, 87);
            Confirm_Button.TabIndex = 11;
            Confirm_Button.Text = "Ввести параметр поиска";
            Confirm_Button.UseVisualStyleBackColor = false;
            Confirm_Button.Click += Confirm_Button_Click;
            // 
            // SearchWindow
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(27, 38, 49);
            ClientSize = new Size(467, 227);
            Controls.Add(Confirm_Button);
            Controls.Add(KeySearch_InputBox);
            Controls.Add(Search_Label);
            Font = new Font("Britannic Bold", 14.25F);
            Margin = new Padding(4, 4, 4, 4);
            Name = "SearchWindow";
            Text = "Ввод параметров поиска";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Search_Label;
        private TextBox KeySearch_InputBox;
        private Button Confirm_Button;
    }
}