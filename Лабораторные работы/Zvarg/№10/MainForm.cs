



public partial class MainForm : Form{
    public MainForm(){
        InitializeComponent();
    }

    /// <summary>Сохранение файла (меню)</summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void made_file_Click(object sender, EventArgs e){
        InputFile input_file = new InputFile();
        input_file.ShowDialog();
    }

    /// <summary>Открытие файла</summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void show_file_Click(object sender, EventArgs e){
        // Просим найти файл
        OpenFileDialog openDialog = new OpenFileDialog();
        openDialog.Filter = "Текстовый файл|*.txt";
        DialogResult res = openDialog.ShowDialog();
        if (res == DialogResult.Cancel){return;}

        // Открываем файловый поток
        StreamReader fstream = new StreamReader(openDialog.FileName);

        ShowFile input_file = new ShowFile();

        string? inform; 
        // Читаем файл
        while(true){
            // читаем по строкам
            inform = fstream.ReadLine();
            if(inform == null){break;}
            input_file.set_text(inform);
        }
        fstream.Close();
        input_file.ShowDialog();

    }
}

