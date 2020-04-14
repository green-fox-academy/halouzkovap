using System;

namespace partyIndicator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for two numbers
            // The first number represents the number of girls that comes to a party, the
            // second the boys
            Console.WriteLine("tell me 2 numbers, first number represents the number of girls that comes to a party, the second the boys");
            
            int[] num = new int[2];
            for (int i = 0; i < 2; i++)
            {
                num[i] = Convert.ToInt32(Console.ReadLine());
            }

            int a = 0;
            a = num[0];
            int b = 0;
            b = num[1];
            int c = a + b;
            // It should print: The party is exellent!
            // If the the number of girls and boys are equal and there are more people coming than 20
            if (a == b && c >= 20)
            {
                Console.WriteLine("The party is exellent!");
            }
            // It should print: Quite cool party!
            // It there are more than 20 people coming but the girl - boy ratio is not 1-1
            else if (a != 0 && b!=0 && c>20)
            {
                Console.WriteLine("Quite cool party!");
            }

            //
            // It should print: Average party...
            // If there are less people coming than 20
            else if (a != 0 && c < 20)
            {
                Console.WriteLine("Average party...");
            }
            // It should print: Sausage party
            // If no girls are coming, regardless the count of the people
            else if (a==0)
            {
                Console.WriteLine("Sausage party");
            }
        }
    }
}
