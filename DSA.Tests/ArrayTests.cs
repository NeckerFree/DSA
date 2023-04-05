using DSA.Library.ArrayOp;

namespace DSA.Tests
{
    public class ArrayTests
    {

        //https://www.geeksforgeeks.org/find-smallest-value-represented-sum-subset-given-array
        [Fact]
        public void ValidateSmallestValueRepresentedSumSubsetGivenArray()
        {
            int[] array = { 1, 1, 3, 4 };
            int actual = ArrayOperations.SmallestValue(array);
            Assert.Equal(10, actual);
        }

        [Theory]
        [InlineData(new int[] { 1, 10, 3, 11, 6, 15 }, 2)]
        [InlineData(new int[] { 1, 1, 1, 1 }, 5)]
        [InlineData(new int[] { 1, 1, 3, 4 }, 10)]
        [InlineData(new int[] { 1, 2, 5, 10, 20, 40 }, 4)]
        [InlineData(new int[] { 1, 2, 3, 4, 5, 6 }, 22)]
        [InlineData(new int[] { 1, 2, 3, 8 }, 7)]
        [InlineData(new int[] { 1, 2, 3, 4, 12 }, 11)]
        public void ValidateSmallestValueRepresented(int[] array, int expected)
        {
            int actual = ArrayOperations.SmallestValue(array);
            Assert.Equal(expected, actual);
        }
    }
}

