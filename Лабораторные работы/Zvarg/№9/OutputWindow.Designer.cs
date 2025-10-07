namespace _9_lab___C_
{
    partial class OutputWindow
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
            Output_Label = new Label();
            Output_TextBox = new ListBox();
            SuspendLayout();
            // 
            // Output_Label
            // 
            Output_Label.AutoSize = true;
            Output_Label.ForeColor = Color.Silver;
            Output_Label.Location = new Point(30, 27);
            Output_Label.Name = "Output_Label";
            Output_Label.Size = new Size(88, 21);
            Output_Label.TabIndex = 0;
            Output_Label.Text = "Клиентура:";
            // 
            // Output_TextBox
            // 
            Output_TextBox.BackColor = Color.FromArgb(27, 38, 49);
            Output_TextBox.BorderStyle = BorderStyle.None;
            Output_TextBox.ForeColor = Color.Silver;
            Output_TextBox.FormattingEnabled = true;
            Output_TextBox.ItemHeight = 21;
            Output_TextBox.Location = new Point(30, 65);
            Output_TextBox.Name = "Output_TextBox";
            Output_TextBox.ScrollAlwaysVisible = true;
            Output_TextBox.Size = new Size(1082, 525);
            Output_TextBox.TabIndex = 1;
            // 
            // OutputWindow
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(27, 38, 49);
            ClientSize = new Size(1143, 630);
            Controls.Add(Output_TextBox);
            Controls.Add(Output_Label);
            Font = new Font("Britannic Bold", 14.25F);
            Margin = new Padding(4);
            Name = "OutputWindow";
            Text = "Вывод клиентуры";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Output_Label;
        private ListBox Output_TextBox;
    }
}