using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 1.	Написать функции, которые считывают матрицу смежности из файла и выводят её на экран.
2.	Написать рекурсивную функцию обхода графа в глубину.
3.	Написать функцию обхода графа в ширину.
4.	*Создать библиотеку функций для работы с графами.
*/

namespace GraphInDepth
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            #region 2. Написать рекурсивную функцию обхода графа в глубину. (НЕ рекурсия)
            Graph theGraph = new Graph();
            theGraph.addVertex('1');
            theGraph.addVertex('2');
            theGraph.addVertex('3');
            theGraph.addVertex('4');
            theGraph.addVertex('5');
            theGraph.addEdge(0, 1);
            theGraph.addEdge(1, 4);
            theGraph.addEdge(4, 2);
            theGraph.addEdge(2, 3);
            Console.Write("Visits: ");
            theGraph.dfs();
            Console.WriteLine();
            #endregion

            Console.ReadKey();
        }

    }
}