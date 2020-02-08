using System;
using System.Collections.Generic;
using System.Linq;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //Given a string, compute recursively(no loops) a
            //    new string where all the lowercase 'x' 
            //    chars have been changed to 'y' chars.

            string word = "luxus";
            int lenght = word.Length;
            char finding = 'z';
            char replace = 'y';
            Console.WriteLine(ChangeLetter(word, lenght, finding, replace));

            //Given a string, compute recursively a new string where all the
            //    'x' chars have been removed.

            //Given a string, compute recursively a new string where all the 
            //    adjacent chars are now separated by a *


            Console.ReadLine();
        }
        public static string ChangeLetter(string word, int lenght, char finding, char replace)
        {



            List<char> newList = new List<char>();
            newList = word.ToList();


            if (lenght < word.Length)
            {
                if (newList[lenght] != finding)
                    ChangeLetter(word, lenght + 1, finding, replace);
            }
            newList[lenght] = replace;

            return newList.ToString();
        }
    }
}
