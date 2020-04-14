using System;

namespace drawPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number from the standard input, then draws a
            // pyramid like this:
            //
            //
            //    *
            //   ***
            //  *****
            // *******
            //
            // The pyramid should have as many lines as the number was
            Console.WriteLine("tell me number");
            int num = Convert.ToInt32(Console.ReadLine());

           

            
            for (int i = 1; i <= num; i++)
            {
                //loop to print spaces
                for (int j = 1; j <= (num - i); j++)
                    Console.Write(" ");

                //loop to print stars
                for (int t = 1; t < i * 2; t++)
                    Console.Write("*");
                Console.WriteLine();
            }
            

        }
    }
}
