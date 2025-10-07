



public partial class InputFile : Form{
    public InputFile(){InitializeComponent();}

    /// <summary>Сохранение текста в файл</summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void save_file_Click(object sender, EventArgs e){
        SaveFileDialog saveDialog1 = new SaveFileDialog();
        saveDialog1.Filter = "Текстовый файл|*.txt";
        DialogResult res = saveDialog1.ShowDialog();
        if (res == DialogResult.Cancel){return;}

        StreamWriter fstream = new StreamWriter(saveDialog1.FileName);

        fstream.Write(text_for_file.Text); 

        fstream.Close();
    }
}

