using System;
using static System.Console;

namespace exercise02
{
    class MainApp
    {
        static void Main(string[] args)
        {
            var a = 2020;
            var b = "double";

            WriteLine(a.GetTypeCode());
            WriteLine(b.GetTypeCode());
        }
    }
}