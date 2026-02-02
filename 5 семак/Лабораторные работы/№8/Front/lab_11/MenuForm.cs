namespace lab_11
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void Specialties_Button_Click(object sender, EventArgs e)
        {
            SpecialtyStudentsForm specialtyStudentsForm = new SpecialtyStudentsForm();
            specialtyStudentsForm.Show();
        }

        private void Exams_Button_Click(object sender, EventArgs e)
        {
            StudentExamsForm studentExamsForm = new StudentExamsForm();
            studentExamsForm.Show();
        }
    }
}
