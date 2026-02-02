namespace Connection_lab
{
    partial class AvgMarkForm
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
            AvgMarkCalc = new Button();
            AvgMarkDataGrid = new DataGridView();
            StudentIdent = new DataGridViewTextBoxColumn();
            AvgMarkIndivCollumn = new DataGridViewTextBoxColumn();
            AvgMarkBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)AvgMarkDataGrid).BeginInit();
            SuspendLayout();
            // 
            // AvgMarkCalc
            // 
            AvgMarkCalc.FlatAppearance.BorderSize = 0;
            AvgMarkCalc.FlatStyle = FlatStyle.Flat;
            AvgMarkCalc.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            AvgMarkCalc.ForeColor = SystemColors.Control;
            AvgMarkCalc.Location = new Point(31, 21);
            AvgMarkCalc.Name = "AvgMarkCalc";
            AvgMarkCalc.Size = new Size(372, 106);
            AvgMarkCalc.TabIndex = 1;
            AvgMarkCalc.Text = "Рассчитать средним балл по всем студентам:";
            AvgMarkCalc.UseVisualStyleBackColor = true;
            AvgMarkCalc.Click += AvgMarkCalc_Click;
            // 
            // AvgMarkDataGrid
            // 
            AvgMarkDataGrid.BorderStyle = BorderStyle.None;
            AvgMarkDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AvgMarkDataGrid.Columns.AddRange(new DataGridViewColumn[] { StudentIdent, AvgMarkIndivCollumn });
            AvgMarkDataGrid.Location = new Point(31, 133);
            AvgMarkDataGrid.Name = "AvgMarkDataGrid";
            AvgMarkDataGrid.ReadOnly = true;
            AvgMarkDataGrid.Size = new Size(757, 305);
            AvgMarkDataGrid.TabIndex = 2;
            // 
            // StudentIdent
            // 
            StudentIdent.HeaderText = "ФИО студента";
            StudentIdent.Name = "StudentIdent";
            StudentIdent.ReadOnly = true;
            // 
            // AvgMarkIndivCollumn
            // 
            AvgMarkIndivCollumn.HeaderText = "Средний балл студента";
            AvgMarkIndivCollumn.Name = "AvgMarkIndivCollumn";
            AvgMarkIndivCollumn.ReadOnly = true;
            // 
            // AvgMarkBox
            // 
            AvgMarkBox.BackColor = SystemColors.ControlDarkDark;
            AvgMarkBox.BorderStyle = BorderStyle.None;
            AvgMarkBox.Font = new Font("Segoe UI", 18F);
            AvgMarkBox.ForeColor = SystemColors.Control;
            AvgMarkBox.Location = new Point(409, 55);
            AvgMarkBox.Name = "AvgMarkBox";
            AvgMarkBox.ReadOnly = true;
            AvgMarkBox.Size = new Size(379, 32);
            AvgMarkBox.TabIndex = 3;
            AvgMarkBox.Text = "Тут будет средний балл по всем";
            // 
            // AvgMarkForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(800, 450);
            Controls.Add(AvgMarkBox);
            Controls.Add(AvgMarkDataGrid);
            Controls.Add(AvgMarkCalc);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "AvgMarkForm";
            Opacity = 0.95D;
            Text = "AvgMarkForm";
            ((System.ComponentModel.ISupportInitialize)AvgMarkDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AvgMarkCalc;
        private DataGridView AvgMarkDataGrid;
        private TextBox AvgMarkBox;
        private DataGridViewTextBoxColumn StudentIdent;
        private DataGridViewTextBoxColumn AvgMarkIndivCollumn;
    }
}