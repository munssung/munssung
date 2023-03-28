using System;
using static System.Console;

namespace LogicalOperator;

class MainApp
{
    static void Main(string[] args)
    {
        WriteLine("Testing && ...");
        WriteLine($"1 > 00 && 4 < 5 : {1 > 00 && 4 < 5}");
        WriteLine($"1 > 00 && 4 > 5 : {1 > 00 && 4 > 5}");
        WriteLine($"1 == 00 && 4 > 5 : {1 == 00 && 4 > 5}");
        WriteLine($"1 == 00 && 4 < 5 : {1 == 00 && 4 < 5}");

        WriteLine("\nTesting || ...");
        WriteLine($"1 > 00 || 4 < 5 : {1 > 00 || 4 < 5}");
        WriteLine($"1 > 00 || 4 > 5 : {1 > 00 || 4 > 5}");
        WriteLine($"1 == 00 || 4 > 5 : {1 == 00 || 4 > 5}");
        WriteLine($"1 == 00 || 4 < 5 : {1 == 00 || 4 < 5}");

        WriteLine("\nTesting ! ...");
        WriteLine($"!True : {!true}");
        WriteLine($"!False : {!false}");
    }
}