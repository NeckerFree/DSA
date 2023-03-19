
namespace DSA.Tests
{
    public class BFSTests
    {
        [Fact]
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
            int?[] traverse= bFS.Traverse(3);
            int?[] expected = { 2, 0, 3, 1 };
            Assert.Equal(expected, traverse);
        }

        [Fact] public void ValidateBreadthSecondTraversal()
        {
            Graph graph = new Graph(6);
            graph.AddEdge(0, 2);
            graph.AddEdge(2, 3);
            graph.AddEdge(2, 5);
            graph.AddEdge(5, 4);
            graph.AddEdge(4, 1);

            BFS bFS = new BFS(graph);
            int?[] traverse = bFS.Traverse(0);
            int?[] expected = { 0,2,5,3,4,1};
            Assert.Equal(expected, traverse);
        }
    }
}
