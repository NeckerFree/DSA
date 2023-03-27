using DSA.Library.Strings;

namespace DSA.Tests
{
    public class FindStringTests
    {
        [Theory]

        [InlineData("abcdefghijklmnopqrsoe", "eo", "efghijklmno")]
        //[InlineData("ADOBECODEBANC", "ABC", "BANC")]
        //[InlineData("ABCBAC", "ABC", "ABC")]
        //[InlineData("A", "A", "A")]
        //[InlineData("ABC", "D", "")]
        //[InlineData("ABC", "", "")]
        //[InlineData("", "ABC", "")]
        //[InlineData("ABCD", "ABCD", "ABCD")]
        //[InlineData("AAABBB", "AB", "AB")]
        //[InlineData("ABCD", "BCD", "BCD")]
        //[InlineData("ABBACBAA", "AAB", "BAA")]
        //[InlineData("AABBCC", "AC", "ABBC")]
        //[InlineData("AAABBB", "A", "A")]
        //[InlineData("AAAAAAA", "AA", "AA")]
        //[InlineData("ABBBBAC", "BCA", "BAC")]
        //[InlineData("ABCD", "DCBA", "ABCD")]
        //[InlineData("ABCD", "BCDE", "")]
        //[InlineData("AABB", "ABB", "ABB")]
        //[InlineData("ADOBECODEBANC", "ADOBECODEBANC", "ADOBECODEBANC")]
        //[InlineData("ABCAABBCC", "ACB", "ABC")]
        //[InlineData("ABCD", "C", "C")]
        public void ValidateMinWindow(string s, string t, string expected)
        {
            FindString findString = new FindString();
            var result = findString.MinWindow(s, t);
            Assert.Equal(expected, result);
        }
    }
}
