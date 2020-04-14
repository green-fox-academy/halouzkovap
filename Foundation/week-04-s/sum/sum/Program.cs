using System;

namespace sum
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a function called `sum` that returns the sum of numbers from zero to the given parameter
            int[] a = new int[] { 1, 2, 3, 4, 5, 6 };
            int sum = Sum(a);
            Console.WriteLine(sum);
        }
        static int Sum(int[] a)
        {
            int sum = 0;

            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i];
            }
            return sum;
        }
    }
}
