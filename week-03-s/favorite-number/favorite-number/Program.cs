using System;

namespace favorite_number
{
    class Program
    {
        static void Main(string[] args)
        {
            // Store your favorite number in a variable (as a number)
            // And print it like this: "My favorite number is: 8"
            Console.WriteLine("tell my your fav. number");

            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("nice your fav. number is  " + num);

        }
    }
}
