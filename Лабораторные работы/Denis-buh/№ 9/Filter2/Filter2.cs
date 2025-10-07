



partial class Filter2 : Form{
    public Filter2(){InitializeComponent();}

    public int Age_find{get{return (int)this.age_find.Value;}}

    public Filter_Function? fultrete = null; 

    private void madefulter(object sender, EventArgs e){
        if(this.fultrete is not null){
            this.fultrete(); 
        }
    }
    
}

