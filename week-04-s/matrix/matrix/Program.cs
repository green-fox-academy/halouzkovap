using System;

namespace matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create (dynamically) a two dimensional array
            //   with the following matrix. Use a loop!
            //
            //   1 0 0 0
            //   0 1 0 0
            //   0 0 1 0
            //   0 0 0 1
            //
            // - Print this two dimensional array to the output
           

            int[,] colors = new int[4, 4];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    // colors[i, j] = " " + i + " " + j;
                    //Console.Write(colors[i, j]);
                    if (i == j)
                    {
                        colors[i, j] = 1;
                    }

                    Console.Write(colors[i, j] + " ");
                }


                Console.WriteLine();
            }          
        }
    }
}
