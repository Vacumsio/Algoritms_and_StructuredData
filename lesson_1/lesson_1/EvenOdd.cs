using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_1
{
    class EvenOdd 
    {
        public static bool IfNumber()
        {
            Console.WriteLine("Enter a number");
            ulong x = ulong.Parse(Console.ReadLine());
            ulong q;
            while (x>0)
            {
                q = x % 10;
                if (q%2==1)
                {
                    return true;
                }
                x /= 10;
            }
            return false;
        }
    }
}
