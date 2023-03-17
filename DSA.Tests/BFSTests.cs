namespace DSA.Tests
{
    public class BFSTests
    {
        public void ValidateBreadthFirstTraversal()
        {
            Graph graph = new Graph(4);

            graph.AddEdge(0, 1);
            graph.AddEdge(0, 2);
            graph.AddEdge(1, 2);
            graph.AddEdge(2, 0);
            graph.AddEdge(2, 3);
            graph.AddEdge(3, 3);
            
            BFS bFS = new BFS(graph);
            int[] traverse= bFS.Traverse(2);
            int[] expected = { 2, 0, 3, 1 };
            Assert.Equal(expected, traverse);
        }
    }
}
