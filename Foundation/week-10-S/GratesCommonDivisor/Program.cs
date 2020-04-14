using System;

namespace GratesCommonDivisor
{
    class Program
    {
        static void Main(string[] args)
        {
            //Find the greatest common divisor of two numbers using recursion.
            int numA = 20;
            int numB = 25;
            Console.WriteLine(DivisorResursion(numA, numB));
            Console.ReadLine();

        }
        public static int DivisorResursion(int a, int b)
        {
            if (b == 0)
            {
                return a;
            }
            else
            {
                return DivisorResursion(b, a % b);
            }
        }
    }
}
