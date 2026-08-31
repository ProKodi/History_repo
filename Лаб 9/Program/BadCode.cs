


using System;
using System.Collections.Generic;

class BadCode{
    public static void SuperPuperFuction(List<int> l)
    {


        int s = 0;
        for (int i = 0; i < l.Count; i++)
        {
            if (l[i] % 2 == 0)
            {
                s = s + l[i];
            }
        }

        Console.WriteLine("Sum: " + s);

        int s2 = 0;
        for (int i = 0; i < l.Count; i++)
        {
            if (l[i] % 2 != 0)
            {
                s2 = s2 + l[i];
            }
        }

        Console.WriteLine("Odd Sum: " + s2);
    }
}