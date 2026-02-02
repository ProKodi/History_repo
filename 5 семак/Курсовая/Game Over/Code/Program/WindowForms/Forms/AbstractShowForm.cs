




abstract class AbstractShowForm: AbstractBaseForm{
    public AbstractShowForm(): base() {
        // MainLayout
        MainLayout.Controls.Add(BtGetData, 0, 0);
        MainLayout.RowCount = 1;
        MainLayout.RowStyles.Add(new RowStyle());
        MainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));


        // ShowForm
        AutoScaleMode = AutoScaleMode.Font;
        MinimumSize = new Size(500, 200);
        Text = "ShowForm";
        MainLayout.ResumeLayout(false);
        MainLayout.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }
}