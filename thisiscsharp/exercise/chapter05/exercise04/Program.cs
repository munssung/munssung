using System;
using static System.Console;

namespace exercise4;

class MainApp
{
    static void Main(string[] args)
    {     
        Write("반복 횟수를 입력하세요 : ");
        int answer = int.Parse(ReadLine());

        if (answer <= 0)
        {
            WriteLine("0보다 작거나 같은 수는 입력할 수 없습니다.");            
        }

        else
        {
            for (int i = 0; i < answer; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Write("*");
                }
                WriteLine();
            }
        }
    }
}