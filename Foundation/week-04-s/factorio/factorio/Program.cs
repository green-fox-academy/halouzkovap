using System;

namespace factorio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Factorio(5));
            Console.ReadLine();
        }
        static int Factorio(int a)
        {
           int sum = 1;
            for (int i = 1; i <=a; i++)
            {
                sum = sum * i;
            }
            return sum;
        }
    }
}
