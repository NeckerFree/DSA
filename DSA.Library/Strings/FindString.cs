namespace DSA.Library.Strings
{
    public class FindString
    {
        public string MinWindow(string inputString, string searchedText)
        {
            string response = "";
            if (String.IsNullOrWhiteSpace(inputString) ||String.IsNullOrWhiteSpace(searchedText)) return response;
            int[] map = new int[128];
            char[] searchedArray = searchedText.ToCharArray();
            foreach (char character in searchedArray)
            {
                map[character]++;
            }
            int start = 0, end = 0, minStart = 0, minLen = int.MaxValue, counter = searchedText.Length;
            char[] inputArray = inputString.ToCharArray();
            while (end < inputArray.Length)
            {
                char currentInputChar = inputArray[end];
                if (map[currentInputChar] > 0) counter--;
                map[currentInputChar]--;
                end++;
                while (counter == 0)
                {
                    if ((end - start) < minLen)
                    {
                        minLen = end - start;
                        minStart = start;
                    }

                    char firstCharCandidate = inputArray[start];
                    map[firstCharCandidate]++;
                    if (map[firstCharCandidate] > 0) counter++;
                    start++;
                }
            }
            response=(minLen == int.MaxValue) ? "" : inputString.Substring(minStart, minLen);
            return response;
        }

    }
}
