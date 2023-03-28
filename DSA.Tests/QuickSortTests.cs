using DSA.Library.Sorting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Tests
{
    public class QuickSortTests
    {
        [Fact]
        public void ValidateQuickSort()
        {
            Random rand = new Random();
            int[] array=new int[50];
            int[] sorted = new int[50];
            for (int i = 0; i < array.Length; i++) 
            {
                array[i] = rand.Next(50);
                sorted[i] = i;
            }
            QuickSort quickSort = new QuickSort();
            quickSort.Sort(array, 0, array.Length - 1);
            Assert.Equal(sorted, array);
        }
    }
}
