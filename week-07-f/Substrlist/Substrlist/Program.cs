using System;

namespace Substrlist
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Create a function that takes a string and a list of string as a parameter
            //  Returns the index of the string in the list where the first string is part of
            //  Only need to find the first occurence and return the index of that
            //  Returns `-1` if the string is not part any of the strings in the list

            //  Example
            string[] searchArr = { "this", "is", "what", "I'm", "searching", "in" };

            Substrlist("ching", searchArr);
            //  should print: `4`
            Substrlist("not", searchArr);
            //  should print: `-1`  
        }
        static void Substrlist(string name, string[] array)
        {


            int index2 = -1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Contains(name))
                {
                    index2 = i;
                    break;
                }
            }


            Console.WriteLine(index2);
        }
    }
}
