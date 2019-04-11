using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*1.Реализовать перевод из десятичной в двоичную систему счисления с использованием стека.
3.Написать программу, которая определяет, является ли введённая скобочная последовательность правильной. Примеры правильных скобочных выражений – (), ([])(), {}(), ([{}]), неправильных – )(, ())({), (, ])}), ([(]), для скобок – [, (, {.
Например: (2+(2*2)) или [2/{5*(4+7)}].
5.*Реализовать алгоритм перевода из инфиксной записи арифметического выражения в постфиксную.
*/
namespace lesson_5
{
    class Program
    {
        static void Main(string[] args)
        {

            int x = 250; // число для перевода
            Console.WriteLine(x);
            var stack = new Stack<int>();
            while (x > 0)
            {
                stack.Push(x % 2);
                x /= 2;
            }
            foreach (int i in stack)
                Console.Write(i);
            Console.ReadKey();

        }
    }
}
