using Extension;
using System.Collections.Generic;
using Xunit;

namespace ExtensTests
{
    public class ExtensTests
    {

        Extens extension = new Extens();

        [Fact]
        public void TestAdd_2and3is5()
        {
            Assert.Equal(5, extension.Add(2, 3));
        }

        [Fact]
        public void TestAdd_1and4is5()
        {
            Assert.Equal(6, extension.Add(1, 5));
        }

        [Fact]
        public void TestMaxOfThree_First()
        {
            Assert.Equal(5, extension.MaxOfThree(5, 5, 5));
        }

        [Fact]
        public void TestMaxOfThree_Fhird()
        {
            Assert.Equal(5, extension.MaxOfThree(3, 4, 5));
        }

        [Fact]
        public void TestMedian_Four()
        {
            Assert.Equal(6, extension.Median(new List<int>() { 7, 5, 3, 5, 7, 8 }));
        }

        [Fact]
        public void TestMedian_Five()
        {
            Assert.Equal(3, extension.Median(new List<int>() { 1, 2, 3, 4, 5, 9 }));
        }

        [Fact]
        public void TestIsVowel_a()
        {
            Assert.True(extension.IsVowel('a'));
        }

        [Fact]
        public void TestIsVowel_u()
        {
            Assert.False(extension.IsVowel('q'));
        }

        [Fact]
        public void testTranslate_bemutatkozik()
        {
            Assert.Equal("bevemuvutavatkovozivik", extension.Translate("bemutatkozik"));
        }

        [Fact]
        public void testTranslate_kolbice()
        {
            Assert.Equal("lavagovopuvus", extension.Translate("lagopus"));
        }

    }
}

