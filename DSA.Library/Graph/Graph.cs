using DSA.Library.LinkedList;

namespace DSA.Library.Graph
{
    // This class represents a directed
    // graph using adjacency list
    // representation
    public class Graph
    {

        public int Edges { get; internal set; }

        MyLinkedList<int>[] _adjacencyList;

        public Graph(int numEdges)
        {
            _adjacencyList = new MyLinkedList<int>[numEdges];
            for (int i = 0; i < _adjacencyList.Length; i++)
            {
                _adjacencyList[i] = new MyLinkedList<int>();
            }
            Edges = numEdges;
        }

        

        public void AddEdge(int origen, int destination)
        {
            _adjacencyList[origen].AddLast(destination);
        }

        internal MyLinkedList<int> GetAdjacents(int v)
        {
           return _adjacencyList[v];
        }

        public class DFS
        {
            private Graph g;

            public DFS(Graph g)
            {
                this.g = g;
            }
        }
    }
}
