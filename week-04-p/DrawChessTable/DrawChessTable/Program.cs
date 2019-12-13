using System;

namespace DrawChessTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tell me number of lines :");
            int n = Convert.ToInt32(Console.ReadLine());
            int counter = 0;
            int j;

            while (counter < n)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write("%");
                    Console.Write(" ");
                }
                Console.WriteLine();
                counter++;
                if (counter == n)
                {
                    break;
                }
                for (j = 0; j < n; j++)
                {
                    Console.Write(" ");
                    Console.Write("%");
                }
                Console.WriteLine();
                counter++;
            }
        }
    }
}
