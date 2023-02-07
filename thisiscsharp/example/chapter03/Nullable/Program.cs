using System;
using static System.Console;

namespace Nullable;

class MainApp
{
    static void Main(string[] args)
    {
        int? a = null;

        WriteLine(a.HasValue); // a는 null이므로 False 출력
        WriteLine(a != null);

        a = 3;

        WriteLine(a.HasValue); // a는 3을 갖고 있으므로 True 출력
        WriteLine(a != null);
        WriteLine(a.Value); // 3을 출력
    }
}