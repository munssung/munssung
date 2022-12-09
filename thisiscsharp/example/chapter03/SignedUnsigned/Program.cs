using System;
using static System.Console;

namespace SignedUnsigned;

class MainApp
{
    static void Main(string[] args)
    {
        byte a = 255;
        sbyte b = (sbyte)a;

        WriteLine(a);
        WriteLine(b);
    }
}