using System;

namespace oddEvens
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number from the standard input,
            // Then prints "Odd" if the number is odd, or "Even" if it is even.
            Console.WriteLine("write number and i will tell you if it is odd or even");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("your number is even");
            }
            else
            {
                Console.WriteLine("your number is odd");
            }
        }
    }
}
