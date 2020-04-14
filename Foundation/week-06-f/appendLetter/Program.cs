using System;
using System.Collections.Generic;

namespace appendLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            var far = new List<string> { "bo", "anacond", "koal", "pand", "zebr" };
            // Create a method called AppendA() that adds "a" to every string in the far list.
            // The parameter should be a list.

            AppendA(far);
            // Expected output: "boa", "anaconda", "koala", "panda", "zebra"
        }

        static void AppendA(List<string> list)
        {

            foreach (var item in list)
            {
                Console.WriteLine(item + "a");
            }
        }
    }
}
