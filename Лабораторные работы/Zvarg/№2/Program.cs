class Equation
{
    float a, b, c;

    public float A
    {
        get { return a; }
        set { a = value; }
    }
    public float B
    {
        get { return b; }
        set { b = value; }
    }
    public float C
    {
        get { return c; }
        set { c = value; }
    }
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
    public Equation(Equation oldeq)
    {
        this.a = oldeq.a;
        this.b = oldeq.b;
        this.c = oldeq.c;
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
            Console.WriteLine("x= {0}", ((-1) * b / (2 * a)));
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
        Equation first = new Equation(a, b, c);
        Console.WriteLine(first.Discriminant());
        first.find_answ();
        first.Output();
        Console.WriteLine("--------------------------------------------");
        //Equation second = new Equation(a,b,c);
        Equation second = new Equation();
        Console.WriteLine(second.A);
        Console.WriteLine(second.B);
        Console.WriteLine(second.C);
        Console.WriteLine("D={0}",second.Discriminant());
        second.A = 1;
        second.B = 2;
        second.C = 3;
        Console.WriteLine(second.A);
        Console.WriteLine(second.B);
        Console.WriteLine(second.C);
        Console.WriteLine(("D={0}", second.Discriminant()));
        second.find_answ();
        second.Output();
        Console.WriteLine("--------------------------------------------");
        Console.WriteLine("Данное выражение - копия первого...");
        //Equation third = new Equation(a,b,c);
        Equation third = new Equation(first);
        Console.WriteLine("d={0}", third.Discriminant());
        third.find_answ();
        third.Output();
    }
}

