using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_8
{
    class NewArray
    {
        public static int[] CreateArray()
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Size of array {0}\n", n);
            int[] arr = new int[n];
            Random rand = new Random();

            for (int i = 0; i < n; i++)
            {
                arr[i] = rand.Next(0, 100);
            }

            return arr;
        }
    }
}
