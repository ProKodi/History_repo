



public partial class MainWindow : Form{
    public MainWindow(){InitializeComponent();}

    private void show_Patient_Hospital_Click(object sender, EventArgs e){
        List <Human> list = new List<Human>(Exemple.Get_Patient_Polyclinics());
        Sorted.Sort(list, 0, list.Count-1);

        ShowInform form = new ShowInform();
        foreach (Patient_Polyclinics i in list){ 
            i.Inform += NewClass.GetSN; 
            form.AppendInform(i.get_inform());
        }
        form.ShowDialog(this);
    }

    private void show_Doctor_Click(object sender, EventArgs e){
        List <Human> list = new List<Human>(Exemple.Get_Patient_Polyclinics());
        Sorted.Sort(list, 0, list.Count-1);

        ShowInform form = new ShowInform();
        foreach (Patient_Polyclinics i in list){ 
            i.Inform += NewClass.GetSNR; 
            form.AppendInform(i.get_inform());
        }
        form.ShowDialog(this);
    }

    private void show_Patient_Polyclinics_Click(object sender, EventArgs e){
        List <Human> list = new List<Human>(Exemple.Get_Patient_Polyclinics());
        Sorted.Sort(list, 0, list.Count-1);

        ShowInform form = new ShowInform();
        foreach (Patient_Polyclinics i in list){ 
            form.AppendInform(i.get_inform());
        }
        form.ShowDialog(this);
    }
}

