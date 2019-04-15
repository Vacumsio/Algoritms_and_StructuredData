using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
1.Реализовать простейшую хэш-функцию. На вход функции подается строка, на выходе получается сумма кодов символов.
2.Переписать программу, реализующее двоичное дерево поиска:
    a.Добавить в него обход дерева различными способами.
    b.Реализовать поиск в нём.
*/

namespace lesson_6
{
    class MainClass
    {
        public static int StringHashCode20(string value)
        {
            int num = 352654597;
            int num2 = num;

            for (int i = 0; i < value.Length; i += 4)
            {
                int ptr0 = value[i] << 16;
                if (i + 1 < value.Length)
                    ptr0 |= value[i + 1];

                num = (num << 5) + num + (num >> 27) ^ ptr0;

                if (i + 2 < value.Length)
                {
                    int ptr1 = value[i + 2] << 16;
                    if (i + 3 < value.Length)
                        ptr1 |= value[i + 3];
                    num2 = (num2 << 5) + num2 + (num2 >> 27) ^ ptr1;
                }
            }

            return num + num2 * 1566083941;
        }

        public static int StringHashCode40(string value)
        {
            int num = 5381;
            int num2 = num;
            for (int i = 0; i < value.Length; i += 2)
            {
                num = (((num << 5) + num) ^ value[i]);

                if (i + 1 < value.Length)
                    num2 = (((num2 << 5) + num2) ^ value[i + 1]);
            }
            return num + num2 * 1566083941;
        }


        static void Main(string[] args)
        {
            string value = "123";
            Console.WriteLine(StringHashCode20(value));
            Console.WriteLine(StringHashCode40(value));
            Console.WriteLine(value.GetHashCode());

            Console.ReadKey();
        }
    }
}
