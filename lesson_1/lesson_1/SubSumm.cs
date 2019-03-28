using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_1
{
    class SubSumm
    {
        public void Dividing()
        {
            Console.WriteLine("Введите делимое");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите делитель");
            int y = int.Parse(Console.ReadLine());
            int count=0;
            int residue = 0;
            while(x>0)
            {                
                if (x<y)
                {
                    residue = x;
                    break;
                }
                x -= y;
                count++;
            }
            Console.WriteLine($"Частное от деления: {count}");
            Console.WriteLine($"Остаток от деления: {residue}");
        }
    }
}
