using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace DSA.Library.Trees
{
    //public class BinaryTree
    //{
    //    Node? root;

    //    public BinaryTree(Node? root)
    //    {
    //        this.root = root;
    //    }
    //    public int MinimumDepth()
    //    {
    //        return CalculateMinDepth(root);
    //    }
    //    public int MinimumDepthWithQueue()
    //    {
    //        return CalculateMinDepthWithQueue(root);
    //    }
    //    private int CalculateMinDepth(Node? node)
    //    {
    //        int depth = 0;
    //        if (node is null)
    //        {
    //            return depth;
    //        }
    //        depth++;
    //        Node? leftNode = node.left;
    //        Node? rigthNode = node.right;
    //        if (leftNode is not null && rigthNode is not null)
    //        {
    //            depth = depth + Math.Min(CalculateMinDepth(leftNode), CalculateMinDepth(rigthNode));
    //        }
    //        return depth;

    //    }


    //    private int CalculateMinDepthWithQueue(Node? node)
    //    {
    //        int depth = 0;
    //        if (node is null)
    //        {
    //            return 0;
    //        }

    //        Queue<QItem> queue = new Queue<QItem>();
    //        depth++;
    //        QItem qItem = new QItem(node, depth);
    //        queue.Enqueue(qItem);
    //        while (queue.Count != 0)
    //        {
    //            qItem = queue.Dequeue();
    //            depth=qItem.depth;
    //            Node? currentNode = qItem.node;
    //            if (currentNode is null || currentNode.left is null || currentNode.right is null)
    //            {
    //                return qItem.depth;
    //            }
    //            depth++;
    //            qItem=new QItem(currentNode.left, depth);
    //            queue.Enqueue(qItem);
    //            qItem = new QItem(currentNode.right, depth);
    //            queue.Enqueue(qItem);
    //        }
    //        return depth;
    //    }
    //}

    public class BinaryTree<T>
    {
        private Node<T>? root;
        private T?[] treeArray;
        private int position;
        private int quantity;
        public BinaryTree(Node<T>? node)
        {
            root = node;
            position = 0;
            CountTreeNodes(root);
            treeArray = new T?[quantity];
        }

        private void CountTreeNodes(Node<T>? current)
        {
            if (current != null)
            {
                quantity++;
                if (current.left != null)
                {
                    CountTreeNodes(current.left);

                }
                if (current.right != null)
                {
                    CountTreeNodes(current.right);
                }
            }
            else quantity++;
        }

        public T?[] PreOrder()
        {
            PreOrder(root);
            return treeArray;
        }
        public void PreOrder(Node<T>? node)
        {
            if (node != null)
            {
                treeArray[position++] = node.data;
                PreOrder(node.left);
                PreOrder(node.right);
            }
            //treeArray[position++] = default(T);
        }
        public T?[] InOrder()
        {
            InOrder(root);
            return treeArray;
        }
        public void InOrder(Node<T>? node)
        {
            if (node != null)
            {
                InOrder(node.left);
                treeArray[position++] = node.data;
                InOrder(node.right);
            }
            //treeArray[position++] = default(T);
        }

        public T?[] PostOrder()
        {
            PostOrder(root);
            return treeArray;
        }
        public void PostOrder(Node<T>? node)
        {
            if (node != null)
            {
                PostOrder(node.left);
                PostOrder(node.right);
                treeArray[position++] = node.data;
            }
            //treeArray[position++] = default(T);
        }

        public int MinimumDepth()
        {
            return CalculateMinDepth(root);
        }
        public int MinimumDepthWithQueue()
        {
            return CalculateMinDepthWithQueue(root);
        }
        private int CalculateMinDepth(Node<T>? node)
        {
            int depth = 0;
            if (node is null)
            {
                return depth;
            }
            depth++;
            Node<T>? leftNode = node.left;
            Node<T>? rigthNode = node.right;
            if (leftNode is not null && rigthNode is not null)
            {
                depth = depth + Math.Min(CalculateMinDepth(leftNode), CalculateMinDepth(rigthNode));
            }
            return depth;

        }


        private int CalculateMinDepthWithQueue(Node<T>? node)
        {
            int depth = 0;
            if (node is null)
            {
                return 0;
            }

            Queue<QItem<T>> queue = new Queue<QItem<T>>();
            depth++;
            QItem<T> qItem = new QItem<T>(node, depth);
            queue.Enqueue(qItem);
            while (queue.Count != 0)
            {
                qItem = queue.Dequeue();
                depth = qItem.depth;
                Node<T>? currentNode = qItem.node;
                if (currentNode is null || currentNode.left is null || currentNode.right is null)
                {
                    return qItem.depth;
                }
                depth++;
                qItem = new QItem<T>(currentNode.left, depth);
                queue.Enqueue(qItem);
                qItem = new QItem<T>(currentNode.right, depth);
                queue.Enqueue(qItem);
            }
            return depth;
        }
    }
}
