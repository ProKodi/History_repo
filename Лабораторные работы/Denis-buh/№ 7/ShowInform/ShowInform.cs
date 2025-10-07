



public partial class ShowInform : Form{
    public ShowInform(){
        InitializeComponent();
    }

    public void set_inform_chart_1(string formul, string color){
        this.formul_for_chart1.Text = formul; 
        this.color_for_chart1.Text = color; 
    }

    public void set_inform_chart_2(string formul, string color){
        this.formul_for_chart2.Text = formul; 
        this.color_for_chart2.Text = color; 
    }

    public void set_inform_chart_3(string formul, string color){
        this.formul_for_chart3.Text = formul; 
        this.color_for_chart3.Text = color; 
    }

    public void set_inform_chart_4(string formul, string color){
        this.formul_for_chart4.Text = formul; 
        this.color_for_chart4.Text = color; 
    }
}

