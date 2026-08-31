



abstract class AbstractBaseForm : Form{
    protected TableLayoutPanel MainLayout = new TableLayoutPanel();

    protected Button BtGetData = new Button();

    public AbstractBaseForm(): base() {
        MainLayout.SuspendLayout();
        SuspendLayout();

        // MainLayout
        MainLayout.AutoSize = true;
        MainLayout.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        MainLayout.ColumnCount = 1;
        MainLayout.ColumnStyles.Add(new ColumnStyle());
        MainLayout.Dock = DockStyle.Fill;

        // BtGetData
        BtGetData.AutoSize = true;
        BtGetData.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        BtGetData.Dock = DockStyle.Top;
        BtGetData.Text = "Выполнить/Сохранить";
        BtGetData.UseVisualStyleBackColor = true;
        BtGetData.Click += BtGetData_Click!; 

        Controls.Add(MainLayout);
        MainLayout.ResumeLayout(false);
        MainLayout.PerformLayout();
    }


    /// <summary> Обновление и получение данных </summary>
    public abstract void BtGetData_Click(object sender, EventArgs e);


    /// <summary> Добавление нового виджета </summary>
    public void AppendNewWidget(TableLayoutPanel NewWidgets){
        MainLayout.RowCount += 1;
        MainLayout.Controls.Add(NewWidgets, 0, MainLayout.RowCount - 1);
    }
}