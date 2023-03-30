using System;
using static System.Console;

namespace InfiniteFor;

class MainApp
{
    static void Main(string[] args)
    {
        int i = 0;
        for(; ;)
            WriteLine(i++);
    }
}