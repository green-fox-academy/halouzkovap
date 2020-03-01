using CAB;
using System.Collections.Generic;
using Xunit;

namespace CABTests
{
    public class UserGuesTest
    {
        [Theory]
        [InlineData(1, 1)]
        [InlineData(0, -1)]
        [InlineData(0, 20)]

        public void checkArray(int predict, int adding)
        {
            var userGuess = new UserGues();
            userGuess.ListOfUserGuess = new List<int>();
            userGuess.AddNumbers(adding);
            var result = userGuess.ListOfUserGuess.Count;
            Assert.Equal(predict, result);
        }
    }
}
