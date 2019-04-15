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
        


        static void Main(string[] args)
        {
            #region 1.Реализовать простейшую хэш-функцию. На вход функции подается строка, на выходе получается сумма кодов символов.
            string value = "123";
            Console.WriteLine(HashHash.StringHashCode(value));
            Console.WriteLine(value.GetHashCode());
            Console.WriteLine(HashHash.GetHashString(value));
            #endregion

            #region 2.Переписать программу, реализующее двоичное дерево поиска:

            #endregion
            Console.ReadKey();
        }
    }
}
