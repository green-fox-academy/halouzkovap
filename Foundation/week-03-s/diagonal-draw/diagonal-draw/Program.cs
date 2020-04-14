using System;

namespace diagonal_draw
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number from the standard input, then draws a
            // square like this:
            //
            //
            // %%%%%
            // %%  %
            // % % %
            // %  %%
            // %%%%%
            //
            // The square should have as many lines as the number was
            int i, n;
            Console.WriteLine("tell me number of lines:");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(new String('%', n));

            for (i = 1; i <= n - 2; i++)
            {
                Console.WriteLine("%" + new String(' ', n - 2) + "%");
            }
            Console.WriteLine(new String('%', n));
        }
    }
}
