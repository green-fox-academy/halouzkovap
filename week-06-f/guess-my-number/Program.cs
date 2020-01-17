using System;



namespace guess_my_number
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program where the program chooses a number between 1 and 100.
            int y = randomNum(1, 100);
            Console.WriteLine(y);
            //The player is then asked to enter a guess. If the player guesses wrong,
            //then the program gives feedback and ask to enter an other guess until the guess is correct.
            Console.WriteLine("guess the number between 1 and 100. You have Five lives");

            for (int i = 0; i < 5; i++)
            {
                int tip = Convert.ToInt32(Console.ReadLine());
                if (tip > y)
                {

                    Console.WriteLine("Too high. You have {0} lives left.", 4 - i);
                }

                else if (tip < y)

                {
                    Console.WriteLine("Too low. you have {0} lives left.", 4 - i);
                }

                else if (tip == y)
                {
                    Console.WriteLine("Congratulations.You won!");
                    break;
                }

            }



            //Make the range customizable(ask for it before starting the guessing).
            //You can add lives. (optional)
        }
        static int randomNum(int min, int max)
        {
            var rand = new Random();
            int x = rand.Next(1, 100);
            return x;
        }

    }
}
