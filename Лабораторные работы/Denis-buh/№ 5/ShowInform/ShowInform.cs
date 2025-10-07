



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

    private void ShowInform_Load(object sender, EventArgs e){
        System.Drawing.Drawing2D.GraphicsPath myPath = 
            new System.Drawing.Drawing2D.GraphicsPath();
        // создаем эллипс с высотой и шириной формы
        myPath.AddEllipse(0, 0, this.Width, this.Height);
        // создаем с помощью элипса ту область формы, которую мы хотим видеть
        Region myRegion = new Region(myPath);
        // устанавливаем видимую область
        this.Region = myRegion;
    }

    private void button_close_Click(object sender, EventArgs e){this.Close();}
}

