using System;

namespace printBigger
{
    class Program
    {
        static void Main(string[] args)
        {

            // Write a program that asks for two numbers and prints the bigger one
            Console.WriteLine("tell me 2 numbers and i will tell you which number is bigger");
            int[] num = new int[2];
            for ( int i =0; i < 2; i++) 
            {
                num[i] = Convert.ToInt32(Console.ReadLine());
            }

            int a = 0;
            a = num[0];
            int b = 0;
            b= num[1];

            if (a > b)
            {
                Console.WriteLine(a + " is bigger than " + b);
            }
            else
            {
                Console.WriteLine(b + " is bigger than " + a);
            }



        }
    }
}
