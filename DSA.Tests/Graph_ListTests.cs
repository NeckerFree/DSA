namespace DSA.Tests
{
    public class Graph_ListTests
    {
        [Fact]
        public void ValidateAdjacentList()
        {
            //[ [1, 6, 8],
            //[0, 4, 6, 9],
            //[4, 6],
            //[4, 5, 8],
            //[1, 2, 3, 5, 9],
            //[3, 4],
            //[0, 1, 2],
            //[8, 9],
            //[0, 3, 7],
            //[1, 4, 7] ]
            Graph_List graph_List = new Graph_List(10);
            graph_List.AddEdge(0, 1);
            graph_List.AddEdge(0, 6);
            graph_List.AddEdge(0, 8);

            graph_List.AddEdge(1, 0);
            graph_List.AddEdge(1, 4);
            graph_List.AddEdge(1, 6);
            graph_List.AddEdge(1, 9);

            graph_List.AddEdge(2, 4);
            graph_List.AddEdge(2, 6);

            graph_List.AddEdge(3, 4);
            graph_List.AddEdge(3, 5);
            graph_List.AddEdge(3, 8);

            graph_List.AddEdge(4, 1);
            graph_List.AddEdge(4, 2);
            graph_List.AddEdge(4, 3);
            graph_List.AddEdge(4, 5);
            graph_List.AddEdge(4, 9);

            graph_List.AddEdge(5, 3);
            graph_List.AddEdge(5, 4);

            graph_List.AddEdge(6, 0);
            graph_List.AddEdge(6, 1);
            graph_List.AddEdge(6, 2);

            graph_List.AddEdge(7, 8);
            graph_List.AddEdge(7, 9);

            graph_List.AddEdge(8, 0);
            graph_List.AddEdge(8, 3);
            graph_List.AddEdge(8, 7);

            graph_List.AddEdge(9, 1);
            graph_List.AddEdge(9, 4);
            graph_List.AddEdge(9, 7);

            string result= graph_List.ToString();
            Assert.NotEmpty(result);

        }
    }
}
