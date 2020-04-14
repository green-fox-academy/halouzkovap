using System;

namespace RecursMax
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a function that finds 
            //    the largest element of an array using recursion.
            int[] array1 = new int[] { 1, 3, 5, 9, 7 };
            int n = array1.Length;
            Console.WriteLine(Max(array1, n));
            Console.ReadLine();

        }

        static int Max(int[] array, int n)
        {
            if (n == 1)
            {
                return array[0];

            }

            return Math.Max(array[n - 1], Max(array, n - 1));

        }
    }
}
