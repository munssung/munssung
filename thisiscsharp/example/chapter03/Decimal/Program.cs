using System;
using static System.Console;

namespace Decimal;

class MainApp
{
    static void Main(string[] args)
    {
        float a = 3.1415_9265_3589_7932_3846_2643_3827_79f;
        double b = 3.1415_9265_3589_7932_3846_2643_3827_79;
        decimal c = 3.1415_9265_3589_7932_3846_2643_3827_79m;

        WriteLine(a);
        WriteLine(b);
        WriteLine(c);
    }
}