



partial class ShowFile : Form{
    protected int cout_words = 0;
    protected string first_worls = "";

    public ShowFile(){
        InitializeComponent();
        text_after.KeyDown += show_inform;
    }

    public void append_text(string text){
        text_before.Text += (text + "\r\n"); 
        text = text.Trim().ToLower();

        string[] words = text.Split(); 
        foreach(string i in words){
            if(i.Length < 1){continue;}
            if(!i.EndsWith(i[0])) {continue;}

            if(first_worls == ""){first_worls = i;}
            cout_words += 1;
        }
    }

    public void show_inform(object? sender, KeyEventArgs e){
        text_after.KeyDown -= show_inform;
        text_after.Text += $"\r\nПервое слово: {first_worls}"; 
    }

    public new DialogResult ShowDialog(){
        text_after.Text = $"Количество слов начинающихся и заканчивающихся одной и той же буквой: {cout_words}"; 
        return base.ShowDialog(); 
    }
}
