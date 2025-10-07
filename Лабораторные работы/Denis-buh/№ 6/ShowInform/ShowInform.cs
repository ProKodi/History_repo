



public partial class ShowInform : Form{
    public ShowInform(){InitializeComponent();}

    public void AppendInform(List<string> inform){
        foreach (string i in inform){
            this.listBox1.Items.Add(i);
        }
    }

    public void AppendInform(string inform){
        this.listBox1.Items.Add(inform);
    }


    private void button_close_Click(object sender, EventArgs e){this.Close();}
}

