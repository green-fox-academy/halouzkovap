using System;

namespace swapElements
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `abc`
            //   with the following content: `[]`
            string[] abc = new string[] { "first", "second", "third" };
            // - Swap the first and the third element of `abc`
            string temp = "";
            temp = abc[0];
            abc[0] = abc[2];
            abc[2] = temp;
            Console.WriteLine(abc[2]);
            Console.ReadLine();
        }

    }
}
