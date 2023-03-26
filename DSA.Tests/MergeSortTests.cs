using DSA.Library.Sorting;

namespace DSA.Tests
{
    public class MergeSortTests
    {
        [Theory]
        [InlineData(new int[] { 3, 2, 1 }, new int[] { 1, 2, 3 })]
        [InlineData(new int[] { 1, 2, 3 }, new int[] { 1, 2, 3 })]
        [InlineData(new int[] { 5, 4, 6 }, new int[] { 4, 5, 6 })]
        [InlineData(new int[] { 8, 7, 6, 5 }, new int[] { 5, 6, 7, 8 })]
        [InlineData(new int[] { 1, 1, 1 }, new int[] { 1, 1, 1 })]
        [InlineData(new int[] { 9 }, new int[] { 9 })]
        [InlineData(new int[] { }, new int[] { })]
        [InlineData(new int[] { 3, 1, 2 }, new int[] { 1, 2, 3 })]
        [InlineData(new int[] { -3, -2, -1 }, new int[] { -3, -2, -1 })]
        [InlineData(new int[] { 10, 5, 8, 2, 7 }, new int[] { 2, 5, 7, 8, 10 })]
        [InlineData(new int[] { 5, 3, 10, 6, 4, 8, 7, 9, 1, 2, 11, 12, 13, 14, 16 }, new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 16 })]
        [InlineData(new int[] { 5, 3, 10, 6, 4, 8, 7, 9, 1, 2, 11, 12, 13, 14, 16, 2 }, new int[] { 1, 2, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 16 })]
        public void ValidateMergeSortAlgorithm(int[] unsorted, int[] sorted)
        {
            MergeSort mergeSort = new MergeSort(unsorted);
            int[] actual = mergeSort.Execute();
            Assert.Equal(sorted, actual);
            Assert.Equal(64, mergeSort.Operations);
        }

    }
}
