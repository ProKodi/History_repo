



public partial class CalendarDialog : Form{
    public DateTime SelectedDate { get; private set; }

    public CalendarDialog(string title = "Выберите дату", DateTime? defaultDate = null){
        InitializeComponent(title, defaultDate ?? DateTime.Today);
    }

    private void InitializeComponent(string title, DateTime defaultDate)
    {
        this.Text = title;
        this.Size = new Size(300, 300);
        this.FormBorderStyle = FormBorderStyle.FixedDialog;
        this.StartPosition = FormStartPosition.CenterParent;
        this.MaximizeBox = false;
        this.MinimizeBox = false;
        this.TopMost = true;

        // MonthCalendar
        var monthCalendar = new MonthCalendar();
        monthCalendar.Location = new Point(10, 10);
        monthCalendar.Size = new Size(260, 160);
        monthCalendar.DateSelected += (s, e) => SelectedDate = e.Start;
        monthCalendar.SetDate(defaultDate);
        SelectedDate = defaultDate;
        this.Controls.Add(monthCalendar);

        // Текстовое поле для ручного ввода
        var textBox = new TextBox();
        textBox.Location = new Point(10, 180);
        textBox.Size = new Size(260, 23);
        textBox.Text = defaultDate.ToShortDateString();
        textBox.TextChanged += (s, e) =>
        {
            if (DateTime.TryParse(textBox.Text, out DateTime result))
            {
                monthCalendar.SetDate(result);
                SelectedDate = result;
            }
        };
        this.Controls.Add(textBox);

        // Кнопки
        var btnOk = new Button();
        btnOk.Text = "OK";
        btnOk.Location = new Point(120, 220);
        btnOk.Size = new Size(70, 30);
        btnOk.DialogResult = DialogResult.OK;
        this.Controls.Add(btnOk);

        var btnCancel = new Button();
        btnCancel.Text = "Отмена";
        btnCancel.Location = new Point(200, 220);
        btnCancel.Size = new Size(70, 30);
        btnCancel.DialogResult = DialogResult.Cancel;
        this.Controls.Add(btnCancel);

        // Обновление текстового поля при выборе даты в календаре
        monthCalendar.DateChanged += (s, e) => 
        {
            textBox.Text = monthCalendar.SelectionStart.ToShortDateString();
        };

        this.AcceptButton = btnOk;
        this.CancelButton = btnCancel;
    }
}