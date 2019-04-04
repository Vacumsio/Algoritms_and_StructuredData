using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
1. Попробовать оптимизировать пузырьковую сортировку. Сравнить количество операций сравнения оптимизированной и неоптимизированной программы.
    Написать функции сортировки, которые возвращают количество операций.
2. *Реализовать шейкерную сортировку.
3. Реализовать бинарный алгоритм поиска в виде функции, которой передаётся отсортированный массив. Функция возвращает индекс найденного элемента или –1, если элемент не найден.
4. *Подсчитать количество операций для каждой из сортировок и сравнить его с асимптотической сложностью алгоритма.
*/
namespace lesson_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = CreateArray();

            //foreach (var item in array)
            //{
            //    Console.WriteLine(item);
            //}

            Console.ReadKey();
            #region 1. Попробовать оптимизировать пузырьковую сортировку.

            #endregion

            #region  2. *Реализовать шейкерную сортировку.

            #endregion

            #region 3. Реализовать бинарный алгоритм поиска в виде функции, которой передаётся отсортированный массив.

            #endregion

            #region 4. *Подсчитать количество операций для каждой из сортировок и сравнить его с асимптотической сложностью алгоритма.

            #endregion
        }

        private static int[] CreateArray()
        {
            int z = 0;
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                arr[i] = rand.Next(z,n);
            }
            return arr;
        }
    }
}
