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

        public static int[] Bubbles(int[] arr)
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
            return arr;
        }

        public static int[] Sheikers(int[] arr)
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
            return arr;
        }

        public static int[] Binary(int[] arr)
        {
            return arr;
        }

    }
}
