



/*
Выполнение работы:
1) аналог Maven
В C# роль Maven выполняет:
    .NET CLI + файл проекта .csproj

2) Создание проекта
dotnet new web

3) Аналог pom.xml -> Code.csproj

4) Добавление зависимости:
dotnet add package Newtonsoft.Json

5) Сборка проекта
dotnet build

6) Запуск
dotnet run


*/




public class Program{
    public static void Main(string[] args){
        Console.WriteLine("Введите число:");
        int number = int.Parse(Console.ReadLine()!);

        Console.WriteLine($"Квадрат числа: {Square(number)}");
    }

    public static int Square(int x){ return x * x; }
}
