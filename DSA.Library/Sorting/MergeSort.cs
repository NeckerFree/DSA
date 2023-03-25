namespace DSA.Library.Sorting
{
    public class MergeSort
    {
        private int[] inputArray;

        public MergeSort(int[] inputArray)
        {
            this.inputArray = inputArray;
        }

        public int[] Execute()
        {
            SortSubArray(0, inputArray.Length);
            return inputArray;
        }

        private void SortSubArray(int low, int high)
        {
            if (low < high)
            {
                int middle = low + (high - low) / 2;
                if (middle > 0)
                {
                    SortSubArray(low, middle);
                    SortSubArray(middle + 1, high);
                    Merge(low, middle, high);
                }
                
            }
        }

        private void Merge(int low, int middle, int high)
        {
            int leftLength = middle - low + 1;
            int rightLength = high - middle;
            var leftArray = inputArray[leftLength..middle];
            var rightArray = inputArray[middle..rightLength];
            int i = 0;
            int j = 0;
            int k = low;
            while (i < leftLength && j < rightLength)
            {
                if (leftArray[i] <= rightArray[j])
                {
                    inputArray[k++] = leftArray[i++];
                }
                else
                {
                    inputArray[k++] = rightArray[j++];
                }
            }
            while (i < leftLength)
            {
                inputArray[k++] = leftArray[i++];
            }
            while (j < rightLength)
            {
                inputArray[k++] = rightArray[j++];
            }
        }
    }
}
