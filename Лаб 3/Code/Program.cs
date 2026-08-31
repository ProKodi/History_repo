



class Program{
    /// <summary> 
    /// Какая-то функция которую мы тестируем
    /// Она очень сложная и для нее нужны тесты
    /// </summary>
    public static int TestFun(int a, int b){ return a + b; }



    #if DEBUG
    
    public static void Main(string[] args){
        Console.WriteLine("Работа приложения в режиме теста");
        Console.WriteLine($"3 + 8 = {TestFun(3, 8)}");
    }
    #else

    public static void Main(string[] args){
        Console.WriteLine("Работа приложения в стандартной режиме");
        Console.WriteLine($"3 + 8 = {TestFun(3, 8)}");
    }
    #endif

}