namespace DSA.Library.Searching
{
    public class Search
    {
        //Problem: Given a sorted array arr[] of n elements, write a function to search a given element x in arr[] 
        //and return the index of x in the array.Consider array is 0 base index.

        //Input: arr[] = { 10, 20, 30, 50, 60, 80, 110, 130, 140, 170}, x = 110
        //Output: 6
        //Explanation: Element x is present at index 6. 
        private int[] input;
        private int arrayLength = 0;
        public Search(int[] input)
        {
            this.input = input;
            arrayLength = input.Length;
        }

        public int BinarySearchRecursive(int valueToSearch)
        {
           return BinarySearchRecursive(0, input.Length, valueToSearch);
        }

        public int BinarySearchIterative(int valueToSearch)
        {
            return BinarySearchIterative(0, input.Length, valueToSearch);
        }

        private int BinarySearchIterative(int low, int high, int target)
        {       
            while (low < high)
            {
                int middle=(low+high)/2;
                
                if (target < input[middle])
                {
                    high = middle;
                }
                else
                {
                     if (target > input[middle])
                    {
                        low = middle;
                    }
                     else return middle;
                }

            }
            return -1;
        }

        private int BinarySearchRecursive(int lowIndex, int highIndex, int valueToSearch)
        {
            if (lowIndex==highIndex) { return -1;}
             int middle = lowIndex + (int)Math.Floor((decimal)(highIndex-lowIndex) / 2);
           
            if (input[middle] == valueToSearch)
            {
                return middle;
            }
            if (middle == lowIndex) { return -1; }
            if (input[middle] > valueToSearch)
            {
                return BinarySearchRecursive(lowIndex, middle-1 , valueToSearch);
            }
            else
            {
                return BinarySearchRecursive(middle+1, arrayLength, valueToSearch);
            }
        }
    }
}
