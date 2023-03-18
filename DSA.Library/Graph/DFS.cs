﻿namespace DSA.Library.Graph
{
    public class DFS
    {
        private Graph graph;
        private List<int?> traverse;
        public DFS(Graph graph)
        {
            this.graph = graph;
            this.traverse = new List<int?>();
        }

        public int?[] Traverse()
        {
            bool[] visited = new bool[graph.Vertices];
            for (int i = 0; i < graph.Vertices; i++)
            {
                if (visited[i] == false)
                {
                    Util(i, visited);
                }
            }
            return traverse.ToArray();
        }

        private void Util(int v, bool[] visited)
        {
            visited[v] = true;
            traverse.Add(v);
            LinkedList<int> list = graph.GetAdjacents(v);
            for (int i = 0; i < list.Count; i++)
            {
                if (!visited[i])
                {
                    Util(i, visited);
                }
            }
        }
    }
}