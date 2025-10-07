



public partial class Form1 : Form{
    public Form1(){InitializeComponent();}

    private void InputFile_Click(object sender, EventArgs e){
        InputFile input_file = new InputFile();
        input_file.ShowDialog();
    }

    private void PrintFile_Click(object sender, EventArgs e){
        OpenFileDialog openDialog = new OpenFileDialog();
        openDialog.Filter = "Текстовый файл|*.txt";
        DialogResult res = openDialog.ShowDialog();
        if (res == DialogResult.Cancel){return;}

        StreamReader fstream = new StreamReader(openDialog.FileName);

        ShowFile input_file = new ShowFile();

        string? inform; 

        while(true){
            inform = fstream.ReadLine();

            if(inform == null){break;}
            input_file.append_text(inform);

        }
        fstream.Close();
        input_file.ShowDialog();
        
    }
}

