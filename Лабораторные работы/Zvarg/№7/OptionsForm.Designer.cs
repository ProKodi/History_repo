namespace _7_lab___C_
{
    partial class OptionsForm
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
            ColorRingComboBox = new ComboBox();
            ColorRingLabel = new Label();
            ColorMtnDoomLabel = new Label();
            ColorMtnDoomComboBox = new ComboBox();
            ColorDoomFireLabel = new Label();
            ColorDoomFireComboBox = new ComboBox();
            DirectionGroupBox = new GroupBox();
            LeftRightMovementButton = new RadioButton();
            UpDownMovementButton = new RadioButton();
            SizeGroupBox = new GroupBox();
            BigSizeButton = new RadioButton();
            SmallSizeButton = new RadioButton();
            ApplyButton = new Button();
            DirectionGroupBox.SuspendLayout();
            SizeGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // ColorRingComboBox
            // 
            ColorRingComboBox.BackColor = Color.FromArgb(27, 38, 49);
            ColorRingComboBox.FlatStyle = FlatStyle.Flat;
            ColorRingComboBox.FormattingEnabled = true;
            ColorRingComboBox.Items.AddRange(new object[] { "Золотой", "Оранжевый", "Красноватый" });
            ColorRingComboBox.Location = new Point(15, 54);
            ColorRingComboBox.Margin = new Padding(4, 5, 4, 5);
            ColorRingComboBox.Name = "ColorRingComboBox";
            ColorRingComboBox.Size = new Size(273, 31);
            ColorRingComboBox.TabIndex = 0;
            // 
            // ColorRingLabel
            // 
            ColorRingLabel.AutoSize = true;
            ColorRingLabel.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ColorRingLabel.ForeColor = Color.Silver;
            ColorRingLabel.Location = new Point(15, 14);
            ColorRingLabel.Margin = new Padding(4, 0, 4, 0);
            ColorRingLabel.Name = "ColorRingLabel";
            ColorRingLabel.Size = new Size(273, 23);
            ColorRingLabel.TabIndex = 1;
            ColorRingLabel.Text = "Выберите цвет Единого Кольца";
            // 
            // ColorMtnDoomLabel
            // 
            ColorMtnDoomLabel.AutoSize = true;
            ColorMtnDoomLabel.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ColorMtnDoomLabel.ForeColor = Color.Silver;
            ColorMtnDoomLabel.Location = new Point(15, 116);
            ColorMtnDoomLabel.Margin = new Padding(4, 0, 4, 0);
            ColorMtnDoomLabel.Name = "ColorMtnDoomLabel";
            ColorMtnDoomLabel.Size = new Size(257, 23);
            ColorMtnDoomLabel.TabIndex = 2;
            ColorMtnDoomLabel.Text = "Выберите цвет Роковой Горы";
            // 
            // ColorMtnDoomComboBox
            // 
            ColorMtnDoomComboBox.BackColor = Color.FromArgb(27, 38, 49);
            ColorMtnDoomComboBox.FlatStyle = FlatStyle.Flat;
            ColorMtnDoomComboBox.FormattingEnabled = true;
            ColorMtnDoomComboBox.Items.AddRange(new object[] { "Чёрный", "Коричневый" });
            ColorMtnDoomComboBox.Location = new Point(15, 168);
            ColorMtnDoomComboBox.Margin = new Padding(4, 5, 4, 5);
            ColorMtnDoomComboBox.Name = "ColorMtnDoomComboBox";
            ColorMtnDoomComboBox.Size = new Size(273, 31);
            ColorMtnDoomComboBox.TabIndex = 3;
            // 
            // ColorDoomFireLabel
            // 
            ColorDoomFireLabel.AutoSize = true;
            ColorDoomFireLabel.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ColorDoomFireLabel.ForeColor = Color.Silver;
            ColorDoomFireLabel.Location = new Point(15, 233);
            ColorDoomFireLabel.Margin = new Padding(4, 0, 4, 0);
            ColorDoomFireLabel.Name = "ColorDoomFireLabel";
            ColorDoomFireLabel.Size = new Size(319, 23);
            ColorDoomFireLabel.TabIndex = 4;
            ColorDoomFireLabel.Text = "Выберите цвет дыма/пламени Горы";
            // 
            // ColorDoomFireComboBox
            // 
            ColorDoomFireComboBox.BackColor = Color.FromArgb(27, 38, 49);
            ColorDoomFireComboBox.FlatStyle = FlatStyle.Flat;
            ColorDoomFireComboBox.FormattingEnabled = true;
            ColorDoomFireComboBox.Items.AddRange(new object[] { "Жёлтый (пламя)", "Серый (дым)" });
            ColorDoomFireComboBox.Location = new Point(15, 284);
            ColorDoomFireComboBox.Margin = new Padding(4, 5, 4, 5);
            ColorDoomFireComboBox.Name = "ColorDoomFireComboBox";
            ColorDoomFireComboBox.Size = new Size(273, 31);
            ColorDoomFireComboBox.TabIndex = 5;
            // 
            // DirectionGroupBox
            // 
            DirectionGroupBox.Controls.Add(LeftRightMovementButton);
            DirectionGroupBox.Controls.Add(UpDownMovementButton);
            DirectionGroupBox.FlatStyle = FlatStyle.Flat;
            DirectionGroupBox.ForeColor = Color.Silver;
            DirectionGroupBox.Location = new Point(348, 14);
            DirectionGroupBox.Name = "DirectionGroupBox";
            DirectionGroupBox.Size = new Size(594, 185);
            DirectionGroupBox.TabIndex = 6;
            DirectionGroupBox.TabStop = false;
            DirectionGroupBox.Text = "Выбор направления";
            // 
            // LeftRightMovementButton
            // 
            LeftRightMovementButton.AutoSize = true;
            LeftRightMovementButton.Location = new Point(23, 98);
            LeftRightMovementButton.Name = "LeftRightMovementButton";
            LeftRightMovementButton.Size = new Size(146, 27);
            LeftRightMovementButton.TabIndex = 1;
            LeftRightMovementButton.TabStop = true;
            LeftRightMovementButton.Text = "Влево-вправо";
            LeftRightMovementButton.UseVisualStyleBackColor = true;
            // 
            // UpDownMovementButton
            // 
            UpDownMovementButton.AutoSize = true;
            UpDownMovementButton.Location = new Point(23, 44);
            UpDownMovementButton.Name = "UpDownMovementButton";
            UpDownMovementButton.Size = new Size(123, 27);
            UpDownMovementButton.TabIndex = 0;
            UpDownMovementButton.TabStop = true;
            UpDownMovementButton.Text = "Вверх-вниз";
            UpDownMovementButton.UseVisualStyleBackColor = true;
            // 
            // SizeGroupBox
            // 
            SizeGroupBox.Controls.Add(BigSizeButton);
            SizeGroupBox.Controls.Add(SmallSizeButton);
            SizeGroupBox.FlatStyle = FlatStyle.Flat;
            SizeGroupBox.ForeColor = Color.Silver;
            SizeGroupBox.Location = new Point(348, 233);
            SizeGroupBox.Name = "SizeGroupBox";
            SizeGroupBox.Size = new Size(594, 185);
            SizeGroupBox.TabIndex = 7;
            SizeGroupBox.TabStop = false;
            SizeGroupBox.Text = "Выбор размеров";
            // 
            // BigSizeButton
            // 
            BigSizeButton.AutoSize = true;
            BigSizeButton.Location = new Point(23, 98);
            BigSizeButton.Name = "BigSizeButton";
            BigSizeButton.Size = new Size(120, 27);
            BigSizeButton.TabIndex = 1;
            BigSizeButton.TabStop = true;
            BigSizeButton.Text = "Побольше!";
            BigSizeButton.UseVisualStyleBackColor = true;
            // 
            // SmallSizeButton
            // 
            SmallSizeButton.AutoSize = true;
            SmallSizeButton.Location = new Point(23, 44);
            SmallSizeButton.Name = "SmallSizeButton";
            SmallSizeButton.Size = new Size(126, 27);
            SmallSizeButton.TabIndex = 0;
            SmallSizeButton.TabStop = true;
            SmallSizeButton.Text = "Небольшие";
            SmallSizeButton.UseVisualStyleBackColor = true;
            // 
            // ApplyButton
            // 
            ApplyButton.FlatAppearance.BorderColor = Color.FromArgb(27, 38, 49);
            ApplyButton.FlatStyle = FlatStyle.Flat;
            ApplyButton.ForeColor = Color.Silver;
            ApplyButton.Location = new Point(36, 396);
            ApplyButton.Name = "ApplyButton";
            ApplyButton.Size = new Size(236, 111);
            ApplyButton.TabIndex = 8;
            ApplyButton.Text = "Применить";
            ApplyButton.UseVisualStyleBackColor = true;
            ApplyButton.Click += ApplyButton_Click;
            // 
            // OptionsForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(27, 38, 49);
            ClientSize = new Size(984, 561);
            Controls.Add(ApplyButton);
            Controls.Add(SizeGroupBox);
            Controls.Add(DirectionGroupBox);
            Controls.Add(ColorDoomFireComboBox);
            Controls.Add(ColorDoomFireLabel);
            Controls.Add(ColorMtnDoomComboBox);
            Controls.Add(ColorMtnDoomLabel);
            Controls.Add(ColorRingLabel);
            Controls.Add(ColorRingComboBox);
            Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4, 5, 4, 5);
            MaximumSize = new Size(1000, 600);
            MinimumSize = new Size(1000, 600);
            Name = "OptionsForm";
            Text = "Настройки";
            DirectionGroupBox.ResumeLayout(false);
            DirectionGroupBox.PerformLayout();
            SizeGroupBox.ResumeLayout(false);
            SizeGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox ColorRingComboBox;
        private Label ColorRingLabel;
        private Label ColorMtnDoomLabel;
        private ComboBox ColorMtnDoomComboBox;
        private Label ColorDoomFireLabel;
        private ComboBox ColorDoomFireComboBox;
        private GroupBox DirectionGroupBox;
        private RadioButton LeftRightMovementButton;
        private RadioButton UpDownMovementButton;
        private GroupBox SizeGroupBox;
        private RadioButton BigSizeButton;
        private RadioButton SmallSizeButton;
        private Button ApplyButton;
    }
}