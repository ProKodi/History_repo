



partial class MainWindow{
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
        this.delete_terapeft = new System.Windows.Forms.CheckBox();
        this.show_Patient_Polyclinics = new System.Windows.Forms.Button();
        this.button1 = new System.Windows.Forms.Button();
        this.SuspendLayout();
        // 
        // show_Patient_Hospital
        // 
        this.show_Patient_Hospital.Location = new System.Drawing.Point(116, 82);
        this.show_Patient_Hospital.Name = "show_Patient_Hospital";
        this.show_Patient_Hospital.Size = new System.Drawing.Size(246, 23);
        this.show_Patient_Hospital.TabIndex = 0;
        this.show_Patient_Hospital.Text = "Вывести список пациентов больницы";
        this.show_Patient_Hospital.UseVisualStyleBackColor = true;
        this.show_Patient_Hospital.Click += new System.EventHandler(this.show_Patient_Hospital_Click);
        // 
        // show_Doctor
        // 
        this.show_Doctor.Location = new System.Drawing.Point(117, 112);
        this.show_Doctor.Name = "show_Doctor";
        this.show_Doctor.Size = new System.Drawing.Size(245, 23);
        this.show_Doctor.TabIndex = 1;
        this.show_Doctor.Text = "Вывести список врачей";
        this.show_Doctor.UseVisualStyleBackColor = true;
        this.show_Doctor.Click += new System.EventHandler(this.show_Doctor_Click);
        // 
        // delete_terapeft
        // 
        this.delete_terapeft.AutoSize = true;
        this.delete_terapeft.Location = new System.Drawing.Point(368, 112);
        this.delete_terapeft.Name = "delete_terapeft";
        this.delete_terapeft.Size = new System.Drawing.Size(130, 17);
        this.delete_terapeft.TabIndex = 2;
        this.delete_terapeft.Text = "Удалить терапевтов";
        this.delete_terapeft.UseVisualStyleBackColor = true;
        // 
        // show_Patient_Polyclinics
        // 
        this.show_Patient_Polyclinics.Location = new System.Drawing.Point(116, 142);
        this.show_Patient_Polyclinics.Name = "show_Patient_Polyclinics";
        this.show_Patient_Polyclinics.Size = new System.Drawing.Size(246, 23);
        this.show_Patient_Polyclinics.TabIndex = 3;
        this.show_Patient_Polyclinics.Text = "Вывести пациентов поликлиники";
        this.show_Patient_Polyclinics.UseVisualStyleBackColor = true;
        this.show_Patient_Polyclinics.Click += new System.EventHandler(this.show_Patient_Polyclinics_Click);
        // 
        // button1
        // 
        this.button1.Location = new System.Drawing.Point(116, 181);
        this.button1.Name = "button1";
        this.button1.Size = new System.Drawing.Size(246, 23);
        this.button1.TabIndex = 4;
        this.button1.Text = "Закрыть окно";
        this.button1.UseVisualStyleBackColor = true;
        this.button1.Click += new System.EventHandler(this.button1_Click);
        // 
        // MainWindow
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(642, 234);
        this.Controls.Add(this.button1);
        this.Controls.Add(this.show_Patient_Polyclinics);
        this.Controls.Add(this.delete_terapeft);
        this.Controls.Add(this.show_Doctor);
        this.Controls.Add(this.show_Patient_Hospital);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        this.MinimumSize = new System.Drawing.Size(500, 150);
        this.Name = "MainWindow";
        this.Text = "MainWindow";
        this.Load += new System.EventHandler(this.MainWindow_Load);
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button show_Patient_Hospital;
    private System.Windows.Forms.Button show_Doctor;
    private System.Windows.Forms.CheckBox delete_terapeft;
    private System.Windows.Forms.Button show_Patient_Polyclinics;
    private System.Windows.Forms.Button button1;
}
