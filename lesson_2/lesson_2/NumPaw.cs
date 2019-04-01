using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_2
{
    class NumPaw
    {
        public double Pow(int value, int pow)
        {
            if (pow == 0)
                return 1;
            if (pow > 0)
                return Pow(value, pow - 1) * value;
            return 1.0 / Pow(value, -pow));
        }
    }
}
