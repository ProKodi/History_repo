using System;

public class LogicClass
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
    public LogicClass(float a, float b, float c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }
    public LogicClass()
    {
        this.a = 0;
        this.b = 0;
        this.c = 0;
    }
    public LogicClass(LogicClass oldeq)
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
}
