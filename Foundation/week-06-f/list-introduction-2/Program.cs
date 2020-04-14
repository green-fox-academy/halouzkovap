using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list_introduction_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Create a list('List A') which contains the following values
            //  Apple, Avocado, Blueberries, Durian, Lychee
            List<string> listA = new List<string>();
            listA.Add("Apple");
            listA.Add("Avocado");
            listA.Add("Blueberries");
            listA.Add("Durian");
            listA.Add("Lychee");

            //  Create a new list('List B') with the values of List A
            List<string> listB = new List<string>();
            foreach (var fruit in listA)
            {
                listB.Add(fruit);
            }

           
            foreach (var item in listB)
            {
                Console.WriteLine(item);

            }

            Console.WriteLine();
            //  Print out whether List A contains Durian or not
            if (listA.Contains("Durian"))
            {
                Console.WriteLine("yes");
            }
            //  Remove Durian from List B
            listB.Remove("Durian");
           
            
            //  Add  to List A after the 4th element
            listA.Insert(4,"Kiwifruit");
            Console.WriteLine();

            //  Compare the size of List A and List B
            Console.WriteLine("list A has {0}, list B has {1} elements", listA.Count,listB.Count);
            Console.WriteLine();

            //  Get the index of Avocado from List A
            Console.WriteLine("Avocado in list A has index {0} ", listA.IndexOf("Avocado"));
            Console.WriteLine();

            //  Get the index of Durian from List B
            Console.WriteLine("Durian in list B has index {0} ", listB.IndexOf("Durian"));
            Console.WriteLine();

            //  Add Passion Fruit and Pomelo to List B in a single statement
            listB.Add("Passion Fruit");
            listB.Add("Pomelo");

            //  Print out the 3rd element from List A
            Console.WriteLine(listA[3]);
        }
    }
}
