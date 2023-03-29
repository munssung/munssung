﻿using System;
using static System.Console;

namespace IfElse;

class MainApp
{
    static void Main(string[] args)
    {
        Write("숫자를 입력하세요.  :  ");

        string input = ReadLine();
        int number = Int32.Parse(input);

        if (number < 0)
            WriteLine("음수");
        else if (number > 0)
            WriteLine("양수");
        else
            WriteLine("0");

        if (number % 2 == 0)  // 2로 나누었을 때 나머지가 0
            WriteLine("짝수");
        else
            WriteLine("홀수");
    }
}