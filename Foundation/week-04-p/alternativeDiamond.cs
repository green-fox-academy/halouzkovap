using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 5;
            int M = N / 2;

            for (int i = 0; i < N; i++)
            {
                int DV = Math.Abs(M - i);

                for (int j = 0; j < N; j++)
                {
                    int DH = Math.Abs(M - j);
                    if (DH +DV <= M)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

        }
    }
}
