using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_4
{
    class Labirinth
    {        
        const int n = 10, m = 10;
        
        public static void Print(int n, int m, int[,]arr)
        {
            int i, j;
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < m; j++)
                {
                    Console.Write("{0,6}",arr[i,j]);
                }
                Console.WriteLine();
            }
        }

        public static void CreateMap()
        {                      
            
            int[,] arr = new int[n,m];
            int i, j;

            for (j = 0; j < m; j++)
            {
                arr[0, j] = 1;
            }
            
            for (i = 1; i < n; i++)
            {
                arr[i, 0] = 1;
                for (j = 1; j < m; j++)
                {
                    arr[i, j] = arr[i, j - 1] + arr[i - 1, j];
                }
            }
            Print(n,m,arr);
        }
    }
}
