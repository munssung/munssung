using System;
using static System.Console;

namespace IntergerLiterals;

class MainApp
{
    static void Main(string[] args)
    {
        byte a = 240;
        WriteLine($"a = {a}");

        byte b = 0b1111_0000;
        WriteLine($"b = {b}");

        byte c = 0XF0;
        WriteLine($"c = {c}");

        uint d = 0x1234_abcd;
        WriteLine($"d = {d}");
    }
}