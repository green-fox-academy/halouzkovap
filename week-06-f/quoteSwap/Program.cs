using System;
using System.Collections.Generic;

namespace quoteSwap
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<string> { "What", "I", "do", "create,", "I", "cannot", "not", "understand." };

            // Accidentally I messed up this quote from Richard Feynman.
            // Two words are out of place
            // Your task is to fix it by swapping the right words with code
            // Create a method called QuoteSwap().

            // Also, print the sentence to the output with spaces in between.

            var reverseList = QuoteSwap(list, 2, 4);
            var newList = QuoteSwap(reverseList, 3, 2);
            foreach (var item in newList)
            {
                Console.Write(" " + item + " ");
            }
            Console.WriteLine();

            // Expected output: "What I cannot create I do not understand." 
        }
        static List<string> QuoteSwap(List<string> list, int indexA, int indexB)
        {
            list.Reverse(indexA, indexB);
            return list;

        }
    }
}
