using System;


namespace Fibonacci
{
    class Program
    {

        static void Main(string[] args)
        {
            int num = 5;
            Console.WriteLine(FiboNum(num));
            Console.ReadLine();
        }


        public static int FiboNum(int num)
        {
            if (num < 2)
            {
                return num;
            }
            return FiboNum(num - 1) + FiboNum(num - 2);
        }




    }
}
