namespace DSA.Library.Trees
{
    public class QItem<T>
    {
        public Node<T>? node;
        public int depth;
        public QItem(Node<T> node,int depth )
        {
            this.node = node;
            this.depth = depth;
        }
    }
}
