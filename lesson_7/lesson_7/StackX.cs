
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