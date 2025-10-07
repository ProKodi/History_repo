



partial class ShowFile{
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
        this.label1 = new System.Windows.Forms.Label();
        this.text_file = new System.Windows.Forms.TextBox();
        this.cout_words = new System.Windows.Forms.Label();
        this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
        this.tableLayoutPanel1.SuspendLayout();
        this.SuspendLayout();
        // 
        // label1
        // 
        this.label1.AutoSize = true;
        this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
        this.label1.Location = new System.Drawing.Point(3, 0);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(404, 13);
        this.label1.TabIndex = 0;
        this.label1.Text = "Текст файла";
        // 
        // text_file
        // 
        this.text_file.Dock = System.Windows.Forms.DockStyle.Fill;
        this.text_file.Location = new System.Drawing.Point(3, 16);
        this.text_file.Multiline = true;
        this.text_file.Name = "text_file";
        this.text_file.ReadOnly = true;
        this.text_file.Size = new System.Drawing.Size(404, 126);
        this.text_file.TabIndex = 1;
        // 
        // cout_words
        // 
        this.cout_words.AutoSize = true;
        this.cout_words.Dock = System.Windows.Forms.DockStyle.Fill;
        this.cout_words.Location = new System.Drawing.Point(3, 145);
        this.cout_words.Name = "cout_words";
        this.cout_words.Size = new System.Drawing.Size(404, 13);
        this.cout_words.TabIndex = 2;
        this.cout_words.Text = "Количество слов  начинающихся и оканчивающихся гласными: ";
        // 
        // tableLayoutPanel1
        // 
        this.tableLayoutPanel1.AutoSize = true;
        this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        this.tableLayoutPanel1.ColumnCount = 1;
        this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
        this.tableLayoutPanel1.Controls.Add(this.cout_words, 0, 2);
        this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
        this.tableLayoutPanel1.Controls.Add(this.text_file, 0, 1);
        this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
        this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
        this.tableLayoutPanel1.Name = "tableLayoutPanel1";
        this.tableLayoutPanel1.RowCount = 3;
        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
        this.tableLayoutPanel1.Size = new System.Drawing.Size(410, 158);
        this.tableLayoutPanel1.TabIndex = 3;
        // 
        // ShowFile
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(410, 158);
        this.Controls.Add(this.tableLayoutPanel1);
        this.Name = "ShowFile";
        this.Text = "Просмотр файла";
        this.tableLayoutPanel1.ResumeLayout(false);
        this.tableLayoutPanel1.PerformLayout();
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox text_file;
    private System.Windows.Forms.Label cout_words;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
}
