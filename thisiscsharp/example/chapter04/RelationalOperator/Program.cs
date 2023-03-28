using System;
using static System.Console;

namespace RelationalOperator;

class MainApp
{
    static void Main(string[] args)
    {
        WriteLine($"3 > 4 : {3 > 4}");
        WriteLine($"3 >= 4 : {3 >= 4}");
        WriteLine($"3 < 4 : {3 < 4}");
        WriteLine($"3 <= 4 : {3 <= 4}");
        WriteLine($"3 == 4 : {3 == 4}");
        WriteLine($"3 != 4 : {3 != 4}");
    }
}