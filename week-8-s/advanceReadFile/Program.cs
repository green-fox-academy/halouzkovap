using System;
using System.IO;

namespace advanceReadFile
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo currDir = new DirectoryInfo(".");

            DirectoryInfo halDir = new DirectoryInfo(@"C:\Users\42073\greenfox\halouzkovap");
            Console.WriteLine(halDir.FullName);
            Console.WriteLine(halDir.Exists);
            Console.WriteLine(halDir.Name);
            Console.WriteLine(halDir.Parent);

            DirectoryInfo dataDir = new DirectoryInfo(@"C:\Users\42073\greenfox\halouzkovap");

            string[] customers =
            {
                "Bob",
                "jane",
            };

            string textFilePath = @"C:\Users\42073\greenfox\halouzkovap\customers.txt";

            File.WriteAllLines(textFilePath, customers);

            foreach (var cust in File.ReadAllLines(textFilePath))
            {
                Console.WriteLine(cust);
            }



            Console.ReadLine();
        }
    }
}
