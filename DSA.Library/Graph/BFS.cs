using DSA.Library.LinkedList;
using DSA.Library.Queue;
using System;
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
            List<int?> path = new List<int?>();
            bool[] visited = new bool[graph.Edges];
            for (int i = 0; i < visited.Length; i++)
            {
                visited[i] = false;
            }
            MyQueue<int> queue = new MyQueue<int>(graph.Edges);
            visited[nodeValue] = true;
            queue.Enqueue(nodeValue);
            while (queue.IsEmpty == false)
            {
                nodeValue = queue.Dequeue();
                path.Add(nodeValue);

                MyLinkedList<int> list = graph.GetAdjacents(nodeValue);
                for (int i = 0; i < list.Count; i++)
                {
                    var item = list.GetElementByIndex(i);
                    if (!visited[item])
                    {
                        visited[item] = true;
                        queue.Enqueue(item);
                    }
                }
            }
            return path.ToArray();
        }
    }

}
