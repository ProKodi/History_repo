



partial class MainWindow
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
            this.show_Patient_Hospital = new System.Windows.Forms.Button();
            this.show_Doctor = new System.Windows.Forms.Button();
            this.show_Patient_Polyclinics = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // show_Patient_Hospital
            // 
            this.show_Patient_Hospital.AutoSize = true;
            this.show_Patient_Hospital.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.show_Patient_Hospital.Dock = System.Windows.Forms.DockStyle.Fill;
            this.show_Patient_Hospital.Location = new System.Drawing.Point(3, 3);
            this.show_Patient_Hospital.Name = "show_Patient_Hospital";
            this.show_Patient_Hospital.Size = new System.Drawing.Size(472, 23);
            this.show_Patient_Hospital.TabIndex = 0;
            this.show_Patient_Hospital.Text = "Вывести пациентов поликлиники (вывод фамилии и имени)";
            this.show_Patient_Hospital.UseVisualStyleBackColor = true;
            this.show_Patient_Hospital.Click += new System.EventHandler(this.show_Patient_Hospital_Click);
            // 
            // show_Doctor
            // 
            this.show_Doctor.AutoSize = true;
            this.show_Doctor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.show_Doctor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.show_Doctor.Location = new System.Drawing.Point(3, 3);
            this.show_Doctor.Name = "show_Doctor";
            this.show_Doctor.Size = new System.Drawing.Size(138, 23);
            this.show_Doctor.TabIndex = 1;
            this.show_Doctor.Text = "Вывести пациентов поликлиники (вывод фамилии, имени и статуса диспансерного учета)";
            this.show_Doctor.UseVisualStyleBackColor = true;
            this.show_Doctor.Click += new System.EventHandler(this.show_Doctor_Click);
            // 
            // show_Patient_Polyclinics
            // 
            this.show_Patient_Polyclinics.AutoSize = true;
            this.show_Patient_Polyclinics.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.show_Patient_Polyclinics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.show_Patient_Polyclinics.Location = new System.Drawing.Point(3, 67);
            this.show_Patient_Polyclinics.Name = "show_Patient_Polyclinics";
            this.show_Patient_Polyclinics.Size = new System.Drawing.Size(472, 23);
            this.show_Patient_Polyclinics.TabIndex = 3;
            this.show_Patient_Polyclinics.Text = "Вывести пациентов поликлиники (вывод всей информации)";
            this.show_Patient_Polyclinics.UseVisualStyleBackColor = true;
            this.show_Patient_Polyclinics.Click += new System.EventHandler(this.show_Patient_Polyclinics_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.show_Patient_Hospital, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.show_Doctor, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.show_Patient_Polyclinics, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(478, 142);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(484, 161);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выберете действие";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 161);
            this.Controls.Add(this.groupBox1);
            this.MinimumSize = new System.Drawing.Size(500, 200);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button show_Patient_Hospital;
    private System.Windows.Forms.Button show_Doctor;
    private System.Windows.Forms.Button show_Patient_Polyclinics;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.GroupBox groupBox1;
}
