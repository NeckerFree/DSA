namespace DSA.Library.ArrayOp
{
    public class ArrayOperations
    {
        //int[] array = { 1, 1, 3, 4 };
        public static int SmallestValue(int[] array)
        {
            int candidate = 1;
            List<int> result = new List<int>();
            int arrayLength = array.Length;
            Array.Sort(array);
            result.Add(candidate);
            for (int i = 0; i < arrayLength && array[i] <= candidate; i++)
            {
                candidate = candidate + array[i];
                result.Add(candidate);
            }
            return candidate;

        }
    }
}
