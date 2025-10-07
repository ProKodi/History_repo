


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
        this.groupBox1 = new System.Windows.Forms.GroupBox();
        this.groupBox2 = new System.Windows.Forms.GroupBox();
        this.splitContainer1 = new System.Windows.Forms.SplitContainer();
        this.text_before = new System.Windows.Forms.TextBox();
        this.text_after = new System.Windows.Forms.TextBox();
        this.groupBox1.SuspendLayout();
        this.groupBox2.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
        this.splitContainer1.Panel1.SuspendLayout();
        this.splitContainer1.Panel2.SuspendLayout();
        this.splitContainer1.SuspendLayout();
        this.SuspendLayout();
        // 
        // groupBox1
        // 
        this.groupBox1.AutoSize = true;
        this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        this.groupBox1.Controls.Add(this.text_before);
        this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
        this.groupBox1.Location = new System.Drawing.Point(0, 0);
        this.groupBox1.Name = "groupBox1";
        this.groupBox1.Size = new System.Drawing.Size(338, 271);
        this.groupBox1.TabIndex = 2;
        this.groupBox1.TabStop = false;
        this.groupBox1.Text = "";
        // 
        // groupBox2
        // 
        this.groupBox2.AutoSize = true;
        this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        this.groupBox2.Controls.Add(this.text_after);
        this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
        this.groupBox2.Location = new System.Drawing.Point(0, 0);
        this.groupBox2.Name = "groupBox2";
        this.groupBox2.Size = new System.Drawing.Size(364, 271);
        this.groupBox2.TabIndex = 3;
        this.groupBox2.TabStop = false;
        this.groupBox2.Text = "";
        // 
        // splitContainer1
        // 
        this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
        this.splitContainer1.Location = new System.Drawing.Point(0, 0);
        this.splitContainer1.Name = "splitContainer1";
        // 
        // splitContainer1.Panel1
        // 
        this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
        // 
        // splitContainer1.Panel2
        // 
        this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
        this.splitContainer1.Size = new System.Drawing.Size(706, 271);
        this.splitContainer1.SplitterDistance = 338;
        this.splitContainer1.TabIndex = 4;
        // 
        // text_before
        // 
        this.text_before.Dock = System.Windows.Forms.DockStyle.Fill;
        this.text_before.Location = new System.Drawing.Point(3, 16);
        this.text_before.Multiline = true;
        this.text_before.Name = "text_before";
        this.text_before.ReadOnly = true;
        this.text_before.Size = new System.Drawing.Size(332, 252);
        this.text_before.TabIndex = 0;
        // 
        // text_after
        // 
        this.text_after.Dock = System.Windows.Forms.DockStyle.Fill;
        this.text_after.Location = new System.Drawing.Point(3, 16);
        this.text_after.Multiline = true;
        this.text_after.Name = "text_after";
        this.text_after.ReadOnly = true;
        this.text_after.Size = new System.Drawing.Size(358, 252);
        this.text_after.TabIndex = 0;
        // 
        // ShowFile
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(706, 271);
        this.Controls.Add(this.splitContainer1);
        this.Name = "ShowFile";
        this.Text = "Вывод файла";
        this.groupBox1.ResumeLayout(false);
        this.groupBox1.PerformLayout();
        this.groupBox2.ResumeLayout(false);
        this.groupBox2.PerformLayout();
        this.splitContainer1.Panel1.ResumeLayout(false);
        this.splitContainer1.Panel1.PerformLayout();
        this.splitContainer1.Panel2.ResumeLayout(false);
        this.splitContainer1.Panel2.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
        this.splitContainer1.ResumeLayout(false);
        this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.SplitContainer splitContainer1;
    private System.Windows.Forms.TextBox text_before;
    private System.Windows.Forms.TextBox text_after;
}