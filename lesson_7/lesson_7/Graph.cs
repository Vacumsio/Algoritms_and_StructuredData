using System;

namespace GraphInDepth
{
    public class Graph
    {
        private readonly int MAX_VERTS = 20;
        private Vertex[] vertexList;
        private int[][] adjMat;
        private int nVerts;
        private StackX theStack;
        public Graph()
        {
            vertexList = new Vertex[MAX_VERTS];

            adjMat = RectangularArrays.ReturnRectangularIntArray(MAX_VERTS, MAX_VERTS);
            nVerts = 0;
            for (int j = 0; j < MAX_VERTS; j++)
            {
                for (int k = 0; k < MAX_VERTS; k++)
                {
                    adjMat[j][k] = 0;
                }
            }
            theStack = new StackX();
        }

        public virtual void addVertex(char lab)
        {
            vertexList[nVerts++] = new Vertex(lab);
        }

        public virtual void addEdge(int start, int end)
        {
            adjMat[start][end] = 1;
            adjMat[end][start] = 1;
        }

        public virtual void displayVertex(int v)
        {
            Console.Write(vertexList[v].label);
        }

        public virtual void dfs()
        {
            vertexList[0].wasVisited = true;
            displayVertex(0);
            theStack.push(0);
            while (!theStack.Empty)
            {
                int v = getAdjUnvisitedVertex(theStack.peek());
                if (v == -1)
                {
                    theStack.pop();
                }
                else
                {
                    vertexList[v].wasVisited = true;
                    displayVertex(v);
                    theStack.push(v);
                }
            }
            for (int j = 0; j < nVerts; j++)
            {
                vertexList[j].wasVisited = false;
            }
        }

        public virtual int getAdjUnvisitedVertex(int v)
        {
            for (int j = 0; j < nVerts; j++)
            {
                if (adjMat[v][j] == 1 && vertexList[j].wasVisited == false)
                {
                    return j;
                }
            }
            return -1;
        }
    }
}
    
