using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_8
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size of your array");
            DateTime date = DateTime.Now;
            int[] array = NewArray.CreateArray();
            Console.WriteLine("Время создания массива составляет: {0}\n", date - DateTime.Now);



            //#region 1. Попробовать оптимизировать пузырьковую сортировку.
            //int[] bubbles = array;
            //Console.WriteLine("BubbleSort");
            //date = DateTime.Now;
            //Sorts.Bubbles(bubbles);
            //Console.WriteLine("Время создания массива составляет: {0}\n", date - DateTime.Now);
            //Console.WriteLine("\n");
            //#endregion

            //#region  2. *Реализовать шейкерную сортировку.
            //int[] sheikers = array;
            //Console.WriteLine("SheikersSort");
            //date = DateTime.Now;
            //Sorts.Sheikers(sheikers);
            //Console.WriteLine("Время создания массива составляет: {0}\n", date - DateTime.Now);
            //Console.WriteLine("\n");
            //#endregion

            //#region 3. Реализовать бинарный алгоритм поиска в виде функции, которой передаётся отсортированный массив.

            //#endregion

            //#region 4. *Подсчитать количество операций для каждой из сортировок и сравнить его с асимптотической сложностью алгоритма.

            //#endregion

            //#region QuickSort (Hoars sort)
            //int[] hoars = array;
            //Console.WriteLine("QuickSort-Hoar Sort");
            //date = DateTime.Now;
            //Sorts.QSort(array, out int num);
            //Console.WriteLine("проходы по QuickSort сортировке {0}", num);
            //Console.WriteLine("Время создания массива составляет: {0}\n", date - DateTime.Now);
            //Console.WriteLine("\n");
            //#endregion

            #region ShellSort
            int[] shell = array;
            Console.WriteLine("Shell Sort");
            date = DateTime.Now;
            Sorts.ShellSort(shell);
            Console.WriteLine("Время создания массива составляет: {0}\n", date - DateTime.Now);
            Console.WriteLine("\n");
            #endregion
            Console.ReadKey(); Console.ReadKey(); Console.ReadKey(); Console.ReadKey();
        }
    }
}
