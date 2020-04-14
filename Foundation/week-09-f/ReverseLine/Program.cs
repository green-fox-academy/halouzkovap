using System;
using System.IO;

namespace ReverseLine
{
    class Program
    {
        public static void ReverseLine(string path)
        {
            StreamReader sr = new StreamReader(path);

            string line;


            while ((line = sr.ReadLine()) != null)
            {
                char[] myArr = line.ToCharArray();
                Array.Reverse(myArr);

                Console.WriteLine(myArr);
            }
        }
        static void Main(string[] args)
        {
            string path = @"C:\Users\halouzkova\source\repos\ReverseLine\reverse.txt";

            ReverseLine(path);

            Console.ReadLine();
        }
    }
}
