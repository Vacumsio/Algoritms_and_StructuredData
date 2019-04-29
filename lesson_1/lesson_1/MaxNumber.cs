using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_1
{
    class MaxNumber
    {

        static int Max(int x, int y, int z)
        {
            int max = (x>y)?x:y;
            if (z > max) max=z;
            return max;
        }
        public static int SandBox()
        {            
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());
            int max = Max(x, y, z);
            return max;
        }
    }
}
