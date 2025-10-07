using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_lab
{
    internal class LogicClass
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
            else if (Discriminant() == 0){
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
}

