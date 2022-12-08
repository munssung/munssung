﻿using System;
using static System.Console;

namespace chapter03;

class IntegralTypes
{
    static void Main(string[] args)
    {
        sbyte a = -10;
        byte b = 40;

        WriteLine($"a = {a}, b = {b}");

        short c = -30000;
        ushort d = 60000;

        WriteLine($"c = {c}, d = {d}");

        int e = -1000_0000;
        uint f = 3_0000_0000;

        WriteLine($"e = {e}, f = {f}");

        long g = -5000_0000_0000;
        ulong h = 200_0000_0000_0000_0000;

        WriteLine($"g = {g}, h = {h}");
    }
} 