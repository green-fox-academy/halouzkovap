using System;
using System.Linq;
using System.Collections.Generic;


namespace angram
{
    class Program
    {
        static void Main(string[] args)
        {
            
                string a = "dog";
                string b = "god";

                Console.WriteLine(isAnagram(a, b));
        }
        public static string isAnagram(string a, string b)
        {
                char[] astring = a.ToLower().ToCharArray();
                char[] bstring = b.ToLower().ToCharArray();

                Array.Sort(astring);
                Array.Sort(bstring);

                string val1 = new string(astring);
                string val2 = new string(bstring);

                if (val1 == val2)
                {
                    return ("Both the strings are Anagrams");
                }
                else
                {
                    return ("Both the strings are not Anagrams");

                }
            }
        }
    } 