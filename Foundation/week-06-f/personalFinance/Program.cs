using System;
using System.Collections.Generic;

namespace personalFinance
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> finance = new List<int> { 500, 1000, 1250, 175, 800, 120 };
            finance.Sort();
            foreach (var item in finance)
            {
                Console.Write(item + " , ");
            }
            Console.WriteLine();

            // How much did we spend?
            int sum = 0;
            foreach (var item in finance)
            {
                sum += item;
            }
            Console.WriteLine(sum);
            //Which was our greatest expense?
            Console.WriteLine(finance[finance.Count - 1]);

            //Which was our cheapest spending?
            Console.WriteLine(finance[0]);

            //What was the average amount of our spendings ?
            double avarage = (double)sum / (double)finance.Count;
            Console.WriteLine(avarage);
        }
    }
}
