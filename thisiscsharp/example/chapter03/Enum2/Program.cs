using System;
using static System.Console;

namespace Enum2;

class MainApp
{
    enum DialogResult { YES, NO, CANCLE, CONFIRM, OK }
    static void Main(string[] args)
    {
        DialogResult result = DialogResult.YES;

        WriteLine(result == DialogResult.YES);
        WriteLine(result == DialogResult.NO);
        WriteLine(result == DialogResult.CANCLE);
        WriteLine(result == DialogResult.CONFIRM);
        WriteLine(result == DialogResult.OK);
    }
}