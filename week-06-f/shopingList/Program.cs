using System;
using System.Collections.Generic;

namespace shopingList
{
    class Program
    {
        static void Main(string[] args)
        {
            // We are going to represent a shopping list in a list containing strings.

            //Create a list with the following items.
            //Eggs, milk, fish, apples, bread and chicken
            List<string> shopingList = new List<string> { "Eggs", "milk", "fish", "apples", "bread", "chicken" };

            IsItOnTheList(shopingList, "orange");

            void IsItOnTheList(List<string> alist, string a)
            {
                if (!alist.Contains(a))
                {
                    Console.WriteLine(a + " isnt on the list");
                }
                else
                {
                    Console.WriteLine(a + " is on the list");
                }
            }
            //Create an application which solves the following problems.
            //Do we have milk on the list?
            //Do we have bananas on the list?
        }
    }
}
