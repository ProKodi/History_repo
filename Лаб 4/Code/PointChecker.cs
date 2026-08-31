



public class PointChecker
{
    private const double Radius = 5.0;

    // Специально сделаем метод "тяжёлым" для профилирования
    public bool IsHit(double x, double y)
    {
        // Искусственная нагрузка (для пункта 4 лабы)
        Thread.Sleep(5);

        return x * x + y * y <= Radius * Radius;
    }
}