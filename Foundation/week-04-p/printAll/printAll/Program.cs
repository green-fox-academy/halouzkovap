using System;

namespace printAll
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `numbers`
            //   with the following content: `[4, 5, 6, 7]`
            int[] numbers = new int[] { 4, 5, 6, 7 };
            // - Print all the elements of `numbers`
            foreach (int i in numbers)
            {
                Console.Write("{0} " , i);
            }
            Console.ReadLine();
        }
    }
}
