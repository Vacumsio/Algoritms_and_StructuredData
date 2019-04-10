using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_4
{
    class AllRoutes
    {
        const int n = 9, m = 9;

        /// <summary>
        /// Вывод массива на экран
        /// </summary>
        /// <param name="n">размерность</param>
        /// <param name="m">размерность</param>
        /// <param name="arr">массив чисел</param>
        public static void Print(int n, int m, int[,] arr)
        {
            int i, j;
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < m; j++)
                {
                    Console.Write("{0,6}", arr[i, j]);
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Метод подсчета - Количество маршрутов без препятствий
        /// </summary>
        public static void Routes()
        {
            int[,] arr = new int[n, m];
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
            Print(n, m, arr);
        }

        /// <summary>
        /// Метод подсчета - Количество маршрутов c препятствиями
        /// </summary>
        public static void RoutesFarFar()
        {
            int[,] arr = {
                {1,1,1,1,1,1,1,1,1},
                {1,1,1,1,1,0,1,1,0},
                {1,1,0,1,1,0,0,1,1},
                {1,1,1,0,1,0,1,1,1},
                {1,1,1,1,1,1,1,0,1},
                {1,1,1,1,1,0,1,1,1},
                {1,1,1,0,1,1,1,1,1},
                {1,1,1,1,1,1,1,1,1},
                {1,1,1,1,0,1,1,1,1},
            };
            int i, j;


            for (i = 1; i < n; i++)
            {               
                for (j = 1; j < m; j++)
                {
                    if (arr[i,j]==1)
                    {
                        arr[i, j] = arr[i, j - 1] + arr[i - 1, j];
                    }
                    if (arr[i, j] == 0)
                    {
                        arr[i, j] = 0;
                    }
                }
            }
            Print(n, m, arr);
        }
    }
}
