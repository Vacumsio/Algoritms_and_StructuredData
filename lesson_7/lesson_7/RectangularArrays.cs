
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