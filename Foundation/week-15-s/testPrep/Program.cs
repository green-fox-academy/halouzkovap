using System;
using System.IO;
using System.Linq;

namespace testPrep
{
    class Program
    {
        static void Main(string[] args)
        {
            //Please write a function that takes two parameters:
            //the first parameter is a string that represents the name of a file
            //the second parameter is a string that represents the name of a file
            string path = "TextFile1.txt";
            string NewPath = "TextFile2.txt";

            RewriteFunction(path, NewPath);
            //the function should read the file and count each of the words inside the file
            //the function should write all the words and its count(separated with spaces) as new lines in the file in descending order based on the count

        }

        public static void RewriteFunction(string path, string newPath)
        {
            try
            {
                var lines = File.ReadAllText(path);


                var result = lines.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .GroupBy(c => c)
                    .ToDictionary(k => k.Key, v => v.Count())
                    .OrderByDescending(c => c.Value);



                File.WriteAllLines(newPath,
                    result.Select(x => x.Key + " " + x.Value).ToArray());

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

        }

    }
}
