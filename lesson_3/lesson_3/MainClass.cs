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
    class MainClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size of your array");
            DateTime date = DateTime.Now;
            int[] array = NewArray.CreateArray();
            Console.WriteLine("Время создания массива составляет: {0}\n", date - DateTime.Now);

            //foreach (var item in array)
            //{                
            //    Console.WriteLine(item);                
            //}
            
            Console.ReadKey();

            #region 1. Попробовать оптимизировать пузырьковую сортировку.
            Console.WriteLine("BubbleSort");
            date = DateTime.Now;
            int[] bubbles = Sorts.Bubbles(array);
            Console.WriteLine("Время создания массива составляет: {0}\n", date - DateTime.Now);
            Console.WriteLine("\n");
            Console.ReadKey();
            #endregion

            #region  2. *Реализовать шейкерную сортировку.
            Console.WriteLine("SheikersSort");
            date = DateTime.Now;
            int[] sheikers = Sorts.Sheikers(array);
            Console.WriteLine("Время создания массива составляет: {0}\n", date - DateTime.Now);
            Console.WriteLine("\n");
            Console.ReadKey();
            #endregion

            #region 3. Реализовать бинарный алгоритм поиска в виде функции, которой передаётся отсортированный массив.

            #endregion

            #region 4. *Подсчитать количество операций для каждой из сортировок и сравнить его с асимптотической сложностью алгоритма.

            #endregion
        }

        
    }
}
