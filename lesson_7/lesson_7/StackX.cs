/*
 1.	Написать функции, которые считывают матрицу смежности из файла и выводят её на экран.
2.	Написать рекурсивную функцию обхода графа в глубину.
3.	Написать функцию обхода графа в ширину.
4.	*Создать библиотеку функций для работы с графами.
*/

namespace GraphInDepth
{
    public class StackX
    {
        private readonly int SIZE = 20;
        private int[] st;
        private int top;
        public StackX()
        {
            st = new int[SIZE];
            top = -1;
        }
        public virtual void push(int j)
        {
            st[++top] = j;
        }
        public virtual int pop()
        {
            return st[top--];
        }
        public virtual int peek()
        {
            return st[top];
        }
        public virtual bool Empty
        {
            get
            {
                return (top == -1);
            }
        }
    }    
}