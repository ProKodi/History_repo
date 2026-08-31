



using System.Diagnostics;

class Program{
    static void Main(){
        var stopwatch = Stopwatch.StartNew();

        var checker = new PointChecker();
        var counter = new PointsCounter();
        var missCalculator = new MissPercentageCalculator(counter);

        counter.PointsMultipleOfTenReached += (sender, total) =>
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"[EVENT] Количество точек кратно 10: {total}");
            Console.ResetColor();
        };

        Console.WriteLine("Вводите координаты X Y (exit для выхода)\n");

        while (true)
        {
            Console.Write("> ");
            var input = Console.ReadLine();

            if (input == null || input.ToLower() == "exit")
                break;

            var parts = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            if (parts.Length != 2 ||
                !double.TryParse(parts[0], out double x) ||
                !double.TryParse(parts[1], out double y))
            {
                Console.WriteLine("Некорректный ввод");
                continue;
            }

            bool isHit = checker.IsHit(x, y);
            counter.AddPoint(isHit);

            Console.WriteLine(isHit ? "Попадание" : "Промах");
            Console.WriteLine($"Всего точек: {counter.TotalPoints}");
            Console.WriteLine($"Промахов: {counter.MissedPoints}");
            Console.WriteLine($"Процент промахов: {missCalculator.GetMissPercentage():F2}%");
            Console.WriteLine($"Время работы (мс): {stopwatch.ElapsedMilliseconds}");
            Console.WriteLine();
        }
    }
}

/*
dotnet run


dotnet-counters ps

dotnet-counters monitor   --process-id 26420   Lab3.PointsMetrics

27624

dotnet-counters monitor --process-id 27624 System.Runtime


dotnet-trace collect  --process-id 16028 --profile cpu --duration 00:00:30 -o trace.nettrace
*/