using System;
using static System.Console;

namespace exercise03_2;

class MainApp
{
    static void Main(string[] args)
    {
        int i = 5;

        do
        {
            int j = 0;
            while (j < i)
            {
                Write("*");
                j++;
            }
            WriteLine();
            i--;
        }
        while (i > 0);
    }
}