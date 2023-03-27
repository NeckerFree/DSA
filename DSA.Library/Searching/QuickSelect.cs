using System.Buffers;
using System.Numerics;

namespace DSA.Library.Searching
{
    public class QuickSelect
    {
        public static int Operations { get; set; }

        public static int FindSmallest(List<int> listElements, int k)
        {
            Operations++;
            if (listElements.Count == 1) return listElements[0];
            Random random = new Random();
            int pivot = listElements[random.Next(listElements.Count)];
            List<int> listMinor = new List<int>();
            List<int> listEqual = new List<int>();
            List<int> listMajor = new List<int>();

            foreach (var element in listElements)
            {
                if (element < pivot) listMinor.Add(element);
                if (element == pivot) listEqual.Add(element);
                if (element > pivot) listMajor.Add(element);
            }

            int minors = listMinor.Count;
            if (k <= minors)
            {
                return FindSmallest(listMinor, k);
            }
            else
            {
                int minorsPlusEquals = (listMinor.Count + listEqual.Count);
                if (k <= minorsPlusEquals) return pivot;
                else
                {
                    return FindSmallest(listMajor, k - minorsPlusEquals);
                }
            }

        }


        //public static int KthSmallest(int[] arr, int low, int high, int k)
        //{
        //    Operations++;
        //    // find the partition 
        //    int partition = partitions(arr, low, high);

        //    // if partition value is equal to the kth position, 
        //    // return value at k.
        //    if (partition == k)
        //        return arr[partition];

        //    // if partition value is less than kth position,
        //    // search right side of the array.
        //    else if (partition < k)
        //        return KthSmallest(arr, partition + 1, high, k);

        //    // if partition value is more than kth position, 
        //    // search left side of the array.
        //    else
        //        return KthSmallest(arr, low, partition - 1, k);
        //}

        // partition function similar to quick sort 
        // Considers last element as pivot and adds 
        // elements with less value to the left and 
        // high value to the right and also changes 
        // the pivot position to its respective position
        // in the readonly array.
        //static private int partitions(int[] arr, int low, int high)
        //{
        //    Operations++;
        //    int pivot = arr[high], pivotloc = low, temp;
        //    for (int i = low; i <= high; i++)
        //    {
        //        // inserting elements of less value 
        //        // to the left of the pivot location
        //        if (arr[i] < pivot)
        //        {
        //            temp = arr[i];
        //            arr[i] = arr[pivotloc];
        //            arr[pivotloc] = temp;
        //            pivotloc++;
        //        }
        //    }

        //    // swapping pivot to the readonly pivot location
        //    temp = arr[high];
        //    arr[high] = arr[pivotloc];
        //    arr[pivotloc] = temp;

        //    return pivotloc;
        //}
    }
}