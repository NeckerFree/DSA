using DSA.Library.Strings;

namespace DSA.Tests
{
    public class AlienLanguageTests
    {
        [Theory]
        //[InlineData(new string[] { "hello", "uber", "row" }, "huabcdefgijklmnopqrstvwyz", true)]
        [InlineData(new string[] {"word","world", "row"},"worldabcefghijkmnpqrstuvxyz",false)]
        //[InlineData(new string[] { "word", "wor", "row" }, "worldabcefghijkmnpqrstuvxyz", false)]
        public void ValidateIfInputIsSorted(string[] words, string order, bool valid)
        {
            AlienLanguage language = new AlienLanguage();
           bool response= language.IsAlienSorted(words, order); 

           // Assert.True(response);
           Assert.False(response);
            Assert.Equal(5, language.Operations);
        }
    }
}
