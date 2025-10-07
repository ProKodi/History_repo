
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
        this.text_file = new System.Windows.Forms.TextBox();
        this.save_file = new System.Windows.Forms.Button();
        this.groupBox1 = new System.Windows.Forms.GroupBox();
        this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
        this.groupBox1.SuspendLayout();
        this.tableLayoutPanel1.SuspendLayout();
        this.SuspendLayout();
        // 
        // text_file
        // 
        this.text_file.Dock = System.Windows.Forms.DockStyle.Fill;
        this.text_file.Location = new System.Drawing.Point(3, 16);
        this.text_file.Multiline = true;
        this.text_file.ScrollBars = System.Windows.Forms.ScrollBars.Both;
        this.text_file.Name = "text_file";
        this.text_file.Size = new System.Drawing.Size(500, 143);
        this.text_file.TabIndex = 0;
        // 
        // save_file
        // 
        this.save_file.AutoSize = true;
        this.save_file.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        this.save_file.Dock = System.Windows.Forms.DockStyle.Fill;
        this.save_file.Location = new System.Drawing.Point(3, 171);
        this.save_file.Name = "save_file";
        this.save_file.Size = new System.Drawing.Size(506, 23);
        this.save_file.TabIndex = 1;
        this.save_file.Text = "Сохранить файл";
        this.save_file.UseVisualStyleBackColor = true;
        this.save_file.Click += new System.EventHandler(this.save_file_Click);
        // 
        // groupBox1
        // 
        this.groupBox1.AutoSize = true;
        this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        this.groupBox1.Controls.Add(this.text_file);
        this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
        this.groupBox1.Location = new System.Drawing.Point(3, 3);
        this.groupBox1.Name = "groupBox1";
        this.groupBox1.Size = new System.Drawing.Size(506, 162);
        this.groupBox1.TabIndex = 2;
        this.groupBox1.TabStop = false;
        this.groupBox1.Text = "Текст для файла";
        // 
        // tableLayoutPanel1
        // 
        this.tableLayoutPanel1.AutoSize = true;
        this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        this.tableLayoutPanel1.ColumnCount = 1;
        this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
        this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
        this.tableLayoutPanel1.Controls.Add(this.save_file, 0, 1);
        this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
        this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
        this.tableLayoutPanel1.Name = "tableLayoutPanel1";
        this.tableLayoutPanel1.RowCount = 2;
        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
        this.tableLayoutPanel1.Size = new System.Drawing.Size(512, 197);
        this.tableLayoutPanel1.TabIndex = 3;
        // 
        // InputFile
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(512, 197);
        this.Controls.Add(this.tableLayoutPanel1);
        this.Name = "InputFile";
        this.Text = "Ввод файла";
        this.groupBox1.ResumeLayout(false);
        this.groupBox1.PerformLayout();
        this.tableLayoutPanel1.ResumeLayout(false);
        this.tableLayoutPanel1.PerformLayout();
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox text_file;
    private System.Windows.Forms.Button save_file;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
}
