using System;

namespace count_from_to
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a program that asks for two numbers
            Console.WriteLine("tell me two numbers");
            int[] number = new int[2];
            for (int i =0; i < 2; i++)
            {
                 number[i] = Convert.ToInt32(Console.ReadLine());
            }
            /*int a = 0;
            a =number [0];
            int b = 0;
            b = number[1];*/
            // If the second number is not bigger than the first one it should print:
            // "The second number should be bigger"

            if (number[0] > number[1])
            {
                Console.WriteLine("The second number should be bigger");
            }
            else
            {
                for (int i=number[0]; i<number[1];i++)
                {
                    Console.WriteLine(i);
                }
            }
            //
            // If it is bigger it should count from the first number to the second by one
            //
            // example:
            //
            // first number: 3, second number: 6, should print:
            //
            // 3
            // 4
            // 5
        }
    }
}
