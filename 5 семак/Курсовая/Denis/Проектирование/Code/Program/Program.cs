

static class Program{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main(){
        using (DataBase.SinglDataBase){
            var form = new MainForm();
            form.Text = "Буханов Денис Евгеньевич 3105об 3 вариант";
            Application.Run(form);
        }
    }    

}