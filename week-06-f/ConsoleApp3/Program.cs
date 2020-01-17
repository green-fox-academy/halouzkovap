using System;
using System.Linq;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            // palindrom
            string input = "dog goat dad duck doodle never";

           
            Console.WriteLine(NewPalindromArray(input));
        }
        
        public static string NewPalindromArray(string word)
        {
            //origin array
            char[] charInpu = word.ToCharArray(); // origin word to char array

            // reverse array
            char[] reverseArray = word.ToCharArray();
            reverseArray = reverseArray.Reverse().ToArray();

            // return new array
            char[] newArray = new char[] { };

            int min = 3;
            int max = word.Length - 1;







            string backToStringOrigin = string.Join("", charInpu);
            string backToStringReverse = string.Join("", reverseArray);
            string palindrom = backToStringOrigin + backToStringReverse;
            return palindrom;
        }
        
    }
}
