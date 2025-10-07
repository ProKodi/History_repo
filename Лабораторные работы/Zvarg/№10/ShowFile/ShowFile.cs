



static class Constant{
    public static char[] consonants = {'а', 'у', 'о', 'ы', 'э', 'я', 'ю', 'ё', 'и', 'е'};

    public static bool check_consonant(char sim){
        string find_sim = sim.ToString().ToLower();
        foreach(char i in consonants){
            if(i.ToString() == find_sim){return true;}
        }
        return false;
    }
}


partial class ShowFile : Form{
    public ShowFile(){InitializeComponent();}

    /// <summary>Количество нужных слов</summary>
    protected int cout_number_words = 0;

    /// <summary>Номера с которого начнем выделять и количество выделяемых символов</summary>
    protected (int, int) number = (0, 0);


    /// <summary>Указываем информацию и анализируем ее</summary>
    /// <param name="inform"></param>
    public void set_text(string sinform){
        // Бьем текст по пробелам - получаем слова
        string[] words = sinform.Split(); 

        foreach(string i in words){
            if(i.Length < 1){continue;}
            // Обрубаем пробелы с лева и права
            string tem_i = i.Trim(); 
            if(Constant.check_consonant(tem_i[0]) && Constant.check_consonant(tem_i[tem_i.Length - 1])){
                cout_number_words += 1;
                number.Item1 = text_file.Text.Length + i.IndexOf(tem_i); 
                number.Item2 = tem_i.Length; 
            }
            text_file.Text += i + " ";
        }
        // Добавляем enter после строчки 
        text_file.Text += "\r\n";

    }

    public new DialogResult ShowDialog(){
        cout_words.Text += $"{cout_number_words}"; 
        text_file.Select(number.Item1, number.Item2);


        return base.ShowDialog(); 
    }
}

