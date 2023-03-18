using DSA.Library.Queue;
using System.Linq.Expressions;

namespace DSA.Library.Graph
{
    public class BFS
    {
        private Graph graph;

        public BFS(Graph graph)
        {
            this.graph = graph;
        }

        public int?[] Traverse(int nodeValue)
        {
            List<int?> traverse = new List<int?>();
            bool[] visited = new bool[graph.Vertices];
            for (int i = 0; i < visited.Length; i++)
            {
                visited[i] = false;
            }
            MyQueue<int> queue = new MyQueue<int>(graph.Vertices);
            visited[nodeValue] = true;
            queue.Enqueue(nodeValue);
            while (queue.IsEmpty == false)
            {
                nodeValue = queue.Dequeue();
                traverse.Add(nodeValue);

                LinkedList<int> list = graph.GetAdjacents(nodeValue);
                foreach (var item in list)
                {
                    if (!visited[item])
                    {
                        visited[item] = true;
                        queue.Enqueue(item);
                    }
                }
            }
            return traverse.ToArray();
        }
    }

}
