using System;

namespace lesson_3
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
            int f;
            for (int i = 0; i < arr.Length; i++)
            {
                f = 0;
                for (int j = 0; j < arr.Length - 1; j++)  // оптимизация ------  j=i == продолжает сортировку неотсортированного
                {
                    if (arr[j] > arr[j + 1])
                    {
                        Swap(ref arr[j], ref arr[j + 1]);
                        f = 1;
                    }
                }
                if (f == 0)
                {
                    break;
                }
            }
            foreach (var item in arr)
            {
                Console.Write("{0} ", item);
            }
            return arr;
        }

        public static int[] Sheikers(int[] arr)
        {
            int min;
            for (int i = 0; i < arr.Length; i++)
            {
                min = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] > arr[min])
                    {
                        min = j;
                    }
                }
                Swap(ref arr[i], ref arr[min]);
            }
            foreach (var item in arr)
            {
                Console.Write("{0} ", item);
            }
            return arr;
        }


    }
}
