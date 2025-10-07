



public partial class MainWindow : Form{
    public MainWindow(){
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e){
        this.Close();
    }

    private void MainWindow_Load(object sender, EventArgs e)
    {
        System.Drawing.Drawing2D.GraphicsPath myPath =
            new System.Drawing.Drawing2D.GraphicsPath();
        // создаем эллипс с высотой и шириной формы
        myPath.AddEllipse(0, 0, this.Width, this.Height);
        // создаем с помощью элипса ту область формы, которую мы хотим видеть
        Region myRegion = new Region(myPath);
        // устанавливаем видимую область
        this.Region = myRegion;
    }

    private void show_Patient_Hospital_Click(object sender, EventArgs e){
        List <string> list = [
            (new Patient_Hospital(new DateOnly(2000, 10, 6), "мужчина", "Олегович",
                "Олег", "098x80086", new DateOnly(2020, 10, 6))).toStr(),
            (new Patient_Hospital(new DateOnly(1999, 7, 6), "женщина", "Бомбат",
                "Ольга", "028x8976", new DateOnly(2022, 10, 6))).toStr(),
            (new Patient_Hospital(new DateOnly(2002, 8, 7), "мужчина", "Михалович",
                "Михаил", "098x866", new DateOnly(2023, 10, 6))).toStr(),
            (new Patient_Hospital(new DateOnly(2001, 12, 6), "женщина", "Михалович",
                "Аня", "098x8976", new DateOnly(2022, 10, 6))).toStr(),
            (new Patient_Hospital(new DateOnly(2001, 9, 26), "мужчина", "Бомбатович",
                "Омуэл", "098x8976", new DateOnly(2022, 11, 26))).toStr(),
            (new Patient_Hospital(new DateOnly(2011, 12, 6), "женщина", "Олегович",
                "Ина", "098x8236", new DateOnly(2024, 3, 2))).toStr(),
        ]; 
        ShowInform form = new ShowInform();
        form.AppendInform(list);
        form.ShowDialog(this);

    }

    private void show_Doctor_Click(object sender, EventArgs e){
        List <Doctor> list = [
            new Doctor(new DateOnly(2000, 10, 6), "мужчина", "Олегович",
                "Олег", "Терапевт", "врач обыкновенный"),
            new Doctor(new DateOnly(1999, 7, 6), "женщина", "Бомбат",
                "Ольга", "Хирург", "глав-врач"),
            new Doctor(new DateOnly(2002, 8, 7), "мужчина", "Михалович",
                "Михаил", "Дерматолог", "заместитель главного врача"),
            new Doctor(new DateOnly(2001, 12, 6), "женщина", "Михалович",
                "Аня", "Нарколог", "врач нарколог"),
            new Doctor(new DateOnly(2001, 9, 26), "мужчина", "Бомбатович",
                "Омуэл", "Фельшер", "медбрат"),
            new Doctor(new DateOnly(2011, 12, 6), "женщина", "Олегович",
                "Ина", "Окулист", "заведующая"),
        ]; 

        ShowInform form = new ShowInform();

        if (this.delete_terapeft.Checked){
            for (int i = 0; i < list.Count; i += 1){
                if (list[i].Speciality == "Терапевт"){list.RemoveAt(i);}
            }
        }

        foreach (Doctor i in list){
            form.AppendInform(i.Inform());
        }
        form.ShowDialog(this);

    }

    private void show_Patient_Polyclinics_Click(object sender, EventArgs e){
        List <Patient_Polyclinics> list = [
            new Patient_Polyclinics(new DateOnly(2000, 10, 6), "мужчина", "Олегович",
                "Олег", new DateOnly(2024, 9, 6), true),
            new Patient_Polyclinics(new DateOnly(1999, 7, 6), "женщина", "Бомбат",
                "Ольга", new DateOnly(2024, 3, 6), true),
            new Patient_Polyclinics(new DateOnly(2002, 8, 7), "мужчина", "Михалович",
                "Михаил", new DateOnly(2023, 3, 6), false),
            new Patient_Polyclinics(new DateOnly(2001, 12, 6), "женщина", "Михалович",
                "Аня", new DateOnly(2003, 3, 6), true),
            new Patient_Polyclinics(new DateOnly(2001, 9, 26), "мужчина", "Бомбатович",
                "Омуэл", new DateOnly(2023, 6, 6), true),
            new Patient_Polyclinics(new DateOnly(2011, 12, 6), "женщина", "Олегович",
                "Ина", new DateOnly(2023, 6, 16), false),
        ]; 
        ShowInform form = new ShowInform();

        foreach (Patient_Polyclinics i in list){
            form.AppendInform(i.Inform());
        }
        form.ShowDialog(this);
    }
}

