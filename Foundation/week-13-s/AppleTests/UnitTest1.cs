using Apples;
using System.Collections.Generic;
using Xunit;


namespace AppleTests
{
    public class UnitTest1
    {
        [Fact]
        public void GetApple()
        {
            var appl = new Apple();
            var output = appl.GetApple();
            Assert.Equal("apple", output);
        }

        [Fact]
        public void Add()
        {
            var sum = new Sum();
            var outpu = sum.Add(3, 4);
            Assert.Equal(7, outpu);
        }
        [Theory]
        [InlineData(1, 1, 2)]
        [InlineData(null, 1, 1)]
        [InlineData(null, null, null)]
        public void Adding(int a, int b, int result)
        {
            var sum = new Sum();
            var outpu = sum.Add(a, b);
            Assert.Equal(result, outpu);
        }

        [Fact]
        public void GetAnagram()
        {
            var anagram = new Anagrams();
            var result = anagram.GetAnagram("word", "drow");
            Assert.True(result);
        }

        [Fact]
        public void CountLetters()
        {
            var countLetter = new CountLetters();
            var result = countLetter.GetDictionary("jj");
            Dictionary<char, int> dict2 = new Dictionary<char, int> { { 'j', 2 } };

            Assert.Equal(result, dict2);
        }

        [Fact]
        public void Fibonnaci()
        {
            var fib = new Fibonnaci();
            var result = fib.fibo(1);
            List<int> newList = new List<int>() { 0 };
            Assert.Equal(newList, result);
        }

    }
}
