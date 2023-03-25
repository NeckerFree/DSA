using DSA.Library.Sorting;

namespace DSA.Tests
{
    public class BubbleTests
    {
        [Theory]
        [InlineData(new int[] {1,2,3,4,5,6,7,8,9,10}, new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 })]
        public void ValidateBubbleSorting(int[] unsorted, int[] sorted)
        {
            int[] toSort = unsorted;
            Bubble.Sort(ref toSort);
            Assert.Equal(expected: sorted, toSort);

        }
    }
}
