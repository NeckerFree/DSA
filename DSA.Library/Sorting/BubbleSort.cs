namespace DSA.Library.Sorting
{
    public class BubbleSort
    {
        public int[] Sort(int[] array)
        {
            
            int firstIndex = array.Length - 1;
            for (int i = 0; i <firstIndex ; i++)
            {
                int secondIndex = array.Length - i - 1;
                for (int j = 0; j < secondIndex; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        (array[j], array[j+1]) = (array[j+1], array[j]);
                    }
                }
            }
            return array;
        }
    }
}
