using System;
using static System.Console;

namespace Constant;

class MainApp
{
    static void Main(string[] args)
    {
        const int MAX_INT = 2147483647;
        const int MIN_INT = -2147483648;

        WriteLine(MAX_INT);
        WriteLine(MIN_INT);
    }
}