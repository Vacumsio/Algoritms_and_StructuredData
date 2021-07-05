using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_4
{
    class Subsequence
    {
        const int n = 11, m = 11; //константы размероности массива

        /// <summary>
        /// Метод вывода подпоследовательности с помощью функции Фор
        /// </summary>
        /// <param name="a">двумерный Массив</param>
        public static void PrintFor(int[,] a)
        {
            int i, j;
            for (i = 0; i <= n; i++)
            {
                for (j = 0; j <= m; j++)
                {
                    Console.Write("{0,3}", a[i, j]);
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Метод вывода подпоследовательности с помощью форыч
        /// </summary>
        /// <param name="a">двумерный Массив</param>
        public static void PrintForeach(int[,] a)
        {
            foreach (var w in Enumerable.Range(0, a.GetLength(0)))
            {
                foreach (var x in Enumerable.Range(0, a.GetLength(0)))
                {
                    Console.Write("{0,3}", a[w, x]);
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Метод для поиска наибольшей подпоследовательности
        /// </summary>
        public static void Sequence()
        {
            int i, j;

            //массив = оюект поиска
            int[,] fstSeq = {
                {' ','-','S','T','A','R','T','R','A','C','K'},
                {'+',0,0,0,0,0,0,0,0,0,0},
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

            //алгоритм поиска
            for (i = 1; i < n; i++)
            {
                for (j = 1; j < m; j++)
                {
                    if (fstSeq[i, j] == n)
                    {
                        fstSeq[i, j] = 0;
                    }

                    else if (fstSeq[i, 0] == fstSeq[0, j])
                    {
                        fstSeq[i, j] = 1 + fstSeq[i + 1, j + 1];
                    }

                    else if (fstSeq[i + 1, j] > fstSeq[i, j + 1])
                    {
                        fstSeq[i, j] = fstSeq[i + 1, j];
                    }

                    else
                    {
                        fstSeq[i, j] = fstSeq[i, j + 1];
                    }
                }
            }

            Console.WriteLine();
            PrintFor(fstSeq);
            Console.WriteLine();
            PrintForeach(fstSeq);

        }
    }
}

