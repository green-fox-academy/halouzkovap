using System;

namespace Function
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { 5, 2, 3, 80 };
            Console.WriteLine(sumOfArray(a));

        }

        static int sumOfArray(int[] a)
        {
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i];
            }
            return sum;
        }
        static int generateNumber(int min, int max) // return random number
        {
            var rand = new Random();
            return min + (rand.Next() % (max - min));
        }
    }
}
