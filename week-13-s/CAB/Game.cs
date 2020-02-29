using System;
using System.Collections.Generic;

namespace CAB
{
    public class Game
    {

        public UserGues userGues;
        public CABNumber cabNumber;
        public List<int> cab;
        public List<int> userGuesses;
        public int Bull;
        private int Cow;
        public Game()
        {
            Bull = 0;
            Cow = 0;
        }
        public void Start()
        {
            var cabNumber = new CABNumber();


            cab = cabNumber.GetCABNumber();
            Console.WriteLine("guess numbers");
            Console.WriteLine("Write 4 numbers to console these numbers cannot repeat you have to guess all numbers");

            while (Bull != 4)
            {
                Bull = 0;
                Cow = 0;
                RepeatingUntilSucces();

            }



            System.Console.WriteLine("cab numbers were :");
            foreach (var item in cab)
            {
                System.Console.Write(item + ",");
            }
            System.Console.WriteLine();
        }

        public void RepeatingUntilSucces()
        {
            var userGues = new UserGues();
            userGues.Intro();
            userGuesses = userGues.GetUserGuess();
            userGues.PrintGuessingNumber();
            Play();
            System.Console.WriteLine(ToString());
        }

        public void Play()
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
