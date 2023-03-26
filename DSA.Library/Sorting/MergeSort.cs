namespace DSA.Library.Sorting
{
    public class MergeSort
    {
        private int[] inputArray;

        public int LengthArray { get; private set; }

        public int Operations { get; private set; }

        public MergeSort(int[] inputArray)
        {
            this.inputArray = inputArray;
            LengthArray = inputArray.Length;
        }

        public int[] Execute()
        {
            SortSubArray(0, inputArray.Length);
            return inputArray;
        }


        private void SortSubArray(int left, int right)
        {
            if (right == left)
            {
                return;
            }
            int middle = left + (right - left) / 2;
            SortSubArray(left, middle);
            SortSubArray(middle + 1, right);
            Merge(left, middle, right);
        }



        private void Merge(int left, int middle, int right)
        {
            int index = 0;
            int i = 0;
            int j = 0;
            var leftArray = inputArray[left..(middle + 1)];
            var rightLimit= (right == LengthArray) ? right : right + 1;
            var rightArray = inputArray[(middle + 1)..(rightLimit)] ;
            while (i < leftArray.Length && j < rightArray.Length)
            {
                Operations++;
                if (leftArray[i] < rightArray[j])
                {
                    inputArray[left+ index++] = leftArray[i++];
                    Operations++;
                }
                else
                {
                    inputArray[left+ index++] = rightArray[j++];
                    Operations++;
                }
            }
            while (i < leftArray.Length)
            {
                inputArray[left+ index++] = leftArray[i++];
                Operations++;
            }
            
        }

        public static int[] GenerateRandomNumber(int size)
        {
            var array = new int[size];
            var rand = new Random();
            var maxNum = 10000;

            for (int i = 0; i < size; i++)
                array[i] = rand.Next(maxNum + 1);

            return array;
        }

        public static int[] GenerateSortedNumber(int size)
        {
            var array = new int[size];

            for (int i = 0; i < size; i++)
                array[i] = i;

            return array;
        }
    }
}
