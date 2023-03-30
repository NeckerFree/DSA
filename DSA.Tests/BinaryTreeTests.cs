using DSA.Library.Trees;

namespace DSA.Tests
{
    public class BinaryTreeTests
    {
        [Fact]
        public void CalculateMinDepth_0()
        {
            Node? root = null;
            BinaryTree binaryTree = new BinaryTree(root);
            int depth = binaryTree.MinimumDepth();
            Assert.Equal(0, depth);
        }
        [Fact]
        public void CalculateMinDepth_1()
        {
            Node? root = new Node(1);
            BinaryTree binaryTree = new BinaryTree(root);
            int depth = binaryTree.MinimumDepth();
            Assert.Equal(1, depth);
        }
        [Fact]
        public void CalculateMinDepth_2()
        {
            Node root = new Node(1);
            root.left = new Node(2);
            root.left.left = new Node(7);
            root.left.right = new Node(8);
            root.right=new Node(9);
            BinaryTree binaryTree = new BinaryTree(root);
            int depth = binaryTree.MinimumDepth();
            Assert.Equal(2, depth);
        }
        [Fact]
        public void CalculateMinDepth_3()
        {
            Node root = new Node(1);
            root.left = new Node(2);
            root.left.left = new Node(7);
            root.left.right = new Node(8);
            root.left.left.left = new Node(9);
            root.left.left.right = new Node(10);

            root.right = new Node(3);
            root.right.left = new Node(4); //3
            root.right.right = new Node(5); 
            root.right.right.left = new Node(6);
            
            BinaryTree binaryTree = new BinaryTree(root);
            int depth = binaryTree.MinimumDepth();
            Assert.Equal(3, depth);
        }
        [Fact]
        public void CalculateMinDepth_4()
        {
            Node root = new Node(1);
            root.left = new Node(2);
            root.right = new Node(3);
            root.left.left = new Node(4);
            root.left.right = new Node(5);
            root.right.left = new Node(6);
            root.right.right = new Node(7);
            root.left.left.left = new Node(8);
            root.left.left.right = new Node(9);
            root.left.right.left = new Node(10);
            root.left.right.right = new Node(11);
            root.right.left.left = new Node(12);
            root.right.left.right = new Node(13);
            root.right.right.left = new Node(14);
            root.right.right.right = new Node(15);
            BinaryTree binaryTree = new BinaryTree(root);
            int depth = binaryTree.MinimumDepth();
            Assert.Equal(4, depth);
        }


        [Fact]
        public void CalculateMinDepthWithQueue_0()
        {
            Node? root = null;
            BinaryTree binaryTree = new BinaryTree(root);
            int depth = binaryTree.MinimumDepthWithQueue();
            Assert.Equal(0, depth);
        }
        [Fact]
        public void CalculateMinDepthWithQueue_1()
        {
            Node? root = new Node(1);
            BinaryTree binaryTree = new BinaryTree(root);
            int depth = binaryTree.MinimumDepthWithQueue();
            Assert.Equal(1, depth);
        }
        [Fact]
        public void CalculateMinDepthWithQueue_2()
        {
            Node root = new Node(0);
            root.left = new Node(-1);
            root.left.left = new Node(-2);
            root.left.right = new Node(-3);
            root.right = new Node(1);
            BinaryTree binaryTree = new BinaryTree(root);
            int depth = binaryTree.MinimumDepthWithQueue();
            Assert.Equal(2, depth);
        }
        [Fact]
        public void CalculateMinDepthWithQueue_3()
        {
            Node root = new Node(1);
            root.left = new Node(2);
            root.left.left = new Node(7);
            root.left.right = new Node(8);
            root.left.left.left = new Node(9);
            root.left.left.right = new Node(10);

            root.right = new Node(3);
            root.right.left = new Node(4); //3
            root.right.right = new Node(5);
            root.right.right.left = new Node(6);

            BinaryTree binaryTree = new BinaryTree(root);
            int depth = binaryTree.MinimumDepthWithQueue();
            Assert.Equal(3, depth);
        }
        [Fact]
        public void CalculateMinDepthWithQueue_4()
        {
            Node root = new Node(0);
            root.left = new Node(-1);
            root.left.left = new Node(-2);
            root.left.right = new Node(-3);
            root.left.left.left = new Node(-4);
            root.left.left.right = new Node(-5);
            root.left.right.left = new Node(-6);
            root.left.right.right = new Node(-7);

            root.right = new Node(1);
            root.right.left = new Node(2);
            root.right.left.left = new Node(3);
            root.right.left.right = new Node(4);

            root.right.right = new Node(5);
            root.right.right.left = new Node(6);
            root.right.right.right = new Node(7);
            BinaryTree binaryTree = new BinaryTree(root);
            int depth = binaryTree.MinimumDepthWithQueue();
            Assert.Equal(4, depth);
        }
    }
}
