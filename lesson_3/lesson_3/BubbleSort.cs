using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_3
{
    class BubbleSort
    {
        public static void Swap(ref int a,ref int b)
        {
            int t = a;
            a = b;
            b = t;
        }

        public static int[] Bubbles(int[] arr)
        {
            BubbleSort sw = new BubbleSort();
            
            int f;
            for (int i = 0; i < arr.Length; i++)
            {
                f = 0;
                for (int j = 0; j < arr.Length-1; j++)
                {
                    if (arr[j]>arr[j+1])
                    {                        
                        Swap(ref arr[j],ref arr[j + 1]);
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
                Console.Write("{0} ",item);
            }
            return arr;
        }
    }
}
