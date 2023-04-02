using DSA.Library.Trees;

namespace DSA.Tests
{
    public class BinaryTreeTests
    {
        [Fact]
        public void CalculateMinDepth_0()
        {
            Node<int>? root = null;
            BinaryTree<int> binaryTree = new BinaryTree<int>(root);
            int depth = binaryTree.MinimumDepth();
            Assert.Equal(0, depth);
        }
        [Fact]
        public void CalculateMinDepth_1()
        {
            Node<int>? root = new Node<int>(1);
            BinaryTree<int> binaryTree = new BinaryTree<int>(root);
            int depth = binaryTree.MinimumDepth();
            Assert.Equal(1, depth);
        }
        [Fact]
        public void CalculateMinDepth_2()
        {
            Node<int> root = new Node<int>(1);
            root.left = new Node<int>(2);
            root.left.left = new Node<int>(7);
            root.left.right = new Node<int>(8);
            root.right=new Node<int>(9);
            BinaryTree<int> binaryTree = new BinaryTree<int>(root);
            int depth = binaryTree.MinimumDepth();
            Assert.Equal(2, depth);
        }
        [Fact]
        public void CalculateMinDepth_3()
        {
            Node<int> root = new Node<int>(1);
            root.left = new Node<int>(2);
            root.left.left = new Node<int>(7);
            root.left.right = new Node<int>(8);
            root.left.left.left = new Node<int>(9);
            root.left.left.right = new Node<int>(10);

            root.right = new Node<int>(3);
            root.right.left = new Node<int>(4); //3
            root.right.right = new Node<int>(5); 
            root.right.right.left = new Node<int>(6);
            
            BinaryTree<int> binaryTree = new BinaryTree<int>(root);
            int depth = binaryTree.MinimumDepth();
            Assert.Equal(3, depth);
        }
        [Fact]
        public void CalculateMinDepth_4()
        {
            Node<int> root = new Node<int>(1);
            root.left = new Node<int>(2);
            root.right = new Node<int>(3);
            root.left.left = new Node<int>(4);
            root.left.right = new Node<int>(5);
            root.right.left = new Node<int>(6);
            root.right.right = new Node<int>(7);
            root.left.left.left = new Node<int>(8);
            root.left.left.right = new Node<int>(9);
            root.left.right.left = new Node<int>(10);
            root.left.right.right = new Node<int>(11);
            root.right.left.left = new Node<int>(12);
            root.right.left.right = new Node<int>(13);
            root.right.right.left = new Node<int>(14);
            root.right.right.right = new Node<int>(15);
            BinaryTree<int> binaryTree = new BinaryTree<int>(root);
            int depth = binaryTree.MinimumDepth();
            Assert.Equal(4, depth);
        }


        [Fact]
        public void CalculateMinDepthWithQueue_0()
        {
            Node<int>? root = null;
            BinaryTree<int> binaryTree = new BinaryTree<int>(root);
            int depth = binaryTree.MinimumDepthWithQueue();
            Assert.Equal(0, depth);
        }
        [Fact]
        public void CalculateMinDepthWithQueue_1()
        {
            Node<int>? root = new Node<int>(1);
            BinaryTree<int> binaryTree = new BinaryTree<int>(root);
            int depth = binaryTree.MinimumDepthWithQueue();
            Assert.Equal(1, depth);
        }
        [Fact]
        public void CalculateMinDepthWithQueue_2()
        {
            Node<int> root = new Node<int>(0);
            root.left = new Node<int>(-1);
            root.left.left = new Node<int>(-2);
            root.left.right = new Node<int>(-3);
            root.right = new Node<int>(1);
            BinaryTree<int> binaryTree = new BinaryTree<int>(root);
            int depth = binaryTree.MinimumDepthWithQueue();
            Assert.Equal(2, depth);
        }
        [Fact]
        public void CalculateMinDepthWithQueue_3()
        {
            Node<int> root = new Node<int>(1);
            root.left = new Node<int>(2);
            root.left.left = new Node<int>(7);
            root.left.right = new Node<int>(8);
            root.left.left.left = new Node<int>(9);
            root.left.left.right = new Node<int>(10);

            root.right = new Node<int>(3);
            root.right.left = new Node<int>(4); //3
            root.right.right = new Node<int>(5);
            root.right.right.left = new Node<int>(6);

            BinaryTree<int> binaryTree = new BinaryTree<int>(root);
            int depth = binaryTree.MinimumDepthWithQueue();
            Assert.Equal(3, depth);
        }
        [Fact]
        public void CalculateMinDepthWithQueue_4()
        {
            Node<int> root = new Node<int>(0);
            root.left = new Node<int>(-1);
            root.left.left = new Node<int>(-2);
            root.left.right = new Node<int>(-3);
            root.left.left.left = new Node<int>(-4);
            root.left.left.right = new Node<int>(-5);
            root.left.right.left = new Node<int>(-6);
            root.left.right.right = new Node<int>(-7);

            root.right = new Node<int>(1);
            root.right.left = new Node<int>(2);
            root.right.left.left = new Node<int>(3);
            root.right.left.right = new Node<int>(4);

            root.right.right = new Node<int>(5);
            root.right.right.left = new Node<int>(6);
            root.right.right.right = new Node<int>(7);
            BinaryTree<int> binaryTree = new BinaryTree<int>(root);
            int depth = binaryTree.MinimumDepthWithQueue();
            Assert.Equal(4, depth);
        }
    }
}
