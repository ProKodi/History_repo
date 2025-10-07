



partial class MainForm{
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
        this.menuStrip1 = new System.Windows.Forms.MenuStrip();
        this.made_file = new System.Windows.Forms.ToolStripMenuItem();
        this.show_file = new System.Windows.Forms.ToolStripMenuItem();
        this.menuStrip1.SuspendLayout();
        this.SuspendLayout();
        // 
        // menuStrip1
        // 
        this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
        this.made_file,
        this.show_file});
        this.menuStrip1.Location = new System.Drawing.Point(0, 0);
        this.menuStrip1.Name = "menuStrip1";
        this.menuStrip1.Size = new System.Drawing.Size(800, 24);
        this.menuStrip1.TabIndex = 0;
        this.menuStrip1.Text = "menuStrip1";
        // 
        // made_file
        // 
        this.made_file.Name = "made_file";
        this.made_file.Size = new System.Drawing.Size(94, 20);
        this.made_file.Text = "Создать файл";
        this.made_file.Click += new System.EventHandler(this.made_file_Click);
        // 
        // show_file
        // 
        this.show_file.Name = "show_file";
        this.show_file.Size = new System.Drawing.Size(97, 20);
        this.show_file.Text = "Вывести файл";
        this.show_file.Click += new System.EventHandler(this.show_file_Click);
        // 
        // MainForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 450);
        this.Controls.Add(this.menuStrip1);
        this.MainMenuStrip = this.menuStrip1;
        this.Name = "MainForm";
        this.Text = "MainForm";
        this.menuStrip1.ResumeLayout(false);
        this.menuStrip1.PerformLayout();
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem made_file;
    private System.Windows.Forms.ToolStripMenuItem show_file;
}
