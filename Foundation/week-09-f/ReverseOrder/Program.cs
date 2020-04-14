using System;
using System.IO;
using System.Linq;

namespace ReverseOrder
{
    class Program
    {
        public static void ReverseLine(string path)
        {
            var reverseLine = File.ReadAllLines(path).Reverse();
            foreach (var item in reverseLine)
            {
                Console.WriteLine(item);
            }
            //StreamReader sr = new StreamReader(path);

            //string line;

            //StringBuilder newOrder = new StringBuilder();

            //while ((line = sr.ReadLine()) != null)
            //{
            //    newOrder.Insert(0, line);
            //}
            //Console.WriteLine(newOrder);
        }

        static void Main(string[] args)
        {
            string path = @"C:\Users\halouzkova\source\repos\ReverseOrder\ReverseOrders.txt";
            ReverseLine(path);

            Console.ReadLine();
        }
    }
}
