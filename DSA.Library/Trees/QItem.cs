namespace DSA.Library.Trees
{
    public class QItem
    {
        public Node? node;
        public int depth;
        public QItem(Node node,int depth )
        {
            this.node = node;
            this.depth = depth;
        }
    }
}
