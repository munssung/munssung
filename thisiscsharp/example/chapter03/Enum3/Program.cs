using System;
using static System.Console;

namespace Enum3;

class MainApp
{
    enum DialogResult { YES = 10, NO, CANCLE, CONFIRM = 50, OK }
    static void Main(string[] args)
    {
        WriteLine((int)DialogResult.YES);
        WriteLine((int)DialogResult.NO);
        WriteLine((int)DialogResult.CANCLE);
        WriteLine((int)DialogResult.CONFIRM);
        WriteLine((int)DialogResult.OK);
    }
}