using System;
using System.IO;

namespace WriteMultipleLines
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a function that takes 3 parameters: a path, a word and a number
            // and is able to write into a file.
            // The path parameter should be a string that describes the location of the file you wish to modify
            string name = @"C:\Users\42073\greenfox\halouzkovap\week-8-s\WriteMultipleLines\file.txt";
            // The word parameter should also be a string that will be written to the file as individual lines
            string word = "lets go coding";
            // The number parameter should describe how many lines the file should have.
            // If the word is 'apple' and the number is 5, it should write 5 lines
            int num = word.Length;
            // into the file and each line should read 'apple'
            // The function should not raise any errors if it could not write the file.
            Console.WriteLine(LineWriter(name, word, num));
            Console.ReadLine();
        }
        static string LineWriter(string name, string word, int num)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(name))
                {
                    for (int i = 0; i < num; i++)
                    {
                        sw.WriteLine(word);
                    }

                    sw.Close();
                    return "ok";
                }

            }
            catch (Exception e)
            {

                return "Invalide file";
            }
        }



    }
}
