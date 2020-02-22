using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string>() { "fuck", "bloody", "cock", "shit", "fucker", "fuckstick", "asshole", "dick", "piss", "cunt" };
            // int result = CountWordInFile(words);
            // Console.WriteLine(result);
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\halouzkova\source\repos\text.txt");
            int sum = 0;
            int sum2 = 0;

            //var groups = lines.Count(v => v.Contains(words));
            var readFile = System.IO.File.ReadAllText(@"C:\Users\halouzkova\source\repos\text.txt");
            var str = readFile.Split(new char[] { ' ', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            System.Console.WriteLine("Number of words: " + str.Length);
            foreach (var item in str)
            {
                foreach (var word in words)
                {
                    if (item.Contains(word))
                    {
                        sum2++;
                    }
                }
            }
            Console.WriteLine("new method");
            Console.WriteLine(sum2);

            //toto je špatně
            Console.WriteLine("Content of the file line by line:");
            foreach (string line in lines)
            {
                foreach (var item in words)
                {
                    if (line.ToString().Contains(item))
                    {
                        sum++;
                    }
                }
            }


            Console.WriteLine(sum);
        }

        public void CountWordInFile(List<String> list)
        {



        }
    }
}
