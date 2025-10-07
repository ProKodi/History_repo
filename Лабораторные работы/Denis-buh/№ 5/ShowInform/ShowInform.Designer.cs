



partial class ShowInform{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing){
        if (disposing && (components != null)){components.Dispose();}
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent(){
        this.button_close = new System.Windows.Forms.Button();
        this.listBox1 = new System.Windows.Forms.ListBox();
        this.SuspendLayout();
        // 
        // button_close
        // 
        this.button_close.Location = new System.Drawing.Point(87, 243);
        this.button_close.Name = "button_close";
        this.button_close.Size = new System.Drawing.Size(113, 27);
        this.button_close.TabIndex = 0;
        this.button_close.Text = "Закрыть форму";
        this.button_close.UseVisualStyleBackColor = true;
        this.button_close.Click += new System.EventHandler(this.button_close_Click);
        // 
        // listBox1
        // 
        this.listBox1.HorizontalScrollbar = true;
        this.listBox1.FormattingEnabled = true;
        this.listBox1.Location = new System.Drawing.Point(282, 93);
        this.listBox1.Name = "listBox1";
        this.listBox1.Size = new System.Drawing.Size(393, 264);
        this.listBox1.TabIndex = 1;
        // 
        // ShowInform
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(920, 500);
        this.Controls.Add(this.listBox1);
        this.Controls.Add(this.button_close);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        this.Name = "ShowInform";
        this.Text = "ShowInform";
        this.Load += new System.EventHandler(this.ShowInform_Load);
        this.ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.Button button_close;
    private System.Windows.Forms.ListBox listBox1;
}
