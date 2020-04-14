using System;
using System.IO;

namespace WriteSingleLine
{
    class Program
    {
        static void Main(string[] args)
        {
            //WriteIntoFile("secondExercise.txt", "new word", 5);
            string path = "secondExercise.txt";
            Console.WriteLine(CopyFile(path));
        }
        static bool CopyFile(string path)
        {
            // Write a function that reads all lines of a file and writes the read lines to an other file (a.k.a copies the file)
            // It should take the filenames as parameters
            // It should return a boolean that shows if the copy was successful
            try
            {
                var lines = File.ReadAllLines(path);
                File.WriteAllLines("copyFile.txt", lines);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        static void WriteIntoFile(string path, string word, int a)
        {

            // The path parameter should be a string that describes the location of the file you wish to modify
            // The word parameter should also be a string that will be written to the file as individual lines
            // The number parameter should describe how many lines the file should have.
            // If the word is 'apple' and the number is 5, it should write 5 lines
            // into the file and each line should read 'apple'
            // The function should not raise any errors if it could not write the file.
            string[] newWord = new string[a];
            for (int i = 0; i < a; i++)
            {
                newWord[i] = word;
            }

            try
            {
                File.WriteAllLines(path, newWord);
            }
            catch (Exception)
            {

                Console.WriteLine("Unable to write file: my-file.txt");
            }
        }
        static void WriteToFile()
        {
            // Write a function that is able to manipulate a file
            // By writing your name into it as a single line
            // The file should be named "my-file.txt"
            // In case the program is unable to write the file,
            // It should print the following error message: "Unable to write file: my-file.txt"
            try
            {
                File.WriteAllText("my-File.txt", "Petra");
            }
            catch (Exception)
            {

                Console.WriteLine("Unable to write file: my-file.txt");
            }
        }
    }
}
