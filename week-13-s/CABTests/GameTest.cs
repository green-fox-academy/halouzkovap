using CAB;
using System.Collections.Generic;
using Xunit;

namespace CABTests
{
    public class GameTest
    {
        //Game game = new Game();
        //CABNumber cabNumber = new CABNumber();
        //UserGues userGues = new UserGues();
        //private List<int> CABNum = new List<int>() { 1, 2, 3, 4 };
        //public List<int> ListOfUserGuess = new List<int>() { 1, 2, 3, 4 };


        [Fact]
        public void Play()
        {
            Game game = new Game();
            game.cab = new List<int>() { 1, 2, 3, 4 };
            game.userGuesses = new List<int>() { 1, 2, 3, 4 };
            game.Play();
            var result = game.Bull;
            Assert.Equal(4, result);
        }

    }
}
