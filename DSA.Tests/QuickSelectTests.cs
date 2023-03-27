using DSA.Library.Searching;
using System;

namespace DSA.Tests
{
    public class QuickSelectTests
    {
        [Fact]
        public void ValidateQuickSort()
        {
            Random rand = new Random();
            int[] array =new int[50000];
                for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(50000);
            }
            //int[] array = { 5, 3, 10, 6, 4, 8, 7, 9, 1, 2, 11, 12, 13, 14, 16, 2 };
            int kPosition = 8;
         int actual=   QuickSelect.FindSmallest(array.ToList(), kPosition);
            Assert.Equal(4, actual);
            int expected = QuickSelect.Operations;
            Assert.Equal(6,expected);
        }
    }
}
