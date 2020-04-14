using System;
using System.Text;

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
            string word2 = "luxus";


            Console.WriteLine(ChangeLetter(word));
            Console.WriteLine(RecursivelyChangeLetter(word));

            //Given a string, compute recursively a new string where all the
            //    'x' chars have been removed.
            Console.WriteLine(word2);
            Console.WriteLine(RecursivelyRemoveLetter(word2));

            //Given a string, compute recursively a new string where all the 
            //    adjacent chars are now separated by a *
            Console.WriteLine(RecursivelyAddStar(word2));

            Console.ReadLine();
        }
        public static string ChangeLetter(string word)
        {
            StringBuilder newWord = new StringBuilder();
            //int i;
            //if (i < word.Length)
            //{
            //    return 0;
            //}
            //ChangeLetter(word.Substring(i+1,1));

            for (int i = 0; i <= word.Length - 1; i++)
            {
                if (word.Substring(i, 1) == "x")
                {
                    newWord.Append("y");
                }
                else
                {
                    newWord.Append(word.Substring(i, 1));
                }

            }

            return newWord.ToString();

        }

        public static string RecursivelyChangeLetter(string word)
        {
            StringBuilder newWord = new StringBuilder();

            if (0 == word.Length)
            {
                return "";
            }
            else
            {
                if (word.Substring(0, 1) == "x")
                {
                    newWord.Append("y");
                }
                else
                {
                    newWord.Append(word.Substring(0, 1));
                }

                newWord.Append(RecursivelyChangeLetter((word.Substring(1))));
                return newWord.ToString();
            }
        }
        public static string RecursivelyRemoveLetter(string word)
        {
            StringBuilder newWord = new StringBuilder();

            if (0 == word.Length)
            {
                return "";
            }
            else
            {
                if (word.Substring(0, 1) == "x")
                {
                    newWord.Append("");
                }
                else
                {
                    newWord.Append(word.Substring(0, 1));
                }

                newWord.Append(RecursivelyRemoveLetter((word.Substring(1))));
                return newWord.ToString();
            }
        }

        public static string RecursivelyAddStar(string word)
        {
            StringBuilder newWord = new StringBuilder();

            if (0 == word.Length)
            {
                return "";
            }
            else
            {
                if (word.Substring(0, 1) != " ")
                {
                    newWord.Append(word.Substring(0, 1));
                    newWord.Append("*");
                }


                newWord.Append(RecursivelyAddStar((word.Substring(1))));
                return newWord.ToString();
            }
        }
    }
}
