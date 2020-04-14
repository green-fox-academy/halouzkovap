using System;

namespace ParametricAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for a number.
            // It would ask this many times to enter an integer,
            // if all the integers are entered, it should print the sum and average of these
            // integers like:
            int[] num = new int[2];
            Console.WriteLine("Write 2 num and i will tell you sume and averadge :");
            for (int i = 0; i < 2; i++)
            {
                num[i] = Convert.ToInt32(Console.ReadLine());
            }

            double a = num[0];
            double b = num[1];

            double sum = a + b;
            double averadge = sum / 2;

            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Averadge: {averadge}");


            //
            // Sum: 22, Average: 4.4
        }
    }
}
