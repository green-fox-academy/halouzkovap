using System;

namespace mile_to_km_converter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for a double that is a distance in miles,
            Console.WriteLine("tel me miles and i will convert it to km");
            double miles = Convert.ToDouble(Console.ReadLine());
            // then it converts that value to kilometers and prints it
            //1 míle = 1,609344 kilometru
            double km = 1.609344;
            double result;
            result = miles * km;
            Console.WriteLine(result);




        }
    }
}
