namespace DSA.Library.Graph
{
    // This class represents a directed
    // graph using adjacency list
    // representation
    public class Graph
    {

        private int _numVertices;

        LinkedList<int>[] _adjacencyList;

        public Graph(int numVertices)
        {
            _adjacencyList = new LinkedList<int>[numVertices];
            for (int i = 0; i < _adjacencyList.Length; i++)
            {
                _adjacencyList[i] = new LinkedList<int>();
            }
            _numVertices = numVertices;
        }

        public void AddEdge(int origen, int destination)
        {
            _adjacencyList[origen].AddLast(destination);
        }

    }
}
