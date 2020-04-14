using System;

namespace josephus_problem
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 12;
            int k = 2;
            int position = josephus(n, k);
            Console.WriteLine($"The survivor josephus({n},{k}) is {position}.");
        }

        static int josephus(int n, int k)
        {
            if (n == 1)
                return 1;
            else
                return (josephus(n - 1, k) + k - 1) % n + 1;

        }
    }
}

