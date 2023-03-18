namespace DSA.Library.Graph
{
    // This class represents a directed
    // graph using adjacency list
    // representation
    public class Graph
    {

        public int Vertices { get; internal set; }

        LinkedList<int>[] _adjacencyList;

        public Graph(int numVertices)
        {
            _adjacencyList = new LinkedList<int>[numVertices];
            for (int i = 0; i < _adjacencyList.Length; i++)
            {
                _adjacencyList[i] = new LinkedList<int>();
            }
            Vertices = numVertices;
        }

        

        public void AddEdge(int origen, int destination)
        {
            _adjacencyList[origen].AddLast(destination);
        }

        internal LinkedList<int> GetAdjacents(int v)
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
