using System;

namespace drawDiamond
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number from the standard input, then draws a
            // diamond like this:
            //
            //
            //    *
            //   ***
            //  *****
            // *******
            //  *****
            //   ***
            //    *
            //
            // The diamond should have as many lines as the number was
            int k, j, n, i, m,p;
            Console.WriteLine("Write num of lines:");

            n = Convert.ToInt32(Console.ReadLine());

            if (n % 2 != 0) {
                m = (n / 2) + 1;
                p = n / 2;

                for (i = 0; i <= m; i++)
                {
                    for (j = 1; j <= m - i; j++)
                        Console.Write(" ");


                    for (k = 1; k <= i; k++)
                        Console.Write("* ");
                    Console.WriteLine();
                }
                for (i = 1; i <= p; i++)
                {
                    for (j = 1; j <= i; j++)
                        Console.Write(" ");


                    for (k = p; k >= i; k--)
                        Console.Write("* ");
                    Console.WriteLine();
                }
            }
            else
            {
                m = (n / 2);
                

                for (i = 0; i <= m; i++)
                {
                    for (j = 1; j <= m - i; j++)
                        Console.Write(" ");


                    for (k = 1; k <= i; k++)
                        Console.Write("* ");
                    Console.WriteLine();
                }
                for (i = 1; i <= m; i++)
                {
                    for (j = 1; j <= i; j++)
                        Console.Write(" ");


                    for (k = m; k >= i; k--)
                        Console.Write("* ");
                    Console.WriteLine();
                }

            }

        }
    }
}
