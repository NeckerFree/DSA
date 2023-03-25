using DSA.Library.Searching;

namespace DSA.Tests
{
    public class SearchTests
    {
        [Fact]
        public void BinarySearch()
        {
            int[] input = { 10, 20, 30, 50, 60, 80, 110, 130, 140, 170 };
            Search search = new Search(input);
            int actual = search.BinarySearchRecursive(110);
            Assert.Equal(6, actual);
        }
        [Fact]
        public void BinarySearchEmptyArray()
        {
            int[] input = { };
            Search search = new Search(input);
            int actual = search.BinarySearchRecursive(110);
            Assert.Equal(-1, actual);
        }
        [Fact]
        public void BinarySearchInexistentValue()
        {
            int[] input = { 10, 20, 30, 50, 60, 80, 110, 130, 140, 170 };
            Search search = new Search(input);
            int actual = search.BinarySearchRecursive(78);
            Assert.Equal(-1, actual);
        }
        [Fact]
        public void BinarySearchOneElement()
        {
            int[] input = { 10 };
            Search search = new Search(input);
            int actual = search.BinarySearchRecursive(10);
            Assert.Equal(0, actual);
        }

        [Fact]
        public void BinarySearchNotRecursive()
        {
            int[] input = { 10, 20, 30, 50, 60, 80, 110, 130, 140, 170,400 };
            Search search = new Search(input);
            int actual = search.BinarySearchIterative(110);
            Assert.Equal(6, actual);
        }
    }
}
