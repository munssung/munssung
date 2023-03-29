using System;
using static System.Console;

namespace exercise03;

class MainApp
{
    static void Main(string[] args)
    {
        int a = 8 >> 1;
        int b = a >> 2;
        WriteLine(a);
        WriteLine(b);
    }
}