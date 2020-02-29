using System;
using System.Collections.Generic;

namespace Apples
{
    class Program
    {
        static void Main(string[] args)
        {
            //var appl = new Apple();
            //Console.WriteLine(appl.GetApple());

            var anagram = new Anagrams();
            Console.WriteLine(anagram.GetAnagram("ab", "ba"));

            var fibo = new Fibonnaci();
            List<int> fibolist = fibo.fibo(1);
            foreach (var item in fibolist)
            {
                Console.WriteLine(item);
            }


        }
    }
}
