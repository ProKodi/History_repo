namespace Connection_lab
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void EditingData_Click(object sender, EventArgs e)
        {
            EditingAndViewingForm editingAndViewingForm = new EditingAndViewingForm();
            editingAndViewingForm.Show();
        }

        private void PRequest_Click(object sender, EventArgs e)
        {
            PRequestForm pRequestForm = new PRequestForm();
            pRequestForm.Show();
        }

        private void AvgMarkButton_Click(object sender, EventArgs e)
        {
            AvgMarkForm avgMarkForm = new AvgMarkForm();
            avgMarkForm.Show();
        }
    }
}
