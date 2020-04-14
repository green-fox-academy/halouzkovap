using System;
using System.Collections.Generic;

namespace product_database
{
    class Program
    {
        static void Main(string[] args)
        {
            //We are going to represent our products in a map where the keys are strings representing the product's 
            //name and the values are numbers representing the product's price.

            //Create a map with the following key - value pairs.
            Dictionary<string, int> product = new Dictionary<string, int>();
            //  Product name(key)  Price(value)
            product.Add("Eggs", 200);
            product.Add("Milk", 200);
            product.Add("Fish", 400);
            product.Add("Apples", 150);
            product.Add("Bread", 50);
            product.Add("Chicken", 550);
            //Create an application which solves the following problems.

            Console.WriteLine("How much is the fish ?");
            HowMuch(product, "Milk");
            Console.WriteLine();

            Console.WriteLine("What is the most expensive product?");
            MostExpensive(product);
            Console.WriteLine();

            Console.WriteLine("What is the average price?");
            AveradgePrice(product);
            Console.WriteLine();

            Console.WriteLine("How many products' price is below 300?");
            priceBelow(product, 300);

            Console.WriteLine();

            Console.WriteLine("Is there anything we can buy for exactly 125 ?");
            equalPrice(product, 125);
            Console.WriteLine("What is the cheapest product ?");
            mostCheap(product);
            Console.WriteLine();
            Console.WriteLine("Which products cost less than 201 ? ");
            priceBelow(product, 201);
            Console.WriteLine();
            Console.WriteLine("Which products cost more than 150 ? (name + price)");
            priceUnder(product, 150);

        }

        static void HowMuch(Dictionary<string, int> dic, string a)
        {
            try
            {
                Console.WriteLine("We pay {0} for {1}", dic[a], a);

            }
            catch (KeyNotFoundException)
            {
                Console.WriteLine("Porduct " + a + " isnt in our storage");
            }
        }

        static void MostExpensive(Dictionary<string, int> dic)
        {
            Dictionary<string, int>.ValueCollection valueColl = dic.Values;
            List<int> price = new List<int>();

            foreach (int s in valueColl)
            {
                price.Add(s);
            }

            price.Sort();
            int last = price[price.Count - 1];

            foreach (KeyValuePair<string, int> pair in dic)
            {
                if (pair.Value == last)
                {
                    Console.WriteLine("{0} is most expensive", pair.Key);
                }
            }

        }

        static void AveradgePrice(Dictionary<string, int> dic)
        {
            Dictionary<string, int>.ValueCollection valueColl = dic.Values;

            int sum = 0;
            foreach (int s in valueColl)
            {
                sum += s;
            }
            double averadge = (double)sum / (double)dic.Count;
            Console.WriteLine("averadge price of our pruducts is {0}", averadge);
        }

        static void priceBelow(Dictionary<string, int> dic, int b)
        {
            Dictionary<string, int> cheap = new Dictionary<string, int>();

            foreach (KeyValuePair<string, int> item in dic)
            {
                if (item.Value < b)
                {
                    cheap.Add(item.Key, item.Value);
                }

            }

            foreach (KeyValuePair<string, int> item in cheap)
            {
                Console.WriteLine(item);
            }

            return;
            /*
            Dictionary<string, int>.ValueCollection valueColl = dic.Values;
            List<int> price = new List<int>();
            Dictionary<string, int> uniqueDic = new Dictionary<string, int>();




            foreach (int s in valueColl)
            {
                if (s < b)
                {
                    price.Add(s);
                }

            }
            foreach (var j in price)
            {
                Console.WriteLine(j);
            }

            foreach (KeyValuePair<string, int> pair in dic)
            {
                foreach (var item in price)
                {
                    if (pair.Value == item)
                    {
                        if (!uniqueDic.ContainsKey(pair.Key))
                        {
                            uniqueDic.Add(pair.Key, item);

                            Console.WriteLine(" price of {0} is undre {1}", pair.Key, b);

                        }

                    }
                }

            }
            */

        }
        static void equalPrice(Dictionary<string, int> dic, int b)
        {
            Dictionary<string, int> equal = new Dictionary<string, int>();

            foreach (KeyValuePair<string, int> item in dic)
            {
                if (item.Value == b)
                {
                    equal.Add(item.Key, item.Value);
                }

            }

            foreach (KeyValuePair<string, int> item in equal)
            {
                Console.WriteLine(item);
            }

        }
        static void mostCheap(Dictionary<string, int> dic)
        {
            Dictionary<string, int>.ValueCollection valueColl = dic.Values;
            List<int> price = new List<int>();

            foreach (int s in valueColl)
            {
                price.Add(s);
            }

            price.Sort();
            int last = price[0];

            foreach (KeyValuePair<string, int> pair in dic)
            {
                if (pair.Value == last)
                {
                    Console.WriteLine("{0} is cheapest", pair.Key);
                }
            }

        }
        static void priceUnder(Dictionary<string, int> dic, int b)
        {
            Dictionary<string, int> cheap = new Dictionary<string, int>();

            foreach (KeyValuePair<string, int> item in dic)
            {
                if (item.Value > b)
                {
                    cheap.Add(item.Key, item.Value);
                }

            }

            foreach (KeyValuePair<string, int> item in cheap)
            {
                Console.WriteLine(item);
            }

            return;
        }
    }
}
