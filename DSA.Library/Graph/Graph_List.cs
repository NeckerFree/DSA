
using System.Text;

namespace DSA.Library.Graph
{
    public class Graph_List
    {
        private int[][] _matrix;
        private int _dimension;
        private IList<Tuple<int, int>> _adjacentList;
        public Graph_List(int dimension)
        {
            _adjacentList = new List<Tuple<int, int>>();
            _matrix=new int[dimension][];
            for (int i = 0; i < dimension; i++)
            {
                _matrix[i] = new int[dimension];
            }
            _dimension = dimension;

        }
        public void AddEdge(int origen, int destination)
        {
            _adjacentList.Add(new(origen, destination));
            _matrix[origen][destination] = 1;
        }
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < _adjacentList.Count; i++)
            {
                var element = _adjacentList[i];
                stringBuilder.Append($"({element.Item1},{element.Item2}) ");

            }
            return stringBuilder.ToString();
        }
    }
}
