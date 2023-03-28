namespace DSA.Library.Sorting
{
    public class QuickSort
    {
        public void Sort(int[] array, int low, int high)
        {
            if (low < high)
            {
                int partition = Partition(array, low, high);
                Sort(array, low, partition - 1);
                Sort(array, partition + 1, high);
            }
        }

        private int Partition(int[] array, int low, int high)
        { 
            int pivot = array[high];
            int i = low - 1;
            for (int j = low ; j <= high-1; j++)
            {
                if (array[j]< pivot)
                {
                    i++;
                    (array[j], array[i]) = (array[i], array[j]);
                }
            }
            (array[i+1], array[high]) = (array[high], array[i+1]);
            return i + 1;
        }
    }
}
