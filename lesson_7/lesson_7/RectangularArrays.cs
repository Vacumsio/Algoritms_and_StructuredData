/*
 1.	Написать функции, которые считывают матрицу смежности из файла и выводят её на экран.
2.	Написать рекурсивную функцию обхода графа в глубину.
3.	Написать функцию обхода графа в ширину.
4.	*Создать библиотеку функций для работы с графами.
*/

namespace GraphInDepth
{
    static class RectangularArrays
    {
        internal static int[][] ReturnRectangularIntArray(int Size1, int Size2)
        {
            int[][] Array = new int[Size1][];
            for (int Array1 = 0; Array1 < Size1; Array1++)
            {
                Array[Array1] = new int[Size2];
            }
            return Array;
        }
    }
}