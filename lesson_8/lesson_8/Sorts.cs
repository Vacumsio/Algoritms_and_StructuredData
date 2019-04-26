using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_8
{
    class Sorts
    {
        public static void Swap(ref int a, ref int b)
        {
            int t = a;
            a = b;
            b = t;
        }
        /// <summary>
        /// Сортировка пузырьковая
        /// </summary>
        /// <param name="arr"></param>
        /// <returns>возвращает отсортированный массив</returns>
        public static void Bubbles(int[] arr)
        {
            int bubbles = 0;
            int f;
            for (int i = 0; i < arr.Length; i++)
            {
                f = 0;
                bubbles++;
                for (int j = 0; j < arr.Length - 1; j++)  // оптимизация ------  j=i == продолжает сортировку неотсортированного
                {
                    if (arr[j] > arr[j + 1])
                    {
                        Swap(ref arr[j], ref arr[j + 1]);
                        f = 1; bubbles++;
                    }
                }
                if (f == 0)
                {
                    break;
                }
            }
            Console.WriteLine("проходы по улучшенной пузырьковой сортировке {0}",bubbles);
        }

        /// <summary>
        /// Шейкерная сортировка
        /// </summary>
        /// <param name="arr">массив инт</param>
        /// <returns>возвращает отсортированный</returns>
        public static void Sheikers(int[] arr)
        {
            int sheikers = 0;
            int min;
            for (int i = 0; i < arr.Length; i++)
            {
                sheikers++;
                min = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] > arr[min])
                    {
                        min = j;
                        sheikers++;
                    }
                }
                Swap(ref arr[i], ref arr[min]);
            }
            Console.WriteLine("проходы по шейкерам сортировке {0}", sheikers);
        }

        public static int[] Binary(int[] arr)
        {
            return arr;
        }
        /// <summary>
        /// Быстрая сортировка. Сортировка Хоара
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="firstIndex"></param>
        /// <param name="lastIndex"></param>
        public static void QSort(int[] arr, int firstIndex = 0, int lastIndex = -1)
        {
            int qso = 0;
            if (lastIndex < 0)
                lastIndex = arr.Length - 1;
            if (firstIndex >= lastIndex)
                return;
            int middleIndex = (lastIndex - firstIndex) / 2 + firstIndex, currentIndex = firstIndex;
            Swap(ref arr[firstIndex], ref arr[middleIndex]);
            for (int i = firstIndex + 1; i <= lastIndex; ++i)
            {
                qso++;
                if (arr[i] <= arr[firstIndex])
                {
                    Swap(ref arr[++currentIndex], ref arr[i]);qso++;
                }
            }
              
            Swap(ref arr[firstIndex], ref arr[currentIndex]);
            QSort(arr, firstIndex, currentIndex - 1);
            QSort(arr, currentIndex + 1, lastIndex);
        }

        public static void ShellSort(int[] arr)
        {
            int shs = 0;
            int j;
            int step = arr.Length / 2;
            while (step > 0)
            {
                for (int i = 0; i < (arr.Length - step); i++)
                {
                    shs++;
                    j = i;
                    while ((j >= 0) && (arr[j] > arr[j + step]))
                    {
                        int tmp = arr[j];
                        arr[j] = arr[j + step];
                        arr[j + step] = tmp;
                        j -= step;
                        shs++;
                    }
                }
                step = step / 2; shs++;
            }
            Console.WriteLine("проходы по Shell сортировке {0}", shs);
        }
    }
}
