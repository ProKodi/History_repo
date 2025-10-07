namespace _3_lab
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Copy_Button = new System.Windows.Forms.Button();
            this.ZeroInput_Button = new System.Windows.Forms.Button();
            this.NormalInput_Button = new System.Windows.Forms.Button();
            this.A_UserHelp = new System.Windows.Forms.Label();
            this.B_UserHelp = new System.Windows.Forms.Label();
            this.C_UserHelp = new System.Windows.Forms.Label();
            this.Discriminant_Label = new System.Windows.Forms.Label();
            this.Discriminant_OutputBox = new System.Windows.Forms.RichTextBox();
            this.Equation_Label = new System.Windows.Forms.Label();
            this.Equation_OutputBox = new System.Windows.Forms.RichTextBox();
            this.B_InputBox = new System.Windows.Forms.TextBox();
            this.C_InputBox = new System.Windows.Forms.TextBox();
            this.A_InputBox = new System.Windows.Forms.TextBox();
            this.Input_PictureBox_1 = new System.Windows.Forms.PictureBox();
            this.Output_PictureBox_1 = new System.Windows.Forms.PictureBox();
            this.Copy_button_click_highlight = new System.Windows.Forms.PictureBox();
            this.Normal_button_click_highlight = new System.Windows.Forms.PictureBox();
            this.Zero_button_click_highlight = new System.Windows.Forms.PictureBox();
            this.FirstRoot_OutputBox = new System.Windows.Forms.RichTextBox();
            this.FirstRoot_Label = new System.Windows.Forms.Label();
            this.SecondRoot_OutputBox = new System.Windows.Forms.RichTextBox();
            this.SecondRoot_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Input_PictureBox_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Output_PictureBox_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Copy_button_click_highlight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Normal_button_click_highlight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Zero_button_click_highlight)).BeginInit();
            this.SuspendLayout();
            // 
            // Copy_Button
            // 
            this.Copy_Button.FlatAppearance.BorderSize = 0;
            this.Copy_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Copy_Button.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.Copy_Button.ForeColor = System.Drawing.SystemColors.Control;
            this.Copy_Button.Image = ((System.Drawing.Image)(resources.GetObject("Copy_Button.Image")));
            this.Copy_Button.Location = new System.Drawing.Point(16, 507);
            this.Copy_Button.Name = "Copy_Button";
            this.Copy_Button.Size = new System.Drawing.Size(308, 154);
            this.Copy_Button.TabIndex = 0;
            this.Copy_Button.Text = "Скопировать прошлое выражение";
            this.Copy_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Copy_Button.UseVisualStyleBackColor = true;
            this.Copy_Button.Click += new System.EventHandler(this.Copy_Button_Click);
            // 
            // ZeroInput_Button
            // 
            this.ZeroInput_Button.FlatAppearance.BorderSize = 0;
            this.ZeroInput_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ZeroInput_Button.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ZeroInput_Button.ForeColor = System.Drawing.SystemColors.Control;
            this.ZeroInput_Button.Image = ((System.Drawing.Image)(resources.GetObject("ZeroInput_Button.Image")));
            this.ZeroInput_Button.Location = new System.Drawing.Point(16, 107);
            this.ZeroInput_Button.Name = "ZeroInput_Button";
            this.ZeroInput_Button.Size = new System.Drawing.Size(308, 122);
            this.ZeroInput_Button.TabIndex = 1;
            this.ZeroInput_Button.Text = "Выражение с нулями в качестве параметров";
            this.ZeroInput_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ZeroInput_Button.UseVisualStyleBackColor = false;
            this.ZeroInput_Button.Click += new System.EventHandler(this.ZeroInput_Button_Click);
            // 
            // NormalInput_Button
            // 
            this.NormalInput_Button.FlatAppearance.BorderSize = 0;
            this.NormalInput_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NormalInput_Button.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.NormalInput_Button.ForeColor = System.Drawing.SystemColors.Control;
            this.NormalInput_Button.Image = ((System.Drawing.Image)(resources.GetObject("NormalInput_Button.Image")));
            this.NormalInput_Button.Location = new System.Drawing.Point(16, 243);
            this.NormalInput_Button.Name = "NormalInput_Button";
            this.NormalInput_Button.Size = new System.Drawing.Size(308, 204);
            this.NormalInput_Button.TabIndex = 2;
            this.NormalInput_Button.Text = "Задать выражение с помощью введённых параметров";
            this.NormalInput_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.NormalInput_Button.UseVisualStyleBackColor = true;
            this.NormalInput_Button.Click += new System.EventHandler(this.NormalInput_Button_Click);
            // 
            // A_UserHelp
            // 
            this.A_UserHelp.AutoSize = true;
            this.A_UserHelp.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.A_UserHelp.ForeColor = System.Drawing.Color.Teal;
            this.A_UserHelp.Location = new System.Drawing.Point(595, 286);
            this.A_UserHelp.Name = "A_UserHelp";
            this.A_UserHelp.Size = new System.Drawing.Size(60, 18);
            this.A_UserHelp.TabIndex = 6;
            this.A_UserHelp.Text = "A (x^2)";
            this.A_UserHelp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // B_UserHelp
            // 
            this.B_UserHelp.AutoSize = true;
            this.B_UserHelp.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.B_UserHelp.ForeColor = System.Drawing.Color.Teal;
            this.B_UserHelp.Location = new System.Drawing.Point(820, 286);
            this.B_UserHelp.Name = "B_UserHelp";
            this.B_UserHelp.Size = new System.Drawing.Size(37, 18);
            this.B_UserHelp.TabIndex = 7;
            this.B_UserHelp.Text = "B(x)";
            // 
            // C_UserHelp
            // 
            this.C_UserHelp.AutoSize = true;
            this.C_UserHelp.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.C_UserHelp.ForeColor = System.Drawing.Color.Teal;
            this.C_UserHelp.Location = new System.Drawing.Point(1037, 286);
            this.C_UserHelp.Name = "C_UserHelp";
            this.C_UserHelp.Size = new System.Drawing.Size(20, 18);
            this.C_UserHelp.TabIndex = 8;
            this.C_UserHelp.Text = "C";
            // 
            // Discriminant_Label
            // 
            this.Discriminant_Label.AutoSize = true;
            this.Discriminant_Label.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.Discriminant_Label.ForeColor = System.Drawing.Color.Teal;
            this.Discriminant_Label.Location = new System.Drawing.Point(447, 665);
            this.Discriminant_Label.Name = "Discriminant_Label";
            this.Discriminant_Label.Size = new System.Drawing.Size(123, 18);
            this.Discriminant_Label.TabIndex = 9;
            this.Discriminant_Label.Text = "Дискриминант";
            this.Discriminant_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Discriminant_OutputBox
            // 
            this.Discriminant_OutputBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(109)))), ((int)(((byte)(126)))));
            this.Discriminant_OutputBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Discriminant_OutputBox.Location = new System.Drawing.Point(450, 621);
            this.Discriminant_OutputBox.Name = "Discriminant_OutputBox";
            this.Discriminant_OutputBox.ReadOnly = true;
            this.Discriminant_OutputBox.Size = new System.Drawing.Size(118, 29);
            this.Discriminant_OutputBox.TabIndex = 10;
            this.Discriminant_OutputBox.Text = "";
            // 
            // Equation_Label
            // 
            this.Equation_Label.AutoSize = true;
            this.Equation_Label.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.Equation_Label.ForeColor = System.Drawing.Color.Teal;
            this.Equation_Label.Location = new System.Drawing.Point(571, 665);
            this.Equation_Label.Name = "Equation_Label";
            this.Equation_Label.Size = new System.Drawing.Size(184, 18);
            this.Equation_Label.TabIndex = 11;
            this.Equation_Label.Text = "Общепринятая запись";
            this.Equation_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Equation_OutputBox
            // 
            this.Equation_OutputBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(109)))), ((int)(((byte)(126)))));
            this.Equation_OutputBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Equation_OutputBox.Location = new System.Drawing.Point(574, 621);
            this.Equation_OutputBox.Name = "Equation_OutputBox";
            this.Equation_OutputBox.ReadOnly = true;
            this.Equation_OutputBox.Size = new System.Drawing.Size(175, 29);
            this.Equation_OutputBox.TabIndex = 12;
            this.Equation_OutputBox.Text = "";
            // 
            // B_InputBox
            // 
            this.B_InputBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(109)))), ((int)(((byte)(126)))));
            this.B_InputBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.B_InputBox.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.B_InputBox.ForeColor = System.Drawing.SystemColors.Control;
            this.B_InputBox.Location = new System.Drawing.Point(789, 243);
            this.B_InputBox.Name = "B_InputBox";
            this.B_InputBox.Size = new System.Drawing.Size(100, 19);
            this.B_InputBox.TabIndex = 14;
            // 
            // C_InputBox
            // 
            this.C_InputBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(109)))), ((int)(((byte)(126)))));
            this.C_InputBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.C_InputBox.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.C_InputBox.ForeColor = System.Drawing.SystemColors.Control;
            this.C_InputBox.Location = new System.Drawing.Point(993, 243);
            this.C_InputBox.Name = "C_InputBox";
            this.C_InputBox.Size = new System.Drawing.Size(100, 19);
            this.C_InputBox.TabIndex = 15;
            // 
            // A_InputBox
            // 
            this.A_InputBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(109)))), ((int)(((byte)(126)))));
            this.A_InputBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.A_InputBox.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.A_InputBox.ForeColor = System.Drawing.SystemColors.Control;
            this.A_InputBox.Location = new System.Drawing.Point(574, 243);
            this.A_InputBox.Name = "A_InputBox";
            this.A_InputBox.Size = new System.Drawing.Size(100, 19);
            this.A_InputBox.TabIndex = 16;
            // 
            // Input_PictureBox_1
            // 
            this.Input_PictureBox_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(49)))));
            this.Input_PictureBox_1.ErrorImage = null;
            this.Input_PictureBox_1.Image = ((System.Drawing.Image)(resources.GetObject("Input_PictureBox_1.Image")));
            this.Input_PictureBox_1.InitialImage = null;
            this.Input_PictureBox_1.Location = new System.Drawing.Point(742, 25);
            this.Input_PictureBox_1.Name = "Input_PictureBox_1";
            this.Input_PictureBox_1.Size = new System.Drawing.Size(176, 176);
            this.Input_PictureBox_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Input_PictureBox_1.TabIndex = 17;
            this.Input_PictureBox_1.TabStop = false;
            // 
            // Output_PictureBox_1
            // 
            this.Output_PictureBox_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(49)))));
            this.Output_PictureBox_1.ErrorImage = null;
            this.Output_PictureBox_1.Image = ((System.Drawing.Image)(resources.GetObject("Output_PictureBox_1.Image")));
            this.Output_PictureBox_1.InitialImage = null;
            this.Output_PictureBox_1.Location = new System.Drawing.Point(742, 385);
            this.Output_PictureBox_1.Name = "Output_PictureBox_1";
            this.Output_PictureBox_1.Size = new System.Drawing.Size(176, 176);
            this.Output_PictureBox_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Output_PictureBox_1.TabIndex = 18;
            this.Output_PictureBox_1.TabStop = false;
            // 
            // Copy_button_click_highlight
            // 
            this.Copy_button_click_highlight.BackColor = System.Drawing.Color.Goldenrod;
            this.Copy_button_click_highlight.Location = new System.Drawing.Point(331, 507);
            this.Copy_button_click_highlight.Name = "Copy_button_click_highlight";
            this.Copy_button_click_highlight.Size = new System.Drawing.Size(20, 143);
            this.Copy_button_click_highlight.TabIndex = 19;
            this.Copy_button_click_highlight.TabStop = false;
            this.Copy_button_click_highlight.Visible = false;
            // 
            // Normal_button_click_highlight
            // 
            this.Normal_button_click_highlight.BackColor = System.Drawing.Color.Goldenrod;
            this.Normal_button_click_highlight.Location = new System.Drawing.Point(330, 269);
            this.Normal_button_click_highlight.Name = "Normal_button_click_highlight";
            this.Normal_button_click_highlight.Size = new System.Drawing.Size(21, 178);
            this.Normal_button_click_highlight.TabIndex = 20;
            this.Normal_button_click_highlight.TabStop = false;
            this.Normal_button_click_highlight.Visible = false;
            // 
            // Zero_button_click_highlight
            // 
            this.Zero_button_click_highlight.BackColor = System.Drawing.Color.Goldenrod;
            this.Zero_button_click_highlight.Location = new System.Drawing.Point(330, 86);
            this.Zero_button_click_highlight.Name = "Zero_button_click_highlight";
            this.Zero_button_click_highlight.Size = new System.Drawing.Size(20, 143);
            this.Zero_button_click_highlight.TabIndex = 21;
            this.Zero_button_click_highlight.TabStop = false;
            this.Zero_button_click_highlight.Visible = false;
            // 
            // FirstRoot_OutputBox
            // 
            this.FirstRoot_OutputBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(109)))), ((int)(((byte)(126)))));
            this.FirstRoot_OutputBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FirstRoot_OutputBox.Location = new System.Drawing.Point(869, 621);
            this.FirstRoot_OutputBox.Name = "FirstRoot_OutputBox";
            this.FirstRoot_OutputBox.ReadOnly = true;
            this.FirstRoot_OutputBox.Size = new System.Drawing.Size(118, 29);
            this.FirstRoot_OutputBox.TabIndex = 22;
            this.FirstRoot_OutputBox.Text = "";
            // 
            // FirstRoot_Label
            // 
            this.FirstRoot_Label.AutoSize = true;
            this.FirstRoot_Label.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.FirstRoot_Label.ForeColor = System.Drawing.Color.Teal;
            this.FirstRoot_Label.Location = new System.Drawing.Point(866, 665);
            this.FirstRoot_Label.Name = "FirstRoot_Label";
            this.FirstRoot_Label.Size = new System.Drawing.Size(126, 18);
            this.FirstRoot_Label.TabIndex = 23;
            this.FirstRoot_Label.Text = "Первый корень";
            this.FirstRoot_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SecondRoot_OutputBox
            // 
            this.SecondRoot_OutputBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(109)))), ((int)(((byte)(126)))));
            this.SecondRoot_OutputBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SecondRoot_OutputBox.Location = new System.Drawing.Point(993, 621);
            this.SecondRoot_OutputBox.Name = "SecondRoot_OutputBox";
            this.SecondRoot_OutputBox.ReadOnly = true;
            this.SecondRoot_OutputBox.Size = new System.Drawing.Size(118, 29);
            this.SecondRoot_OutputBox.TabIndex = 24;
            this.SecondRoot_OutputBox.Text = "";
            // 
            // SecondRoot_label
            // 
            this.SecondRoot_label.AutoSize = true;
            this.SecondRoot_label.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.SecondRoot_label.ForeColor = System.Drawing.Color.Teal;
            this.SecondRoot_label.Location = new System.Drawing.Point(998, 665);
            this.SecondRoot_label.Name = "SecondRoot_label";
            this.SecondRoot_label.Size = new System.Drawing.Size(123, 18);
            this.SecondRoot_label.TabIndex = 25;
            this.SecondRoot_label.Text = "Второй корень";
            this.SecondRoot_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(49)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1160, 727);
            this.Controls.Add(this.SecondRoot_label);
            this.Controls.Add(this.SecondRoot_OutputBox);
            this.Controls.Add(this.FirstRoot_Label);
            this.Controls.Add(this.FirstRoot_OutputBox);
            this.Controls.Add(this.Zero_button_click_highlight);
            this.Controls.Add(this.Normal_button_click_highlight);
            this.Controls.Add(this.Copy_button_click_highlight);
            this.Controls.Add(this.Output_PictureBox_1);
            this.Controls.Add(this.Input_PictureBox_1);
            this.Controls.Add(this.A_InputBox);
            this.Controls.Add(this.C_InputBox);
            this.Controls.Add(this.B_InputBox);
            this.Controls.Add(this.Equation_OutputBox);
            this.Controls.Add(this.Equation_Label);
            this.Controls.Add(this.Discriminant_OutputBox);
            this.Controls.Add(this.Discriminant_Label);
            this.Controls.Add(this.C_UserHelp);
            this.Controls.Add(this.B_UserHelp);
            this.Controls.Add(this.A_UserHelp);
            this.Controls.Add(this.NormalInput_Button);
            this.Controls.Add(this.ZeroInput_Button);
            this.Controls.Add(this.Copy_Button);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Корнышев В.Н. 3105-об 21 вар.";
            ((System.ComponentModel.ISupportInitialize)(this.Input_PictureBox_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Output_PictureBox_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Copy_button_click_highlight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Normal_button_click_highlight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Zero_button_click_highlight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Copy_Button;
        private System.Windows.Forms.Button ZeroInput_Button;
        private System.Windows.Forms.Button NormalInput_Button;
        private System.Windows.Forms.Label A_UserHelp;
        private System.Windows.Forms.Label B_UserHelp;
        private System.Windows.Forms.Label C_UserHelp;
        private System.Windows.Forms.Label Discriminant_Label;
        private System.Windows.Forms.RichTextBox Discriminant_OutputBox;
        private System.Windows.Forms.Label Equation_Label;
        private System.Windows.Forms.RichTextBox Equation_OutputBox;
        private System.Windows.Forms.TextBox B_InputBox;
        private System.Windows.Forms.TextBox C_InputBox;
        private System.Windows.Forms.TextBox A_InputBox;
        private System.Windows.Forms.PictureBox Input_PictureBox_1;
        private System.Windows.Forms.PictureBox Output_PictureBox_1;
        private System.Windows.Forms.PictureBox Copy_button_click_highlight;
        private System.Windows.Forms.PictureBox Zero_button_click_highlight;
        private System.Windows.Forms.PictureBox Normal_button_click_highlight;
        private System.Windows.Forms.RichTextBox FirstRoot_OutputBox;
        private System.Windows.Forms.Label FirstRoot_Label;
        private System.Windows.Forms.RichTextBox SecondRoot_OutputBox;
        private System.Windows.Forms.Label SecondRoot_label;
    }
}

