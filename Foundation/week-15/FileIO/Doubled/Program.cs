using System;
using System.IO;
using System.Linq;

namespace Doubled
{
    class Program
    {
        static void Main(string[] args)
        {
            // Decrypt("Double.txt");
            //ReverseDecryptLine("reversed-lines.txt");
            ReverseOrder("ReverseOrder.txt");
        }
        static void ReverseOrder(string path)
        {
            // Create a method that decrypts reversed-order.txt
            try
            {
                var lines = File.ReadAllLines(path);
                var newLines = lines.Reverse();
                foreach (var item in newLines)
                {
                    Console.WriteLine(item);
                }

            }
            catch (Exception)
            {

                Console.WriteLine("dont find file");
            }
        }
        static void ReverseDecryptLine(string path)
        {
            // Create a method that decrypts reversed-lines.txt
            try
            {
                var lines = File.ReadAllLines(path);
                foreach (var line in lines)
                {
                    var charLine = line.ToCharArray();
                    var listLine = charLine.Select(ch => ch).ToList();
                    listLine.Reverse();
                    var myString = new string(listLine.ToArray());
                    Console.WriteLine(myString);

                }
            }
            catch (Exception)
            {

                Console.WriteLine("dont find file");
            }
        }
        static void Decrypt(string path)
        {
            // Create a method that decrypts the duplicated-chars.txt 

            try
            {
                var lines = File.ReadAllLines(path);
                foreach (var line in lines)
                {
                    var charLine = line.ToCharArray();
                    var listLine = charLine.Select(ch => ch).ToList();
                    for (int i = 0; i < listLine.Count; i++)
                    {
                        listLine.RemoveAt(i + 1);
                    }
                    var myString = new string(listLine.ToArray());
                    Console.WriteLine(myString);

                }
            }
            catch (Exception)
            {

                Console.WriteLine("dont find file");
            }
        }
    }
}
