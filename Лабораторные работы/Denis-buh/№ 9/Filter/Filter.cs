



partial class Filter : Form{
    public Filter(){
        InitializeComponent();
    }

    public Filter_Function? fultrete = null; 

    private void madefulter(object sender, EventArgs e){
        if(this.fultrete is not null){
            this.fultrete(); 
        }
    }

    public string Name_find{get{return this.name_find.Text;}}
    
}

