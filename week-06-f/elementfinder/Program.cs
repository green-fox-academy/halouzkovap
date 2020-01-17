using System;
using System.Collections.Generic;

namespace elementfinder
{
    class Program
    {
        static void Main(string[] args)
        {
            var List = new List<int> { 1, 2, 3, 4, 5 };
            ContainsSeven(List, 7);
            ContainsSeven2(List, 7);
            // Write a method that checks if the arrayList contains "7" if it contains return "Hoorray" otherwise return "Noooooo"
            // The output should be: "Noooooo"
            // Do this again with a different solution using different list methods!
        }
        static void ContainsSeven(List<int> alist, int contains7)
        {
            if (alist.Contains(contains7))
            {
                Console.WriteLine("Hoorray");
            }
            else
            {
                Console.WriteLine("Noooooo");
            }
        }
        static void ContainsSeven2(List<int> alist, int contains7)
        {
            string result;
            var containsNum = alist.Contains(contains7);

            result = (containsNum) ? ("Hoorray") : ("Noooooo");
            Console.WriteLine(result);
        }

    }
}
