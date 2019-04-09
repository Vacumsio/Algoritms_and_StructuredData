using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_4
{
    class Subsequence
    {
        const int n = 11, m = 11;

        public static void Sequence()
        {
            int [,] fstSeq = {
                {' ',' ','S','T','A','R','T','R','A','C','K'},
                {' ',0,0,0,0,0,0,0,0,0,0},
                {'S',0,0,0,0,0,0,0,0,0,0},
                {'P',0,0,0,0,0,0,0,0,0,0},
                {'O',0,0,0,0,0,0,0,0,0,0},
                {'R',0,0,0,0,0,0,0,0,0,0},
                {'T',0,0,0,0,0,0,0,0,0,0},
                {'R',0,0,0,0,0,0,0,0,0,0},
                {'A',0,0,0,0,0,0,0,0,0,0},
                {'C',0,0,0,0,0,0,0,0,0,0},
                {'E',0,0,0,0,0,0,0,0,0,0},
            };

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("{0,3}", fstSeq[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
