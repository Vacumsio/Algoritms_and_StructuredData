using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_5
{
    class StackToBin
    {
        /// <summary>
        /// Метода перевода в двоичную систму с использованием Стека
        /// </summary>
        static public void ToBin()
        {
            Console.WriteLine("Введите число для перевода в двоичную систему");

            int x = int.Parse(Console.ReadLine()); // число для перевода
            var stack = new Stack<int>();

            while (x > 0)
            {
                stack.Push(x % 2);
                x /= 2;
            }

            foreach (int i in stack)
                Console.Write(i);
        }
    }
}
