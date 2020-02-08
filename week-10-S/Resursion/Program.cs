using System;

namespace Resursion
{
    class Program
    {
        static void Main(string[] args)
        {
            int exponentInt = 0;
            int baseInt = 0;

            Console.WriteLine("Write base :");
            baseInt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write exponent :");
            exponentInt = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("result is " + Power(baseInt, exponentInt));
            Console.ReadLine();
        }

        public static int Power(int baseInt, int exponentInt)
        {
            if (exponentInt == 0)
            {
                return 1;
            }
            else
            {

                return baseInt * Power(baseInt, exponentInt - 1);
            }
        }
    }
}
