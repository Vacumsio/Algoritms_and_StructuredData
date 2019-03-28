using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_1
{
    class PawNN
    {
        public static void Paw()
        {
            Console.WriteLine("Enter anumber \"A\"");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter anumber \"B\". Must be bigger than A.");
            int b = int.Parse(Console.ReadLine());
            int n = a;

            while (a<=n && n<=b)
            {      
                Console.WriteLine($"Кварат числа: {n} = {n*n}");
                Console.WriteLine($"Куб числа: {n} = {n*n*n}");
                n++;
            }
        }
    }
}
