




partial class MainForm{
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
        this.append_item = new System.Windows.Forms.Button();
        this.delete_item = new System.Windows.Forms.Button();
        this.find_item = new System.Windows.Forms.Button();
        this.filtration_item = new System.Windows.Forms.Button();
        this.filtration_item2 = new System.Windows.Forms.Button();
        this.filtration_item3 = new System.Windows.Forms.Button();
        this.TableTree = new System.Windows.Forms.DataGridView();
        this.Name_table = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.Age_table = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.Number_cout_table = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.Name_group_table = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.Hp_table = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.groupBox1 = new System.Windows.Forms.GroupBox();
        this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
        this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
        ((System.ComponentModel.ISupportInitialize)(this.TableTree)).BeginInit();
        this.groupBox1.SuspendLayout();
        this.tableLayoutPanel1.SuspendLayout();
        this.tableLayoutPanel2.SuspendLayout();
        this.SuspendLayout();
        // 
        // append_item
        // 
        this.append_item.AutoSize = true;
        this.append_item.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        this.append_item.Dock = System.Windows.Forms.DockStyle.Fill;
        this.append_item.Location = new System.Drawing.Point(3, 3);
        this.append_item.Name = "append_item";
        this.append_item.Size = new System.Drawing.Size(138, 23);
        this.append_item.TabIndex = 0;
        this.append_item.Text = "Добавить элемент";
        this.append_item.UseVisualStyleBackColor = true;
        this.append_item.Click += new System.EventHandler(this.append_item_Click);
        // 
        // delete_item
        // 
        this.delete_item.AutoSize = true;
        this.delete_item.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        this.delete_item.Dock = System.Windows.Forms.DockStyle.Fill;
        this.delete_item.Location = new System.Drawing.Point(147, 3);
        this.delete_item.Name = "delete_item";
        this.delete_item.Size = new System.Drawing.Size(138, 23);
        this.delete_item.TabIndex = 1;
        this.delete_item.Text = "Удалить элемент";
        this.delete_item.UseVisualStyleBackColor = true;
        this.delete_item.Click += new System.EventHandler(this.delete_item_Click);
        // 
        // find_item
        // 
        this.find_item.AutoSize = true;
        this.find_item.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        this.find_item.Dock = System.Windows.Forms.DockStyle.Fill;
        this.find_item.Location = new System.Drawing.Point(291, 3);
        this.find_item.Name = "find_item";
        this.find_item.Size = new System.Drawing.Size(138, 23);
        this.find_item.TabIndex = 2;
        this.find_item.Text = "Поиск";
        this.find_item.UseVisualStyleBackColor = true;
        this.find_item.Click += new System.EventHandler(this.find_item_Click);
        // 
        // filtration_item
        // 
        this.filtration_item.AutoSize = true;
        this.filtration_item.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        this.filtration_item.Dock = System.Windows.Forms.DockStyle.Fill;
        this.filtration_item.Location = new System.Drawing.Point(435, 3);
        this.filtration_item.Name = "filtration_item";
        this.filtration_item.Size = new System.Drawing.Size(140, 23);
        this.filtration_item.TabIndex = 3;
        this.filtration_item.Text = "Фильтрация коллекции";
        this.filtration_item.UseVisualStyleBackColor = true;
        this.filtration_item.Click += new System.EventHandler(this.filtration_item_Click);
        // 
        // filtration_item2
        // 
        this.filtration_item2.AutoSize = true;
        this.filtration_item2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        this.filtration_item2.Dock = System.Windows.Forms.DockStyle.Fill;
        this.filtration_item2.Location = new System.Drawing.Point(435, 3);
        this.filtration_item2.Name = "filtration_item2";
        this.filtration_item2.Size = new System.Drawing.Size(140, 23);
        this.filtration_item2.TabIndex = 4;
        this.filtration_item2.Text = "Фильтрация коллекции2";
        this.filtration_item2.UseVisualStyleBackColor = true;
        this.filtration_item2.Click += new System.EventHandler(this.filtration_item2_Click);
        // 
        // filtration_item3
        // 
        this.filtration_item3.AutoSize = true;
        this.filtration_item3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        this.filtration_item3.Dock = System.Windows.Forms.DockStyle.Fill;
        this.filtration_item3.Location = new System.Drawing.Point(435, 3);
        this.filtration_item3.Name = "filtration_item3";
        this.filtration_item3.Size = new System.Drawing.Size(140, 23);
        this.filtration_item3.TabIndex = 5;
        this.filtration_item3.Text = "Вывести оригинальную коллекцию";
        this.filtration_item3.UseVisualStyleBackColor = true;
        this.filtration_item3.Click += new System.EventHandler(this.filtration_item3_Click);
        // 
        // TableTree
        // 
        this.TableTree.AllowUserToAddRows = false;
        this.TableTree.AllowUserToDeleteRows = false;
        this.TableTree.AllowUserToOrderColumns = true;
        this.TableTree.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        this.TableTree.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.TableTree.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
        this.Name_table,
        this.Age_table,
        this.Number_cout_table,
        this.Name_group_table,
        this.Hp_table});
        this.TableTree.Dock = System.Windows.Forms.DockStyle.Fill;
        this.TableTree.GridColor = System.Drawing.SystemColors.AppWorkspace;
        this.TableTree.Location = new System.Drawing.Point(3, 16);
        this.TableTree.Name = "TableTree";
        this.TableTree.ReadOnly = true;
        this.TableTree.Size = new System.Drawing.Size(572, 101);
        this.TableTree.TabIndex = 4;
        // 
        // Name_table
        // 
        this.Name_table.HeaderText = "ФИО";
        this.Name_table.Name = "Name_table";
        this.Name_table.ReadOnly = true;
        // 
        // Age_table
        // 
        this.Age_table.HeaderText = "Количество лет";
        this.Age_table.Name = "Age_table";
        this.Age_table.ReadOnly = true;
        // 
        // Number_cout_table
        // 
        this.Number_cout_table.HeaderText = "Номер курса";
        this.Number_cout_table.Name = "Number_cout_table";
        this.Number_cout_table.ReadOnly = true;
        // 
        // Name_group_table
        // 
        this.Name_group_table.HeaderText = "Номер группы";
        this.Name_group_table.Name = "Name_group_table";
        this.Name_group_table.ReadOnly = true;
        // 
        // Hp_table
        // 
        this.Hp_table.HeaderText = "Процент hp";
        this.Hp_table.Name = "Hp_table";
        this.Hp_table.ReadOnly = true;
        // 
        // groupBox1
        // 
        this.groupBox1.AutoSize = true;
        this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        this.groupBox1.Controls.Add(this.TableTree);
        this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
        this.groupBox1.Location = new System.Drawing.Point(3, 3);
        this.groupBox1.Name = "groupBox1";
        this.groupBox1.Size = new System.Drawing.Size(578, 120);
        this.groupBox1.TabIndex = 5;
        this.groupBox1.TabStop = false;
        this.groupBox1.Text = "Введеные данные";
        // 
        // tableLayoutPanel1
        // 
        this.tableLayoutPanel1.AutoSize = true;
        this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        this.tableLayoutPanel1.ColumnCount = 6;
        this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
        this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
        this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
        this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
        this.tableLayoutPanel1.Controls.Add(this.append_item, 0, 0);
        this.tableLayoutPanel1.Controls.Add(this.delete_item, 1, 0);
        this.tableLayoutPanel1.Controls.Add(this.filtration_item, 3, 0);
        this.tableLayoutPanel1.Controls.Add(this.filtration_item2, 4, 0);
        this.tableLayoutPanel1.Controls.Add(this.filtration_item3, 5, 0);
        this.tableLayoutPanel1.Controls.Add(this.find_item, 2, 0);
        this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
        this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 129);
        this.tableLayoutPanel1.Name = "tableLayoutPanel1";
        this.tableLayoutPanel1.RowCount = 1;
        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
        this.tableLayoutPanel1.Size = new System.Drawing.Size(578, 29);
        this.tableLayoutPanel1.TabIndex = 6;
        // 
        // tableLayoutPanel2
        // 
        this.tableLayoutPanel2.AutoSize = true;
        this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        this.tableLayoutPanel2.ColumnCount = 1;
        this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
        this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 1);
        this.tableLayoutPanel2.Controls.Add(this.groupBox1, 0, 0);
        this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
        this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
        this.tableLayoutPanel2.Name = "tableLayoutPanel2";
        this.tableLayoutPanel2.RowCount = 2;
        this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
        this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
        this.tableLayoutPanel2.Size = new System.Drawing.Size(584, 161);
        this.tableLayoutPanel2.TabIndex = 7;
        // 
        // Form1
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(584, 161);
        this.Controls.Add(this.tableLayoutPanel2);
        this.MinimumSize = new System.Drawing.Size(600, 200);
        this.Name = "Form1";
        this.Text = "Main form";
        ((System.ComponentModel.ISupportInitialize)(this.TableTree)).EndInit();
        this.groupBox1.ResumeLayout(false);
        this.tableLayoutPanel1.ResumeLayout(false);
        this.tableLayoutPanel1.PerformLayout();
        this.tableLayoutPanel2.ResumeLayout(false);
        this.tableLayoutPanel2.PerformLayout();
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button append_item;
    private System.Windows.Forms.Button delete_item;
    private System.Windows.Forms.Button find_item;
    private System.Windows.Forms.Button filtration_item;
    private System.Windows.Forms.Button filtration_item2;
    private System.Windows.Forms.Button filtration_item3;
    private System.Windows.Forms.DataGridView TableTree;
    private System.Windows.Forms.DataGridViewTextBoxColumn Name_table;
    private System.Windows.Forms.DataGridViewTextBoxColumn Age_table;
    private System.Windows.Forms.DataGridViewTextBoxColumn Number_cout_table;
    private System.Windows.Forms.DataGridViewTextBoxColumn Name_group_table;
    private System.Windows.Forms.DataGridViewTextBoxColumn Hp_table;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
}


