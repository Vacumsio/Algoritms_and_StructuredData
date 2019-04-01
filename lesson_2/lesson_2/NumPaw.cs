using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_2
{
    class NumPaw
    {
        public double Paw()
        {
            Console.WriteLine("Enter a number");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter desirable Paw");
            int a = int.Parse(Console.ReadLine());
            int w = 0;
            while (w!=a)
            {
                x *= x;
            }
            return x;
        }
        public double PawRec(int value, int pow)
        {
            if (pow == 0)
                return 1;
            if (pow > 0)
                return PawRec(value, pow - 1) * value;
            return 1.0 / PawRec(value, -pow);
        }
    }
}
