namespace DSA.Library.Strings
{
    public class Palindrome
    {
          public bool IsPalindrome(string value)
        {
            char[] array = value.ToCharArray();
            Array.Reverse(array);
            string valueReverse = new string(array);
            return (value == valueReverse);
        }
        public string LongestPalindrome(string s)
        {
            string palindrome = "";
            for (int i = 0; i <= s.Length; i++) //length of palidrome
            {
                for (int j = 0; j < s.Length - i +1; j++)
                {
                    int start = j;
                    int end = i;
                    //take groups of i caracters and validate if is palindrome 
                    string test = s.Substring(start, end);
                    bool isPalin = IsPalindrome(test);
                    if (isPalin == true)
                    {
                        palindrome = test;
                        break;
                    }
                }
            }
            return palindrome;
        }
    }
    /*
    palindrom is a word that is the same reading from left to rigth or from the rigth to left

    xxxanaxxxxx 
    xxxxdrttrdxxxxxx
    xggggggg

    palindrome=s[0];
    if s[1]==s[0] palindrome=s[1]
    if s[3]

    find 1 palindrome of len 1
    find 1 palindrome of len 2
    find i palindrome of len 3 ...
    */
}
