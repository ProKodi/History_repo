





static class Functions{
    // График 1. Кривая с изолированной точкой
    public static (double, double) function1(double x, double g){
        double temp = Math.Sqrt(Math.Pow(x, 3) * (x - g)); 
        return (-temp, temp); 
    }
    // График 3. Цепная линия
    public static double function2(double x, double a){
        double temp = x / a;
        return (a / 2) * (Math.Pow(Math.E, temp) + Math.Pow(Math.E, -temp)); 
    }
    // График Прямая
    public static double function3(double x, double k, double b){
        return (k * x) + b; 
    }
    // График Окружность
    public static (double, double) function4(double x, double r){
        double temp = Math.Sqrt(Math.Pow(r, 2) - Math.Pow(x, 2)); 
        return (-temp, temp); 
    }
}




class Program{
    static void Main(){
        double r = 1;
        (double, double) res1 = Functions.function1(0.5, r); 
        Console.WriteLine(res1.Item1);
        Console.WriteLine(res1.Item2);


    }
}