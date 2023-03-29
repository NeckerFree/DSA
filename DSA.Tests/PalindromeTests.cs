using DSA.Library.Strings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Tests
{
    public class PalindromeTests
    {
        [Fact]
        public void ValidateLongestPalindrome()
        {
            Palindrome palindrome = new Palindrome();

            string input = "bb";
            string actual = palindrome.LongestPalindrome(input);
            Assert.Equal("ggggggg", actual);
        }
    }
}
