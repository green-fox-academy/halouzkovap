using System;

namespace Bunnies
{
    class Program
    {
        static void Main(string[] args)
        {
            //We have a number of bunnies and each bunny has two big floppy ears. We want to 
            //    compute the 
            //    total number of ears across all the bunnies recursively
            //    (without loops or multiplication).
            int numOfBunny = 4;
            Console.WriteLine(Bunny(numOfBunny));
            Console.WriteLine(BunnyInLine(numOfBunny));
            Console.ReadLine();

            //We have bunnies standing in a line, numbered 1, 2, ...
            //The odd bunnies(1, 3, ..) have the normal 2 ears.The even bunnies(2, 4, ..)
            //    we'll say have 3 ears, because they each have a raised foot. Recursively 
            //    return the number of "ears" in the bunny line 1, 2, ... n 
            //    (without loops or multiplication).
        }
        public static int BunnyInLine(int num)
        {
            if (num == 1)
            {
                return 2;
            }
            if (num % 2 == 0)
            {
                return 3 + BunnyInLine(num - 1);
            }
            return 2 + BunnyInLine(num - 1);
        }
        public static int Bunny(int bunny)
        {

            if (bunny == 1)
            {
                return 2;
            }
            return 2 + Bunny(bunny - 1);

        }
    }
}
