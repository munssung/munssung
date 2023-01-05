using System;
using static System.Console;

namespace IntegralConversion;

class MainApp
{
    static void Main(string[] args)
    {
        sbyte a = 127;
        WriteLine(a);

        int b = (int)a;
        WriteLine(b);

        int x = 128;
        WriteLine(x);

        sbyte y = (sbyte)x;
        WriteLine(y);
    }
}