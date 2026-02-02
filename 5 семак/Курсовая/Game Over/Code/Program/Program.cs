

static class Program{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main(){
        using (DataBase.SinglDataBase){
            var form = new MainForm();
            form.Text = "Коленко И.А 3105об 9 вариант";
            Application.Run(form);
        }
    }    

}