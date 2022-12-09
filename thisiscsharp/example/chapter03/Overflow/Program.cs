using System;
using static System.Console;

namespace Overflow;

class MainApp
{
    static void Main(string[] args)
    {
        uint a = uint.MaxValue;
        WriteLine(a);
        a = a + 1;
        WriteLine(a);
    }
}