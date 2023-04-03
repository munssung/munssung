using System;
using static System.Console;

namespace exercise03_1;

class MainApp
{
    static void Main(string[] args)
    {
        int i = 0;
        while (i < 5)
        {
            int j = 0;
            while (j <= i)
            {
                Write("*");
                j++;
            }
            WriteLine();
            i++;
        }
    }
}