using System;
using static System.Console;

namespace InfiniteWhile;

class MainApp
{
    static void Main(string[] args)
    {
        int i = 0;
        while (true)
            WriteLine(i++);
    }
}