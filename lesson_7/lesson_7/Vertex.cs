/*
 1.	Написать функции, которые считывают матрицу смежности из файла и выводят её на экран.
2.	Написать рекурсивную функцию обхода графа в глубину.
3.	Написать функцию обхода графа в ширину.
4.	*Создать библиотеку функций для работы с графами.
*/

namespace GraphInDepth
{
    public class Vertex
    {
        public char label;
        public bool wasVisited;

        public Vertex(char lab)
        {
            label = lab;
            wasVisited = false;
        }
    }
}