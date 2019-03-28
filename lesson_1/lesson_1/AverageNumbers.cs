using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_1
{
    class AverageNumbers
    {
        public static double Average()
        {
            double summ = 0;
            double x = 1;
            int i = 0;
            do
            {
                Console.WriteLine("Enter a number");
                x = double.Parse(Console.ReadLine());
                if (x==0)
                {
                    return summ / i;
                }
                summ += x; i++;
            } while (x > 0);
            return summ / i;
        }    
    }
}
