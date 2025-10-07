class Equation
{
    float a, b, c;

    public Equation(float a, float b, float c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }
    public Equation()
    {
        this.a = 0;
        this.b = 0;
        this.c = 0;
    }
    public Equation(float a, float b)
    {
        this.a = a;
        this.b = b;
        this.c = 0;
    }
    public float Discriminant()
    {
        return (b * b) - (4 * a * c);
    }
    public void find_answ()
    {
        if (Discriminant() > 0)
        {
            Console.WriteLine("x1= {0}; x2 = {1}", ((-1) * b + Math.Sqrt(Discriminant())) / (2 * a), ((-1) * b - Math.Sqrt(Discriminant())) / (2 * a));
        }
        if (Discriminant() == 0)
        {
            Console.WriteLine("x= {0}",((-1) * b / (2 * a)));
        }
        if (Discriminant() < 0)
        {
            Console.WriteLine("Дискриминанта не существует (в множестве действительных чисел)");
        }
    }
    public void Output()
    {
        Console.WriteLine("{0}x^2 + {1}x + {2}", a, b, c);
    }

}

class Program
{
    public static void Main()
    {
        float a = Convert.ToSingle(Console.ReadLine());
        float b = Convert.ToSingle(Console.ReadLine());
        float c = Convert.ToSingle(Console.ReadLine());
        Equation first = new Equation(a,b,c);
        Console.WriteLine(first.Discriminant());
        first.find_answ();
        first.Output();
        a = Convert.ToSingle(Console.ReadLine());
        b = Convert.ToSingle(Console.ReadLine());
        c = Convert.ToSingle(Console.ReadLine());
        //Equation second = new Equation(a,b,c);
        Equation second = new Equation();
        Console.WriteLine(second.Discriminant());
        second.find_answ();
        second.Output();
        a = Convert.ToSingle(Console.ReadLine());
        b = Convert.ToSingle(Console.ReadLine());
        c = Convert.ToSingle(Console.ReadLine());
        //Equation third = new Equation(a,b,c);
        Equation third = new Equation(a, b);
        Console.WriteLine(third.Discriminant());
        third.find_answ();
        third.Output();
    }
}

