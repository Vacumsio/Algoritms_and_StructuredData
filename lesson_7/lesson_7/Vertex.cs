
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