using System;
using System.Collections.Generic;

namespace Dominoes
{
    class Program
    {

        public static void Main(string[] args)
        {

            var dominos = InitializeDominos();
            // You have the list of Dominos
            // Order them into one snake where the adjacent dominoes have the same numbers on their adjacent sides
            // Create a function to write the dominous to the console in the following format
            // eg: [2, 4], [4, 3], [3, 5] ...

            WriteDominos(dominos);
        }

        public static List<Domino> InitializeDominos()
        {
            var dominos = new List<Domino>();
            dominos.Add(new Domino(5, 2));
            dominos.Add(new Domino(4, 6));
            dominos.Add(new Domino(1, 5));
            dominos.Add(new Domino(6, 7));
            dominos.Add(new Domino(2, 4));
            dominos.Add(new Domino(7, 1));
            return dominos;
        }

        public static void WriteDomino(Domino domino)
        {
            int[] values = domino.GetValues();
            Console.WriteLine($"[{values[0]}, {values[1]}], ");
        }

        public static void WriteDominos(List<Domino> dominos)
        {
            WriteDomino(dominos[0]);

            int currentDomino = 0;
            int k = 0;
            int[] dominoValues = new int[2];
            int[] nextDominoValues = new int[2];

            for (int dominoNumber = 0; dominoNumber < dominos.Count - 2; dominoNumber++)
            {
                dominoValues = dominos[currentDomino].GetValues();
                nextDominoValues = dominos[currentDomino + 1].GetValues();

                while (dominoValues[1] != nextDominoValues[0])
                {
                    nextDominoValues = dominos[k].GetValues();
                    k++;
                }
                WriteDomino(dominos[k - 1]);
                currentDomino = k - 1;
                k = 0;
            }


        }
    }
}
