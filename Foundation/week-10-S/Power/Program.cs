using System;

namespace Power
{
    class Program
    {
        static void Main(string[] args)
        {
            //Given base and n that are both 1 or more, compute recursively
            //(no loops) the value of base to the n power, so powerN(3, 2) is 9(3 squared).
            int baseInt = 3;
            int exponencitalInt = 4;
            Console.WriteLine(Power(baseInt, exponencitalInt));
            Console.ReadLine();
        }
        public static int Power(int baseInt, int exponencialInt)
        {
            if (exponencialInt == 0)
            {
                return 1;
            }
            else
            {
                return baseInt * Power(baseInt, exponencialInt - 1);
            }
        }
    }
}
