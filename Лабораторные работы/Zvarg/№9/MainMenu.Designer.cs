namespace _9_lab___C_
{
    partial class MainMenu
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
            Input_Button = new Button();
            Delete_Button = new Button();
            View_Button = new Button();
            Sort_Button = new Button();
            Find_Button = new Button();
            LINQ_Filter_Button = new Button();
            SuspendLayout();
            // 
            // Input_Button
            // 
            Input_Button.BackColor = Color.FromArgb(255, 128, 0);
            Input_Button.FlatStyle = FlatStyle.Popup;
            Input_Button.Location = new Point(41, 39);
            Input_Button.Margin = new Padding(4);
            Input_Button.Name = "Input_Button";
            Input_Button.Size = new Size(136, 122);
            Input_Button.TabIndex = 1;
            Input_Button.Text = "Добавить элемент в коллекцию";
            Input_Button.UseVisualStyleBackColor = false;
            Input_Button.Click += Input_Button_Click;
            // 
            // Delete_Button
            // 
            Delete_Button.BackColor = Color.FromArgb(255, 128, 0);
            Delete_Button.FlatStyle = FlatStyle.Popup;
            Delete_Button.Location = new Point(264, 39);
            Delete_Button.Margin = new Padding(4);
            Delete_Button.Name = "Delete_Button";
            Delete_Button.Size = new Size(134, 122);
            Delete_Button.TabIndex = 2;
            Delete_Button.Text = "Удалить последний элемент";
            Delete_Button.UseVisualStyleBackColor = false;
            Delete_Button.Click += Delete_Button_Click;
            // 
            // View_Button
            // 
            View_Button.BackColor = Color.FromArgb(255, 128, 0);
            View_Button.FlatStyle = FlatStyle.Popup;
            View_Button.Location = new Point(41, 190);
            View_Button.Margin = new Padding(4);
            View_Button.Name = "View_Button";
            View_Button.Size = new Size(136, 122);
            View_Button.TabIndex = 3;
            View_Button.Text = "Отобразить элементы коллекции";
            View_Button.UseVisualStyleBackColor = false;
            View_Button.Click += View_Button_Click;
            // 
            // Sort_Button
            // 
            Sort_Button.BackColor = Color.FromArgb(255, 128, 0);
            Sort_Button.FlatStyle = FlatStyle.Popup;
            Sort_Button.Font = new Font("Britannic Bold", 14.25F, FontStyle.Underline, GraphicsUnit.Point, 0);
            Sort_Button.Location = new Point(264, 190);
            Sort_Button.Margin = new Padding(4);
            Sort_Button.Name = "Sort_Button";
            Sort_Button.Size = new Size(134, 122);
            Sort_Button.TabIndex = 4;
            Sort_Button.Text = "Сортировка элементов коллекции по возрасту";
            Sort_Button.UseVisualStyleBackColor = false;
            Sort_Button.Click += Sort_Button_Click;
            // 
            // Find_Button
            // 
            Find_Button.BackColor = Color.FromArgb(255, 128, 0);
            Find_Button.FlatStyle = FlatStyle.Popup;
            Find_Button.Font = new Font("Britannic Bold", 14.25F, FontStyle.Underline, GraphicsUnit.Point, 0);
            Find_Button.Location = new Point(41, 377);
            Find_Button.Margin = new Padding(4);
            Find_Button.Name = "Find_Button";
            Find_Button.Size = new Size(136, 122);
            Find_Button.TabIndex = 5;
            Find_Button.Text = "Поиск необходимого элемента коллекции";
            Find_Button.UseVisualStyleBackColor = false;
            Find_Button.Click += Find_Button_Click;
            // 
            // LINQ_Filter_Button
            // 
            LINQ_Filter_Button.BackColor = Color.FromArgb(255, 128, 0);
            LINQ_Filter_Button.FlatStyle = FlatStyle.Popup;
            LINQ_Filter_Button.Location = new Point(264, 377);
            LINQ_Filter_Button.Margin = new Padding(4);
            LINQ_Filter_Button.Name = "LINQ_Filter_Button";
            LINQ_Filter_Button.Size = new Size(134, 122);
            LINQ_Filter_Button.TabIndex = 6;
            LINQ_Filter_Button.Text = "LINQ-фильтрация (по совершеннолетию клиента)";
            LINQ_Filter_Button.UseVisualStyleBackColor = false;
            LINQ_Filter_Button.Click += LINQ_Filter_Button_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(27, 38, 49);
            ClientSize = new Size(444, 532);
            Controls.Add(LINQ_Filter_Button);
            Controls.Add(Find_Button);
            Controls.Add(Sort_Button);
            Controls.Add(View_Button);
            Controls.Add(Delete_Button);
            Controls.Add(Input_Button);
            Font = new Font("Britannic Bold", 14.25F);
            Margin = new Padding(4);
            Name = "MainMenu";
            Text = "Корнышев В.Н. 3105-об";
            ResumeLayout(false);
        }

        #endregion

        private Button Input_Button;
        private Button Delete_Button;
        private Button View_Button;
        private Button Sort_Button;
        private Button Find_Button;
        private Button LINQ_Filter_Button;
    }
}
