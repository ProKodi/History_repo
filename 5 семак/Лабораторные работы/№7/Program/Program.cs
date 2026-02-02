



using Connection_lab;

public class Program
{
    [STAThread]
    public static void Main(string[] args)
    {
        using (DataBase.SinglDataBase)
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());

        }
    }
}