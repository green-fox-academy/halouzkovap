using Anagrams;
using Xunit;

namespace AnagramTests
{
    public class UnitTest1
    {
        [Fact]
        public void GetAnagram()
        {
            var anagram = new Anagram();
            var result = anagram.GetAnagram("word", "drow");
            Assert.True(result);
        }
    }
}
