
partial class Filter
{
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
        this.groupBox1 = new System.Windows.Forms.GroupBox();
        this.name_find = new System.Windows.Forms.TextBox();
        this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
        this.made_sort = new System.Windows.Forms.Button();
        this.groupBox1.SuspendLayout();
        this.tableLayoutPanel2.SuspendLayout();
        this.SuspendLayout();
        // 
        // label1
        // 
        this.label1.AutoSize = true;
        this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
        this.label1.Location = new System.Drawing.Point(3, 0);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(200, 26);
        this.label1.TabIndex = 4;
        this.label1.Text = "Введите имя (проверка на равенство)";
        // 
        // groupBox1
        // 
        this.groupBox1.AutoSize = true;
        this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        this.groupBox1.Controls.Add(this.tableLayoutPanel2);
        this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
        this.groupBox1.Location = new System.Drawing.Point(0, 0);
        this.groupBox1.Name = "groupBox1";
        this.groupBox1.Size = new System.Drawing.Size(583, 102);
        this.groupBox1.TabIndex = 5;
        this.groupBox1.TabStop = false;
        this.groupBox1.Text = "Фильтриция по имени";
        // 
        // name_find
        // 
        this.name_find.Dock = System.Windows.Forms.DockStyle.Fill;
        this.name_find.Location = new System.Drawing.Point(209, 3);
        this.name_find.Name = "name_find";
        this.name_find.Size = new System.Drawing.Size(365, 20);
        this.name_find.TabIndex = 6;
        // 
        // tableLayoutPanel2
        // 
        this.tableLayoutPanel2.AutoSize = true;
        this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        this.tableLayoutPanel2.ColumnCount = 2;
        this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
        this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
        this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
        this.tableLayoutPanel2.Controls.Add(this.name_find, 1, 0);
        this.tableLayoutPanel2.Controls.Add(this.made_sort, 0, 2);
        this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
        this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
        this.tableLayoutPanel2.Name = "tableLayoutPanel2";
        this.tableLayoutPanel2.RowCount = 3;
        this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
        this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
        this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
        this.tableLayoutPanel2.Size = new System.Drawing.Size(577, 83);
        this.tableLayoutPanel2.TabIndex = 9;
        // 
        // made_sort
        // 
        this.made_sort.AutoSize = true;
        this.made_sort.Location = new System.Drawing.Point(3, 55);
        this.made_sort.Name = "made_sort";
        this.made_sort.Size = new System.Drawing.Size(144, 17);
        this.made_sort.TabIndex = 9;
        this.made_sort.Text = "Применить сортировку";
        this.made_sort.UseVisualStyleBackColor = true;
        this.made_sort.Click += new System.EventHandler(this.madefulter);
        // 
        // Form1
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(583, 102);
        this.Controls.Add(this.groupBox1);
        this.Name = "Form1";
        this.Text = "Поиск элемента";
        this.groupBox1.ResumeLayout(false);
        this.groupBox1.PerformLayout();
        this.tableLayoutPanel2.ResumeLayout(false);
        this.tableLayoutPanel2.PerformLayout();
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    private System.Windows.Forms.TextBox name_find;
    private System.Windows.Forms.Button made_sort;
}


