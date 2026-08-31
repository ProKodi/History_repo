



using Autofac;





static class Program {

    public static IContainer DiConteiner; 


    /// <summary>
    /// Регистрацитя сервисов для DI
    /// </summary>
    static Program(){
        ApplicationConfiguration.Initialize();

        ContainerBuilder builder = new ContainerBuilder();

        // Подключааем зависимости по БД
        builder.RegisterModule<MyDataBase.ServicesModule>();

        DiConteiner = builder.Build();
        
    }




    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main() {
        using (DiConteiner) {
           // var temp = new MyDataBase.MySqlDataBase();
            var form = new MainForm();
            form.Text = "Буханов Денис Евгеньевич 3105об";
            Application.Run(form);

        }
    }    
}