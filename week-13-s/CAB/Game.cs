using System.Collections.Generic;

namespace CAB
{
    public class Game
    {

        public UserGues userGues;
        public CABNumber cabNumber;
        public List<int> cab;
        private List<int> userGuesses;
        private int Bull;
        private int Cow;
        public Game()
        {
            Bull = 0;
            Cow = 0;
        }
        public void Start()
        {
            var cabNumber = new CABNumber();
            var userGues = new UserGues();

            cab = cabNumber.GetCABNumber();

            userGues.Intro();
            userGuesses = userGues.GetUserGuess();

            Play();
            System.Console.WriteLine(ToString());

            System.Console.WriteLine("cab numbers were :");
            foreach (var item in cab)
            {
                System.Console.Write(item + ",");
            }
            System.Console.WriteLine();
        }

        private void Play()
        {

            for (int i = 0; i < cab.Count; i++)
            {
                if (cab[i] == userGuesses[i])
                {

                    Bull++;
                }
                else if (cab.Contains(userGuesses[i]) && cab[i] != userGuesses[i])
                {
                    Cow++;
                }

            }
        }
        public override string ToString()
        {
            return $"you have Bulls:{Bull} and Cows:{Cow}.";
        }

    }
}
