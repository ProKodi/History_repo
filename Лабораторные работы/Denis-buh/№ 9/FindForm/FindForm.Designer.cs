
partial class FindForm{
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
        this.label1 = new System.Windows.Forms.Label();
        this.name_found = new System.Windows.Forms.TextBox();
        this.find_obj = new System.Windows.Forms.Button();
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
        this.label1.Size = new System.Drawing.Size(79, 38);
        this.label1.TabIndex = 0;
        this.label1.Text = "Введите ФИО";
        // 
        // name_found
        // 
        this.name_found.Dock = System.Windows.Forms.DockStyle.Fill;
        this.name_found.Location = new System.Drawing.Point(88, 3);
        this.name_found.Name = "name_found";
        this.name_found.Size = new System.Drawing.Size(391, 20);
        this.name_found.TabIndex = 1;
        // 
        // find_obj
        // 
        this.find_obj.AutoSize = true;
        this.find_obj.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        this.find_obj.Location = new System.Drawing.Point(485, 3);
        this.find_obj.Name = "find_obj";
        this.find_obj.Size = new System.Drawing.Size(87, 23);
        this.find_obj.TabIndex = 2;
        this.find_obj.Text = "Найти объект";
        this.find_obj.UseVisualStyleBackColor = true;
        this.find_obj.Click += new System.EventHandler(this.find_obj_Click);
        // 
        // tableLayoutPanel1
        // 
        this.tableLayoutPanel1.AutoScroll = true;
        this.tableLayoutPanel1.AutoSize = true;
        this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        this.tableLayoutPanel1.ColumnCount = 3;
        this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
        this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
        this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
        this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
        this.tableLayoutPanel1.Controls.Add(this.find_obj, 2, 0);
        this.tableLayoutPanel1.Controls.Add(this.name_found, 1, 0);
        this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
        this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
        this.tableLayoutPanel1.Name = "tableLayoutPanel1";
        this.tableLayoutPanel1.RowCount = 1;
        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
        this.tableLayoutPanel1.Size = new System.Drawing.Size(575, 38);
        this.tableLayoutPanel1.TabIndex = 3;
        // 
        // Form1
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(575, 38);
        this.Controls.Add(this.tableLayoutPanel1);
        this.Name = "Form1";
        this.Text = "Поиск элемента";
        this.tableLayoutPanel1.ResumeLayout(false);
        this.tableLayoutPanel1.PerformLayout();
        this.ResumeLayout(false);
        this.PerformLayout();
    }
    #endregion
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox name_found;
    private System.Windows.Forms.Button find_obj;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
}


