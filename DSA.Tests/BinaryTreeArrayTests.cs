using DSA.Library.Trees;

namespace DSA.Tests
{
    public class BinaryTreeArrayTests
    {

        [Fact]
        public void ValidatePreOrder()
        {
            Node<int> root = new Node<int>(25);
            root.left = new Node<int>(15);
            //root.left.left = new Node<int>(10);
            //root.left.left.left = new Node<int>(4);
            //root.left.left.right = new Node<int>(12);
            //root.left.right = new Node<int>(22);
            //root.left.right.left = new Node<int>(18);
            //root.left.right.right = new Node<int>(24);

            root.right = new Node<int>(50);
            //root.right.left = new Node<int>(35);
            //root.right.left.left = new Node<int>(31);
            //root.right.left.right = new Node<int>(44);
            //root.right.right = new Node<int>(70);
            //root.right.right.left = new Node<int>(66);
            //root.right.right.right = new Node<int>(90);
            BinaryTree<int> tree = new BinaryTree<int>(root);
            int[] actual = tree.PreOrder();
            Assert.Equal(new int[] { 25, 15, 10, 4, 12, 22, 18, 24, 50, 35, 31, 44, 70, 66, 90 }, actual);
        }
        [Fact]
        public void ValidateInOrder()
        {
            Node<int> root = new Node<int>(25);
            root.left = new Node<int>(15);
            root.left.left = new Node<int>(10);
            root.left.left.left = new Node<int>(4);
            root.left.left.right = new Node<int>(12);
            root.left.right = new Node<int>(22);
            root.left.right.left = new Node<int>(18);
            root.left.right.right = new Node<int>(24);

            root.right = new Node<int>(50);
            root.right.left = new Node<int>(35);
            root.right.left.left = new Node<int>(31);
            root.right.left.right = new Node<int>(44);
            root.right.right = new Node<int>(70);
            root.right.right.left = new Node<int>(66);
            root.right.right.right = new Node<int>(90);
            BinaryTree<int> tree = new BinaryTree<int>(root);
            int[] actual = tree.InOrder();
            Assert.Equal(new int[] { 4, 10, 12, 15, 18, 22, 24, 25, 31, 35, 44, 50, 66, 70, 90 }, actual);
        }
        [Fact]
        public void ValidatePostOrder()
        {
            Node<int> root = new Node<int>(25);
            root.left = new Node<int>(15);
            root.left.left = new Node<int>(10);
            root.left.left.left = new Node<int>(4);
            root.left.left.right = new Node<int>(12);
            root.left.right = new Node<int>(22);
            root.left.right.left = new Node<int>(18);
            root.left.right.right = new Node<int>(24);

            root.right = new Node<int>(50);
            root.right.left = new Node<int>(35);
            root.right.left.left = new Node<int>(31);
            root.right.left.right = new Node<int>(44);
            root.right.right = new Node<int>(70);
            root.right.right.left = new Node<int>(66);
            root.right.right.right = new Node<int>(90);
            BinaryTree<int> tree = new BinaryTree<int>(root);
            int[] actual = tree.PostOrder();
            Assert.Equal(new int[] { 4, 12, 10, 18, 24, 22, 15, 31, 44, 35, 66, 90, 70, 50, 25 }, actual);
        }
    }
}
