using DSA.Library.Graph;

namespace DSA.Tests
{
    public class DFSTests
    {
        [Fact]
        public void ValidateDeepFirstTraversal()
        {
            Graph graph = new Graph(4);

            graph.AddEdge(0, 1);
            graph.AddEdge(0, 2);
            graph.AddEdge(1, 2);
            graph.AddEdge(2, 0);
            graph.AddEdge(2, 3);
            graph.AddEdge(3, 3);

            DFS dFS=new DFS(graph);
            int?[] traverse = dFS.Traverse();
            int?[] expected = { 0, 1, 2, 3 };
            Assert.Equal(expected, traverse);
        }
    }
   
}
