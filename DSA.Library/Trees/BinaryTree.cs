namespace DSA.Library.Trees
{
    public class BinaryTree
    {
        Node? root;

        public BinaryTree(Node? root)
        {
            this.root = root;
        }
        public int MinimumDepth()
        {
            return CalculateMinDepth(root);
        }
        public int MinimumDepthWithQueue()
        {
            return CalculateMinDepthWithQueue(root);
        }
        private int CalculateMinDepth(Node? node)
        {
            int depth = 0;
            if (node is null)
            {
                return depth;
            }
            depth++;
            Node? leftNode = node.left;
            Node? rigthNode = node.right;
            if (leftNode is not null && rigthNode is not null)
            {
                depth = depth + Math.Min(CalculateMinDepth(leftNode), CalculateMinDepth(rigthNode));
            }
            return depth;

        }


        private int CalculateMinDepthWithQueue(Node? node)
        {
            int depth = 0;
            if (node is null)
            {
                return 0;
            }
            
            Queue<QItem> queue = new Queue<QItem>();
            depth++;
            QItem qItem = new QItem(node, depth);
            queue.Enqueue(qItem);
            while (queue.Count != 0)
            {
                qItem = queue.Dequeue();
                depth=qItem.depth;
                Node? currentNode = qItem.node;
                if (currentNode is null || currentNode.left is null || currentNode.right is null)
                {
                    return qItem.depth;
                }
                depth++;
                qItem=new QItem(currentNode.left, depth);
                queue.Enqueue(qItem);
                qItem = new QItem(currentNode.right, depth);
                queue.Enqueue(qItem);
            }
            return depth;
        }
    }
}
