using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_2
{
    class ChangeNumber
    {

        public static String IntToBin(int init)
        {
            return (init == 0) ? String.Empty : IntToBin(init / 2) + ((init % 2 == 0) ? "0" : "1");
        }
    }
}
