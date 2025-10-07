


 partial class FindForm : Form{
    public bool flag = false;
    public FindForm(){InitializeComponent();}

    private void find_obj_Click(object sender, EventArgs e){
        this.flag = true;
        this.Close();
    }

    public string Name_found{get{return this.name_found.Text;}}
}

