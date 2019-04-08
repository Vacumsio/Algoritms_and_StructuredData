using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_4
{
    class Labirinth
    {
        static Random rand = new Random();
        const int n = 10, m = 10;

        public static void CreateMap()
        {                        
            int[,] massiv = new int[m, n];

            for (int i = 0; i < n; ++i)
            {
                Console.WriteLine();
                for (int j = 0; j < m; ++j)
                {
                    massiv[i, j] = rand.Next(0, 2);
                    Console.Write(" " + massiv[i, j] + " ");
                }
            }
        }
    }
}
