using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_2
{
    class ChangeNumber
    {

        public string bin;
        public void Per(int i)
        {
            if (i > 0)
            {
                if (i % 2 == 1)
                    bin += "1";
                else
                    bin += "0";
                Per(i / 2);
            }
        }
    }
}
