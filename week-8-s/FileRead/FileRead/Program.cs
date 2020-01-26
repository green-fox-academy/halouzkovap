using System;
using System.IO;

namespace FileRead
{
    class Program
    {
        static void StreamReader()
        {
            StreamReader sr = new StreamReader("Value.txt");//new object read every line
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
        static void Main(string[] args)
        {
            string[] lines = { "This is line 2", "This is line 3", "this is line 4" };
            using (StreamWriter writer = new StreamWriter(@"C:\Users\42073\source\repos\WriteMultipleLines\my.file.txt"))
            {
                foreach (var line in lines)
                {
                    writer.WriteLine(line);
                }
            }
            Console.ReadLine();
        }
    }
}
