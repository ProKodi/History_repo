




abstract class AbstractTableForm : AbstractBaseForm{
    protected TableLayoutPanel LayoutGetData = new TableLayoutPanel();

    protected GroupBox DataBox = new GroupBox();
    protected DataGridView DataGrid = new DataGridView();


    public AbstractTableForm(): base() {
        LayoutGetData.SuspendLayout();
        DataBox.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)DataGrid).BeginInit();

        // LayoutGetData
        LayoutGetData.AutoSize = true;
        LayoutGetData.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        LayoutGetData.ColumnCount = 6;
        LayoutGetData.ColumnStyles.Add(new ColumnStyle());
        LayoutGetData.ColumnStyles.Add(new ColumnStyle());
        LayoutGetData.ColumnStyles.Add(new ColumnStyle());
        LayoutGetData.ColumnStyles.Add(new ColumnStyle());
        LayoutGetData.ColumnStyles.Add(new ColumnStyle());
        LayoutGetData.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 90F));
        LayoutGetData.Controls.Add(BtGetData, 0, 0);

        LayoutGetData.Dock = DockStyle.Top;
        LayoutGetData.RowCount = 1;
        LayoutGetData.RowStyles.Add(new RowStyle());


        // MainLayout
        MainLayout.Controls.Add(DataBox, 0, 0);
        MainLayout.Controls.Add(LayoutGetData, 0, 1);
        MainLayout.RowCount = 2;
        MainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        MainLayout.RowStyles.Add(new RowStyle());
        MainLayout.RowStyles.Add(new RowStyle());

        // DataBox
        DataBox.AutoSize = true;
        DataBox.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        DataBox.Controls.Add(DataGrid);
        DataBox.Dock = DockStyle.Fill;
        DataBox.TabIndex = 8;
        DataBox.TabStop = false;
        DataBox.Text = "Таблица с данными";

        // DataGrid
        DataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        DataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        DataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        DataGrid.Dock = DockStyle.Fill;


        // TableForm
        AutoScaleMode = AutoScaleMode.Font;
        MinimumSize = new Size(800, 200);
        Text = "TableForm";
        LayoutGetData.ResumeLayout(false);
        LayoutGetData.PerformLayout();
        DataBox.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)DataGrid).EndInit();

        ResumeLayout(false);
        PerformLayout();
    }


    protected void DataGridSetColumn(bool onlyread, params string[] strings){
        var ArrayColumn = new DataGridViewColumn[strings.Length];

        for(uint i = 0; i < strings.Length; i += 1){
            var colum = new DataGridViewTextBoxColumn();
            colum.HeaderText = strings[i];
            colum.ReadOnly = onlyread;

            ArrayColumn[i] = colum;
        }
        DataGrid.Columns.Clear();
        DataGrid.Columns.AddRange(ArrayColumn);
    }

    protected void DataGridSetColumn(params string[] strings){ this.DataGridSetColumn(true, strings); }


}
