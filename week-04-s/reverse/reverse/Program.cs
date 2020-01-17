using System;

namespace reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `aj`
            //   with the following content: `[3, 4, 5, 6, 7]`
            int[] aj =new int[] { 3, 4, 5, 6, 7 };
            // - Reverse the order of the elements in `aj`
            Array.Reverse(aj);

            foreach (int item in aj)
            {
                Console.Write(item);
            }
            Console.WriteLine();
            // - Print the elements of the reversed `aj`
            Console.ReadLine();
        }
    }
}
