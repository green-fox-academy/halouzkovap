using System;
using System.IO;

namespace CountLines
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a function that takes a filename as string,
            // then returns the number of lines the file contains.
            // It should return zero if it can't open the file, and
            // should not raise any error.
            Console.WriteLine(NumOfLines("Value.txt"));
            Console.ReadLine();
        }
        static int NumOfLines(string fileName)
        {
            int numOfLine = 0;
            try
            {
                using (StreamReader sr = new StreamReader(fileName))
                {
                    string line = "";
                    while (line != null)
                    {
                        numOfLine++;
                        line = sr.ReadLine();

                    }

                    return numOfLine;
                }
            }
            catch (Exception e)
            {

                return 0;
            }
        }
    }
}
