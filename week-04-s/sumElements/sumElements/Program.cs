using System;

namespace sumElements
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `ai`
            int[] ai = new int[] { 3, 4, 5, 6, 7 };
            //   with the following content: `[3, 4, 5, 6, 7]`
            int sum = 0;
            foreach (var item in ai)
            {
                sum += item;
            }
            Console.WriteLine(sum);
            // - Print the sum of the elements in `ai`
            Console.ReadLine();
        }
    }
}
