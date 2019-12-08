using System;

namespace one_two_a_lot
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number form the standard input,
            Console.WriteLine("tell me number");
            int num = Convert.ToInt32(Console.ReadLine());

            // If the number is zero or smaller it should print: Not enough
            if (num <= 0)
            {
                Console.WriteLine("not enought");
            }
            else if (num == 1)
            {
                Console.WriteLine(num);

            }
            else if (num == 2)
            {
                Console.WriteLine(num);
            }
            else
            {
                Console.WriteLine("a lot");
            }
            // If the number is one it should print: One
            // If the number is two it should print: Two
            // If the number is more than two it should print: A lot
        }
    }
}
