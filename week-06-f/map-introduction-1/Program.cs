using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace map_introduction_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> introduction = new Dictionary<int, string>();
            
            introduction.Add(97, "a");
            introduction.Add(98, "b");
            introduction.Add(99, "c");
            introduction.Add(65, "A");
            introduction.Add(66, "B");
            introduction.Add(67, "C");
            

            if (introduction.Count>0)
            {
                Console.WriteLine("There are key-value pairs " + introduction.Count);
            }
            else
            {
                Console.WriteLine("dictionary is empty");
            }

            foreach (KeyValuePair<int, string> kvp in introduction)
            {
                Console.WriteLine("Key = {0}, Value = {1}",
                    kvp.Key, kvp.Value);
            }


            Dictionary<int, string>.ValueCollection value = introduction.Values;
            Console.WriteLine();
            foreach (string s in value)
            {
                Console.WriteLine("value is {0}", s);
            }

            Dictionary<int, string>.KeyCollection key = introduction.Keys;
            Console.WriteLine();
            foreach (int i in key)
            {
                Console.WriteLine("key is {0}", i);
            }

            introduction.Add(68, "D");

            Console.WriteLine("value of key 99 is {0}", introduction[99] );

            //Remove the key - value pair where with key 97
            introduction.Remove(97);

            //Print whether there is an associated value with key 100 or not
            if (!key.Contains(100))
            {
                Console.WriteLine("there is no this key");
            }
            else
            {
                Console.WriteLine("there is this key");
            }

            //Remove all the key-value pairs

        }
    }
}
