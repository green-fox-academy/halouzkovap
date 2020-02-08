using System;

namespace SumDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sum Digits
            //Given a non - negative integer n, return the sum of its digits recursively(without loops).
            int num = 4;
            Console.WriteLine(RecursMetod(num));
            Console.ReadLine();

        }
        public static int RecursMetod(int num)
        {
            if (num == 1)
            {
                return 1;
            }
            else
            {
                return num * RecursMetod(num - 1);
            }
        }
    }
}
