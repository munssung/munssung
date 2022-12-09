using System;
using static System.Console;

namespace FloatingPoint;

class MainApp
{
    static void Main(string[] args)
    {
        float a = 3.1415_9265_3589_7932_3846f;
        WriteLine(a);

        double b = 3.1415_9265_3589_7932_3846;
        WriteLine(b);
    }
}