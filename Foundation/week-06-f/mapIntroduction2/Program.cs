using System;
using System.Collections.Generic;

namespace mapIntroduction2
{
    class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            Dictionary<string, string> books = new Dictionary<string, string>();
            books.Add("978-1-60309-452-8", "A Letter to Jo");
            books.Add("978-1-60309-459-7", "Lupus");
            books.Add("978-1-60309-444-3", "Red Panda and Moon Bear");
            books.Add("978-1-60309-461-0", "The Lab");

            //Print all the key-value pairs in the following format
            //A Letter to Jo (ISBN: 978-1-60309-452-8)
            foreach (KeyValuePair<string, string> book in books)
            {
                Console.WriteLine("{0} (ISBN: {1})", book.Value, book.Key);
            }
            Console.WriteLine();
            //Remove the key - value pair with key 978 - 1 - 60309 - 444 - 3
            books.Remove("978 - 1 - 60309 - 444 - 3");

            if (!books.ContainsKey("978 - 1 - 60309 - 444 - 3"))
            {
                Console.WriteLine("Key \"978 - 1 - 60309 - 444 - 3\" is not found.");
            }

            Console.WriteLine();

            //Remove the key - value pair with value The Lab

            //Add the following key - value pairs to the map

            //Key Value
            books.Add("978 - 1 - 60309 - 450 - 4", "They Called Us Enemy");
            books.Add("978 - 1 - 60309 - 453 - 5", "Why Did We Trust Him?");
            Console.WriteLine();
            //Print whether there is an associated value with key 478 - 0 - 61159 - 424 - 8 or not
            if (!books.ContainsKey("478 - 0 - 61159 - 424 - 8"))
            {
                Console.WriteLine("key 478 - 0 - 61159 - 424 - 8 isnt in list");
            }
            else
            {
                Console.WriteLine("key 478 - 0 - 61159 - 424 - 8 is in the list");
            }
            Console.WriteLine();
            // Print the value associated with key 978 - 1 - 60309 - 453 - 5
            Console.WriteLine("{0}", books["978 - 1 - 60309 - 453 - 5"]);
        }
    }
}
