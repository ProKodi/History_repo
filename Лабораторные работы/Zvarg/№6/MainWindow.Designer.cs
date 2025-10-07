namespace _6_lab___C_
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
            Compare1_2 = new Button();
            Compare2_6 = new Button();
            OutputBox = new ListBox();
            Modify_Button = new Button();
            MainLayoutPanel = new TableLayoutPanel();
            Clone_Button = new Button();
            Upcast_Button = new Button();
            MainLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // Compare1_2
            // 
            Compare1_2.AutoSize = true;
            Compare1_2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Compare1_2.BackColor = Color.FromArgb(255, 128, 0);
            Compare1_2.Dock = DockStyle.Fill;
            Compare1_2.FlatStyle = FlatStyle.Flat;
            Compare1_2.Location = new Point(3, 140);
            Compare1_2.Name = "Compare1_2";
            Compare1_2.Size = new Size(746, 28);
            Compare1_2.TabIndex = 3;
            Compare1_2.Text = "Сравнить 1 и 2 значения";
            Compare1_2.UseVisualStyleBackColor = false;
            Compare1_2.Click += Compare1_2_Click;
            // 
            // Compare2_6
            // 
            Compare2_6.AutoSize = true;
            Compare2_6.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Compare2_6.BackColor = Color.FromArgb(255, 128, 0);
            Compare2_6.Dock = DockStyle.Fill;
            Compare2_6.FlatStyle = FlatStyle.Flat;
            Compare2_6.Location = new Point(3, 174);
            Compare2_6.Name = "Compare2_6";
            Compare2_6.Size = new Size(746, 28);
            Compare2_6.TabIndex = 4;
            Compare2_6.Text = "Сравнить 2 и 6 значения";
            Compare2_6.UseVisualStyleBackColor = false;
            Compare2_6.Click += Compare2_6_Click;
            // 
            // OutputBox
            // 
            OutputBox.BackColor = Color.FromArgb(64, 64, 64);
            OutputBox.BorderStyle = BorderStyle.None;
            OutputBox.Dock = DockStyle.Fill;
            OutputBox.Font = new Font("Impact", 14F);
            OutputBox.ForeColor = Color.Aquamarine;
            OutputBox.FormattingEnabled = true;
            OutputBox.HorizontalScrollbar = true;
            OutputBox.ItemHeight = 23;
            OutputBox.Location = new Point(3, 3);
            OutputBox.Name = "OutputBox";
            OutputBox.ScrollAlwaysVisible = true;
            OutputBox.Size = new Size(746, 131);
            OutputBox.TabIndex = 5;
            // 
            // Modify_Button
            // 
            Modify_Button.AutoSize = true;
            Modify_Button.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Modify_Button.BackColor = Color.FromArgb(255, 128, 0);
            Modify_Button.Dock = DockStyle.Fill;
            Modify_Button.FlatStyle = FlatStyle.Flat;
            Modify_Button.Location = new Point(3, 208);
            Modify_Button.Name = "Modify_Button";
            Modify_Button.Size = new Size(746, 28);
            Modify_Button.TabIndex = 6;
            Modify_Button.Text = "Модифицировать список";
            Modify_Button.UseVisualStyleBackColor = false;
            Modify_Button.Click += Modify_Button_Click;
            // 
            // MainLayoutPanel
            // 
            MainLayoutPanel.AutoSize = true;
            MainLayoutPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            MainLayoutPanel.ColumnCount = 1;
            MainLayoutPanel.ColumnStyles.Add(new ColumnStyle());
            MainLayoutPanel.Controls.Add(OutputBox, 0, 0);
            MainLayoutPanel.Controls.Add(Modify_Button, 0, 3);
            MainLayoutPanel.Controls.Add(Compare1_2, 0, 1);
            MainLayoutPanel.Controls.Add(Compare2_6, 0, 2);
            MainLayoutPanel.Controls.Add(Clone_Button, 0, 4);
            MainLayoutPanel.Controls.Add(Upcast_Button, 0, 5);
            MainLayoutPanel.Dock = DockStyle.Fill;
            MainLayoutPanel.Location = new Point(0, 0);
            MainLayoutPanel.Name = "MainLayoutPanel";
            MainLayoutPanel.RowCount = 6;
            MainLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            MainLayoutPanel.RowStyles.Add(new RowStyle());
            MainLayoutPanel.RowStyles.Add(new RowStyle());
            MainLayoutPanel.RowStyles.Add(new RowStyle());
            MainLayoutPanel.RowStyles.Add(new RowStyle());
            MainLayoutPanel.RowStyles.Add(new RowStyle());
            MainLayoutPanel.Size = new Size(752, 307);
            MainLayoutPanel.TabIndex = 7;
            // 
            // Clone_Button
            // 
            Clone_Button.AutoSize = true;
            Clone_Button.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Clone_Button.BackColor = Color.FromArgb(255, 128, 0);
            Clone_Button.Dock = DockStyle.Fill;
            Clone_Button.FlatStyle = FlatStyle.Flat;
            Clone_Button.Location = new Point(3, 242);
            Clone_Button.Name = "Clone_Button";
            Clone_Button.Size = new Size(746, 28);
            Clone_Button.TabIndex = 7;
            Clone_Button.Text = "Копировать второе значение и поставить его на место шестого";
            Clone_Button.UseVisualStyleBackColor = false;
            Clone_Button.Click += Clone_Button_Click;
            // 
            // Upcast_Button
            // 
            Upcast_Button.AutoSize = true;
            Upcast_Button.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Upcast_Button.BackColor = Color.FromArgb(255, 128, 0);
            Upcast_Button.Dock = DockStyle.Fill;
            Upcast_Button.FlatStyle = FlatStyle.Flat;
            Upcast_Button.Location = new Point(3, 276);
            Upcast_Button.Name = "Upcast_Button";
            Upcast_Button.Size = new Size(746, 28);
            Upcast_Button.TabIndex = 8;
            Upcast_Button.Text = "Upcast 4 и нового элементов (кошки - млекопитающего)";
            Upcast_Button.UseVisualStyleBackColor = false;
            Upcast_Button.Click += Upcast_Button_Click;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(6F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(752, 307);
            Controls.Add(MainLayoutPanel);
            Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MinimumSize = new Size(768, 346);
            Name = "MainWindow";
            Text = "Корнышев В.Н. 3105-об 6 лаб.";
            MainLayoutPanel.ResumeLayout(false);
            MainLayoutPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button Compare1_2;
        private Button Compare2_6;
        private ListBox OutputBox;
        private Button Modify_Button;
        private TableLayoutPanel MainLayoutPanel;
        private Button Clone_Button;
        private Button Upcast_Button;
    }
}
