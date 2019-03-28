using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_1
{
    class AutoMorph
    {
        /// <summary>
        /// Метод определяет длинну числа
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        static ulong NumLength(ulong num)
        {
            ulong c = 1;
            while (num > 0)
            {
                c*=10;
                num /= 10;
            }
            return c;
        }
        
        /// <summary>
        /// Метод определяет является ли число автоморфным
        /// </summary>
        /// <param name="num"></param>
        public void IsAutomorph(ulong num)
        {
            for (ulong i = 1; i < num;)
            {
                if (i * i % NumLength(i) == i)
                {
                    Console.Write($"{i} ");
                }
                i++; num--;
            }
            Console.Write("\n");
        }
    }
}
