using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;


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

    public string Find_firstansw()
    {
        if (Discriminant() > 0)
        {
            return Convert.ToString(((-b) + Math.Sqrt(Discriminant())) / (2 * a));
        }
        else if (Discriminant() == 0)
        {
            return Convert.ToString((-b) / (2 * a));
        }
        else { return "не число"; }
    }

    public string Find_secondansw()
    {
        if (Discriminant() > 0)
        {
            return Convert.ToString(((-b) - Math.Sqrt(Discriminant())) / (2 * a));
        }
        else if (Discriminant() == 0)
        {
            return Convert.ToString((-b) / (2 * a));
        }
        else { return "не число"; }
    }

    public string Output()
    {
        return a.ToString() + "x^2 + " + b.ToString() + "x + " + c.ToString();
    }
}


public class InheritedClass : LogicClass
{
    public InheritedClass(float a, float b, float c) : base(a, b, c) { }
    public InheritedClass() : base() { }
    public InheritedClass(InheritedClass oldeq)
    {
        this.A = oldeq.A;
        this.B = oldeq.B;
        this.C = oldeq.C;
    }
    public InheritedClass(LogicClass oldeq)
    {
        this.A = oldeq.A;
        this.B = oldeq.B;
        this.C = oldeq.C;
    }

    public static bool operator true(InheritedClass inheritedClass)
    {
        return inheritedClass.Discriminant() >= 0;
    }

    public static bool operator false(InheritedClass inheritedClass)
    {
        return inheritedClass.Discriminant() < 0;
    }

    public static bool operator ==(InheritedClass self, InheritedClass other)
    {
        if (self.A == 0 && self.B == 0 && self.C == 0 && other.A == 0 && other.B == 0 && other.C == 0) { return true; }
        if (self.A == 0 && other.A != 0) { return false; }
        if (self.B == 0 && other.B != 0) { return false; }
        if (self.C == 0 && other.C != 0) { return false; }
        if (self.A != 0 && other.A == 0) { return false; }
        if (self.B != 0 && other.B == 0) { return false; }
        if (self.C != 0 && other.C == 0) { return false; }
        float k = self.A / other.A;
        if (k != (self.B / other.B)) { return false; }
        if (k != (self.C / other.C)) { return false; }
        return true;
    }

    public static bool operator !=(InheritedClass self, InheritedClass other)
    {
        if (self.A == 0 && self.B == 0 && self.C == 0 && other.A == 0 && other.B == 0 && other.C == 0) { return false; }
        if (self.A == 0 && other.A != 0) { return true; }
        if (self.B == 0 && other.B != 0) { return true; }
        if (self.C == 0 && other.C != 0) { return true; }
        if (self.A != 0 && other.A == 0) { return true; }
        if (self.B != 0 && other.B == 0) { return true; }
        if (self.C != 0 && other.C == 0) { return true; }
        float k = self.A / other.A;
        if (k != (self.B / other.B)) { return true; }
        if (k != (self.C / other.C)) { return true; }
        return false;
    }
}


