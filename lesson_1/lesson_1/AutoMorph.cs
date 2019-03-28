using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_1
{
    class AutoMorph
    {
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
        }
    }
}
