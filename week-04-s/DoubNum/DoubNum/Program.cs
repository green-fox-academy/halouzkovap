using System;

namespace DoubNum
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `numList`
            //   with the following content: `[3, 4, 5, 6, 7]`
            int[] numList = new int[] { 3, 4, 5, 6, 7 };
            // - Double all the values in the array
            for (int i = 0; i < numList.Length; i++)
            {
                numList[i] *= 2;
            }

            foreach (int number in numList)
            {
                Console.Write($"{number} ");
            }
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
