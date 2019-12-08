using System;

namespace averageOfInput
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for 5 integers in a row,
            // then it should print the sum and the average of these numbers like:
            //
            // Sum: 22, Average: 4.4

            Console.WriteLine("tell me 5 numbers and i will cound you averadge and sum");

            int[] num = new int[5];
            for (int i = 0 ; i < 5; i++)
            {
                num[i] = Convert.ToInt32(Console.ReadLine());
            }

            double sum = 0;
            double averadge = 0;
            int lenghtOfnum = num.Length;

            for (int i = 0; i < num.Length; i++)
            {
                sum += num[i];
            };

            averadge = sum / lenghtOfnum;
            
            foreach (var item in num)
                Console.Write("{0}", item);
            Console.WriteLine(" ");
            Console.WriteLine("sum is " + sum);
            Console.WriteLine("averadge is " + averadge);

           
        }
    }
}
