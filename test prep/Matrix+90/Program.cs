using System;

namespace Matrix_90
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] colors = new int[3, 3] { {1, 2, 3 },
                                            { 4, 5, 6},
                                            {7, 8, 9} };
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {

                    Console.Write(colors[i, j] + ",");
                }
                Console.WriteLine();

            }

            Console.WriteLine();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 2; j >= 0; j--)
                {

                    Console.Write(colors[j, i] + ",");
                }
                Console.WriteLine();

            }

        }
    }
}
