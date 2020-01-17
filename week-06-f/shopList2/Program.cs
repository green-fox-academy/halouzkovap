using System;
using System.Collections.Generic;

namespace shopList2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> product = new Dictionary<string, double>();
            product.Add("Milk", 1.07);
            product.Add("Rice", 1.59);
            product.Add("Eggs", 3.14);
            product.Add("Cheese", 12.60);
            product.Add("ChickenBreasts", 9.40);
            product.Add("Apples", 2.31);
            product.Add("Tomato", 2.58);
            product.Add("Potato", 1.75);
            product.Add("Onion", 1.10);


            Dictionary<string, double> bobList = new Dictionary<string, double>();

            bobList.Add("Milk", 3);
            bobList.Add("Rice", 2);
            bobList.Add("Eggs", 2);
            bobList.Add("Cheese", 1);
            bobList.Add("ChickenBreasts", 4);
            bobList.Add("Apples", 1);
            bobList.Add("Tomato", 2);
            bobList.Add("Potato", 1);


            Dictionary<string, double> aliceList = new Dictionary<string, double>();

            aliceList.Add("Rice", 1);
            aliceList.Add("Eggs", 5);
            aliceList.Add("ChickenBrasts", 2);
            aliceList.Add("Apples", 1);
            aliceList.Add("Tomato", 1);

            //How much does Bob pay?
            Pay(product, bobList);
            //How much does Alice pay?
            Pay(product, aliceList);
            //Who buys more Rice?
            //Who buys more Potato?
            whoMore(aliceList, "Alice", bobList, "bob", "Potato");

            //Who buys more different products?
            //Who buys more products ? (piece)

        }
        static void whoMore(Dictionary<string, double> blist, string nameb, Dictionary<string, double> alist, string nameA, string key)
        {
            var bValueCheck = blist.TryGetValue(key, out double valueb);
            var aValueCheck = alist.TryGetValue(key, out double valuea);

            if (bValueCheck == false)
            {
                Console.WriteLine("on the list {0} is more {1}", nameA, key);
            }
            else if (aValueCheck == false)
            {
                Console.WriteLine("on the list {0} is more {1}", nameb, key);
            }

            var bvalue = blist[key];
            var avalue = alist[key];



            if (bvalue > avalue)
            {
                Console.WriteLine("on the list {0} is more {1}", nameb, key);
            }
            else
            {
                Console.WriteLine("on the list {0} is more {1}", nameA, key);

            }


        }
        static void Pay(Dictionary<string, double> alist, Dictionary<string, double> bob)
        {
            double sum = 0;
            double totalSum = 0;

            foreach (KeyValuePair<string, double> item in bob)
            {
                foreach (KeyValuePair<string, double> a in alist)
                {

                    if (item.Key == a.Key)
                    {
                        sum = (item.Value * a.Value);
                        totalSum += sum;
                        sum = 0;
                    }

                }
            }
            Console.WriteLine(totalSum);


        }
    }
}
