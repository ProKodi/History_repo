



partial class InputFile{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing){
        if (disposing && (components != null)){
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent(){
        this.text_for_file = new System.Windows.Forms.TextBox();
        this.save_file = new System.Windows.Forms.Button();
        this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
        this.tableLayoutPanel1.SuspendLayout();
        this.SuspendLayout();
        // 
        // text_for_file
        // 
        this.text_for_file.Dock = System.Windows.Forms.DockStyle.Fill;
        this.text_for_file.Location = new System.Drawing.Point(3, 3);
        this.text_for_file.Multiline = true;
        this.text_for_file.Name = "text_for_file";
        this.text_for_file.Size = new System.Drawing.Size(423, 103);
        this.text_for_file.TabIndex = 0;
        this.text_for_file.Text = "Введите сюда ваш текст";
        // 
        // save_file
        // 
        this.save_file.AutoSize = true;
        this.save_file.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        this.save_file.Dock = System.Windows.Forms.DockStyle.Fill;
        this.save_file.Location = new System.Drawing.Point(3, 112);
        this.save_file.Name = "save_file";
        this.save_file.Size = new System.Drawing.Size(423, 23);
        this.save_file.TabIndex = 1;
        this.save_file.Text = "Сохранить текст в файл";
        this.save_file.UseVisualStyleBackColor = true;
        this.save_file.Click += new System.EventHandler(this.save_file_Click);
        // 
        // tableLayoutPanel1
        // 
        this.tableLayoutPanel1.AutoSize = true;
        this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        this.tableLayoutPanel1.ColumnCount = 1;
        this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
        this.tableLayoutPanel1.Controls.Add(this.text_for_file, 0, 0);
        this.tableLayoutPanel1.Controls.Add(this.save_file, 0, 1);
        this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
        this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
        this.tableLayoutPanel1.Name = "tableLayoutPanel1";
        this.tableLayoutPanel1.RowCount = 2;
        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
        this.tableLayoutPanel1.Size = new System.Drawing.Size(429, 138);
        this.tableLayoutPanel1.TabIndex = 2;
        // 
        // InputFile
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(429, 138);
        this.Controls.Add(this.tableLayoutPanel1);
        this.Name = "InputFile";
        this.Text = "Сохранение файла";
        this.tableLayoutPanel1.ResumeLayout(false);
        this.tableLayoutPanel1.PerformLayout();
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox text_for_file;
    private System.Windows.Forms.Button save_file;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
}
