using System;

namespace printEven
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a program that prints all the even numbers between 0 and 500
            int n = 0;
            for (int i=0;i<=500;i++)
            {
                
                if (n % 2 == 0)
                {
                    Console.WriteLine(n);
                }
                n+=1;
            }
        }
    }
}
