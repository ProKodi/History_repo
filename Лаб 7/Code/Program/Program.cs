



using System.Data;
using System.Text.Json.Nodes;

public class Server{
    protected Server(WebApplication app){
        app.MapGet("/", HomePage);
        app.MapPatch("/answer", GetAnswer);
    }

    /// <summary> 
    /// Домашняя страница
    /// Доступна так же по адресу (Стат файлы): http://localhost:5083/page/home/home.html  
    /// </summary>
    protected async Task HomePage(HttpContext context, IWebHostEnvironment env){
        context.Response.Headers.ContentType = "charset=utf-8"; // устанавливаем кодировку
        await context.Response.SendFileAsync($"./Program/wwwroot/page/home/home.html"); // Отображаем HTML страницу
    }


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

            mess = await ModelAI.Run(mess);

            if(mess == null){ mess = "Я промолчу"; }

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
            //#if DEBUG
                new WebApplicationOptions { WebRootPath = "./Program/wwwroot"}
            /*#else
                new WebApplicationOptions { WebRootPath = "./wwwroot"}
            #endif*/
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