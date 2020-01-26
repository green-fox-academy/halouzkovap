using System;
using System.IO;

namespace PrintEachLine
{
    class Program
    {
        static void Main(string[] args)
        {

            // Write a program that opens a file called "my-file.txt", then prints
            // each line from the file.
            // If the program is unable to read the file (for example it does not exist),
            // then it should print the following error message: "Unable to read file: my-file.txt"
            try
            {
                using (StreamReader sr = new StreamReader("Value.txt"))
                {
                    string line = "";// we put stream to line

                    while (line != null)
                    {
                        line = sr.ReadLine();
                        if (line != null)
                        {
                            Console.WriteLine(line);
                        }
                    }
                    sr.Close();
                }

            }
            catch (Exception e)
            {

                Console.WriteLine("Unable to read file: my-file.txt");
                // Console.WriteLine(e.Message);
            }
            finally
            {
                Console.ReadLine();
            }

        }
    }
}
