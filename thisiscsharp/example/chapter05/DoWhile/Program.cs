﻿using System;
using static System.Console;

namespace DoWhile;

class MainApp
{
    static void Main(string[] args)
    {
        int i = 10;

        do
        {
            WriteLine("a) i : {0}", i--);
            //WriteLine($"a) i : {i--}");
        }
        while (i>0);

        do
        {
            WriteLine("b) i : {0}", i--);
        }
        while(i>0);
    }
}