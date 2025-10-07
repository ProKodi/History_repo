namespace _5_lab___C_
{
    partial class ModalOutputWindow
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
            this.ExitButton = new System.Windows.Forms.Button();
            this.OutputBox = new System.Windows.Forms.ListBox();
            this.Modify_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Chocolate;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(-103, 217);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(1024, 252);
            this.ExitButton.TabIndex = 0;
            this.ExitButton.Text = "Закрыть";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // OutputBox
            // 
            this.OutputBox.BackColor = System.Drawing.SystemColors.HotTrack;
            this.OutputBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OutputBox.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutputBox.ForeColor = System.Drawing.Color.DarkRed;
            this.OutputBox.FormattingEnabled = true;
            this.OutputBox.HorizontalScrollbar = true;
            this.OutputBox.ItemHeight = 39;
            this.OutputBox.Location = new System.Drawing.Point(157, 51);
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.ScrollAlwaysVisible = true;
            this.OutputBox.Size = new System.Drawing.Size(460, 156);
            this.OutputBox.TabIndex = 1;
            // 
            // Modify_Button
            // 
            this.Modify_Button.BackColor = System.Drawing.SystemColors.Highlight;
            this.Modify_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Modify_Button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Modify_Button.Location = new System.Drawing.Point(72, 114);
            this.Modify_Button.Name = "Modify_Button";
            this.Modify_Button.Size = new System.Drawing.Size(68, 93);
            this.Modify_Button.TabIndex = 2;
            this.Modify_Button.Text = "Вывести сначала всех пресноводных...";
            this.Modify_Button.UseVisualStyleBackColor = false;
            this.Modify_Button.Click += new System.EventHandler(this.Modify_Button_Click);
            // 
            // ModalOutputWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Modify_Button);
            this.Controls.Add(this.OutputBox);
            this.Controls.Add(this.ExitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModalOutputWindow";
            this.Text = "ModalOutputWindow";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.ListBox OutputBox;
        private System.Windows.Forms.Button Modify_Button;
    }
}