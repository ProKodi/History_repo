



class Program{
    public static void Main(string[] arg){
        List<int> l = [1, 2, 3, 4, 5];

        BadCode.SuperPuperFuction(l);


        Console.WriteLine($"Even Sum: {GoodCode.CalculateSum(l, true)}");
        Console.WriteLine($"Odd Sum: {GoodCode.CalculateSum(l, false)}");
    }
}