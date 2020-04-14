using System;

namespace DivideByZero
{
    class Program
    {
        static string Divide(string num)
        {
            int numB = Convert.ToInt32(num);
            int a = 10;
            int result;

            try
            {
                result = a / numB;
                return Convert.ToString(result);
            }
            catch (DivideByZeroException e)
            {
                string message = "you cannot divide by zero";
                return message;

            }


        }
        static void Main(string[] args)
        {
            Console.WriteLine(Divide("0"));

            Console.ReadLine();
        }
    }
}
