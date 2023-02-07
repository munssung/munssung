﻿using System;
using static System.Console;

namespace Nullable;

class MainApp
{
    static void Main(string[] args)
    {
        int? a = null;

        WriteLine(a.HasValue);
        WriteLine(a != null);

        a = 3;

        WriteLine(a.HasValue);
        WriteLine(a != null);
        WriteLine(a.Value);
    }
}