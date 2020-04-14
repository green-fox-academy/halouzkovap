using System;

namespace factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 5;
            int n;
            while (num > 0)
            {
                n = 1;
                for (int i = num; i > 0; i--)
                {
                    n *= i;
                }
                Console.WriteLine("Factorial of {0}! = {1}\n", num, n);
                num--;
            }
        }
    }
}
