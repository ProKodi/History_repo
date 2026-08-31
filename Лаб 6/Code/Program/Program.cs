



using System.Data;
using System.Text.Json.Nodes;

public class Server{
    protected Server(WebApplication app){
        // app.MapGet("/", TestGet);
        app.MapGet("/", HomePage);

        app.MapPatch("/answer", GetAnswer);

        /*app.MapGet("/logs", GetLogs);



        /// Работа с параметрами
        app.MapGet("/options", GetOptions);
        app.MapPatch("/options", SetOptions);
        //app.MapGet("/options_page", ...);*/
       
        /*app.Run(async (HttpContext context) => {
            await context.Response.WriteAsync("Page don't found");
        });*/
    }

    /// <summary> 
    /// Домашняя страница
    /// Доступна так же по адресу (Стат файлы): http://localhost:5083/page/home/home.html  
    /// </summary>
    protected async Task HomePage(HttpContext context){
        context.Response.Headers.ContentType = "charset=utf-8"; // устанавливаем кодировку
        await context.Response.SendFileAsync(".\\Program\\wwwroot\\page\\home\\home.html"); // Отображаем HTML страницу
    }

    /*/// <summary>
    /// Метод для получения списков логов
    /// Пример запроса: http://localhost:5083/logs?date=2026-03-22T22:43:00
    /// </summary>
    /// <param name="date"> Дата и время с которой начать искать логи </param>
    /// <returns></returns>
    protected async Task GetLogs(HttpContext context, DateTime? date = null){
        context.Response.Headers.ContentType = "charset=utf-8"; // устанавливаем кодировку

        List<string> res = LoggerServise.GetLogs(date);
        foreach (var i in res){
            Console.WriteLine(i);
        }
        await context.Response.WriteAsJsonAsync(
            new {List_Logs = res}
        ); 
    }


    /// <summary> Выдача параметров в форме json </summary>
    protected async Task GetOptions(HttpContext context){
        context.Response.Headers.ContentType = "charset=utf-8"; // устанавливаем кодировку
        await context.Response.WriteAsJsonAsync(OptionsServise.Options); 
    }*/

    /// <summary> Получение и установка новых параметров из json </summary>
    protected async Task GetAnswer(HttpContext context){
        HttpResponse response = context.Response;
        try{
            using var reader = new StreamReader(context.Request.Body);
            string body = await reader.ReadToEndAsync();

            JsonNode? json = JsonObject.Parse(body);
            if(json == null){
                throw new DataException("Не удалось расспарсить json с параметрами");
            }
            var mess = json.AsObject()["text_message"]!.GetValue<string>();
            await DataBase.DataBaseServis.Write(mess, true);

            mess = $"Ответ: {mess}";
            await DataBase.DataBaseServis.Write(mess, false);

            await response.WriteAsJsonAsync(new {text_message = mess, is_user = false});
        } 
        catch (Exception err){
            await response.WriteAsync($"Случилась ошибка : {err.Message}");
            return;
        }
    }


    /// <summary> Запуск сайта </summary>
    public static async Task Start(string[] args){
        WebApplicationBuilder builder = WebApplication.CreateBuilder(
            new WebApplicationOptions { WebRootPath = ".\\Program\\wwwroot"}
        );
        using WebApplication app = builder.Build();

        // app.MapStaticAssets();  // добавляем поддержку статических файлов
        // Запрещаем кеширование стат файлов
        app.UseStaticFiles(new StaticFileOptions {
            OnPrepareResponse = ctx => {
                // Запрещаем кеширование браузером
                ctx.Context.Response.Headers["Cache-Control"] = "no-cache, no-store, must-revalidate";
                ctx.Context.Response.Headers["Pragma"] = "no-cache";
                ctx.Context.Response.Headers["Expires"] = "0";
            }
        });

        try{ 
            var server = new Server(app);
            await Task.Run(() => { app.Run(); }); 
        } catch{}
    }
}








public class Program{
    /// <summary> Инициализация сервисов приложения </summary>
    private static void InitServises(){
        Console.WriteLine("Начало инициализации");
        DataBase.DataBaseServis.Init();

        Console.WriteLine("Все сервисы инициализированны");
    }


    /// <summary> Финализации сервисов приложения </summary>
    private static void DisposeServises(){
        Console.WriteLine("Начало финализации");
        DataBase.DataBaseServis.Dispose();
       
        Console.WriteLine("Все сервисы финализированны");
    }



    public static async Task Main(string[] args){
        try{
            InitServises();
            
            Task task_server = Server.Start(args); 
            Console.WriteLine("Сервер запущен");

            await task_server;
        }
        catch {
            Console.WriteLine("Критическая ошибка в Main потоке");
        }

        DisposeServises();
        Console.WriteLine("Сервер завершил свою работу");

    }
}






