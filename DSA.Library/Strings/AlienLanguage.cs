namespace DSA.Library.Strings
{
    public class AlienLanguage
    {
        public int Operations { get; set; }

        public bool IsAlienSorted(string[] words, string order)
        {
            if (words == null || words.Length <= 1)
            {
                return true;
            }
            var hasOrder = new Dictionary<char, int>();
            for (int i = 0; i < order.Length; i++)
            {
                
                hasOrder[order[i]] = i;
            }
            for (int i = 0; i < words.Length - 1; i++)
            {
                string sentence = words[i];
                string next = words[i + 1];
                for (int j = 0; j < sentence.Length; j++)
                {

                    Operations++;
                    if (j>=next.Length) return false;
                    int indexLetterSentence = hasOrder[sentence[j]];
                    int indexLetterNext = hasOrder[next[j]];
                    if (indexLetterSentence != indexLetterNext)
                    {
                        if (indexLetterNext < indexLetterSentence)
                        {
                            return false;
                        }
                        else
                        {
                            break;

                        }
                    }
                }
            }
            return true;
        }
    }
}
