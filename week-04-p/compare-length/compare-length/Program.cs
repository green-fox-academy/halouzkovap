using System;

namespace compare_length
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `p1`
            //   with the following content: `[1, 2, 3]`
            int[] p1 = new int[] { 1, 2, 3 };

            // - Create an array variable named `p2`
            //   with the following content: `[4, 5]`
            int[] p2 = new int[] { 4, 5 };
            // - Print "p2 is longer" if `p2` has more elements than `p1`
            int a = p1.Length;
            int b = p2.Length;

        if(a>b)
            {
                Console.WriteLine("p1 is longer");
            }
        else
            {
                Console.WriteLine("p2 is longer");
            }
        }
    }
}
