using DSA.Library.Sorting;

namespace DSA.Tests
{
    public class BubbleSortTests
    {
        [Fact]
        public void ValidateSort()
        {
            BubbleSort bubbleSort = new BubbleSort();
            int[] array = { 7, 9, 10, 3, 5, 2, 1, 12, 4, 6, 8, 11 };
            int[] sorted = bubbleSort.Sort(array);
            Assert.Equal(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 }, sorted);
        }

        [Theory]
        [InlineData(new[] { 7, 9, 10, 3, 5, 2, 1, 6, 8, 11 }, new[] { 1, 2, 3, 5, 6, 7, 8, 9, 10, 11 })]
        [InlineData(new[] { 7, 9, 3, 5, 2, 1, 12, 4, 8, 11 }, new[] { 1, 2, 3, 4, 5, 7, 8, 9, 11, 12 })]
        [InlineData(new[] { 10, 3, 5, 2, 1, 12, 4, 6, 8, 11 }, new[] { 1, 2, 3, 4, 5, 6, 8, 10, 11, 12 })]
        [InlineData(new[] { 7, 9, 10, 3, 1, 12, 4, 6, 8, 11 }, new[] { 1, 3, 4, 6, 7, 8, 9, 10, 11, 12 })]
        [InlineData(new[] { 7, 3, 5, 2, 1, 4, 6, 8 }, new[] { 1, 2, 3, 4, 5, 6, 7, 8 })]
        [InlineData(new[] { 11 }, new[] { 11 })]
        [InlineData(new[] { 7, 9  }, new[] {  7,  9 })]
        [InlineData(new[] { 7 }, new[] {  7 })]
        public void ValidateArrays(int[] array, int[] expected)
        {
            BubbleSort bubbleSort = new BubbleSort();
            int[] sorted = bubbleSort.Sort(array);
            Assert.Equal(expected, sorted);
        }
    }
}
