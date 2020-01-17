using System;
using System.Collections.Generic;
using System.Linq;

namespace palindrom
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "greenfox";


            Console.WriteLine(NewPalindrom(input));
        }

        public static string NewPalindrom(string word)
        {
            //origin array
            char[] charInpu = word.ToCharArray(); // origin word to char array

            // reverse array
            char[] reverseArray = word.ToCharArray();
            reverseArray = reverseArray.Reverse().ToArray();

            string backToStringOrigin = string.Join("", charInpu);
            string backToStringReverse = string.Join("", reverseArray);
            string palindrom = backToStringOrigin + backToStringReverse;
            return palindrom;
        }
    }
}
