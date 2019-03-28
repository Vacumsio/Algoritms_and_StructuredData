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
            ulong c = 0;
            while (num > 0)
            {
                c++;
                num /= 10;
            }
            return c;
        }
        //public void IsAutomorph1(ulong num)
        //{
        //    if ((num * num) % (NumLength(num) * 10) == num)
        //    {
        //        Console.WriteLine($"num");
        //    }
        //}
        public void IsAutomorph2(ulong num)
        {
            for (ulong i = 0; i < num; i++)
            {
                if (i * i % (NumLength(num) * 10) == num)
                {
                    Console.Write($"{num} ");
                }
            }
            
        }

    }
}
