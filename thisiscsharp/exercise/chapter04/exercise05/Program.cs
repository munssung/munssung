using System;
using static System.Console;

namespace exercise05;

class MainApp
{
    static void Main(string[] args)
    {
        int a = 10;
        string b = a == 0 ? "가나다" : "ABC";
        WriteLine(b);
    }
}