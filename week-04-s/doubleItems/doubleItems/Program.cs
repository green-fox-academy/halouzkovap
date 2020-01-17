using System;

namespace doubleItems
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `numList`
            //   with the following content: `[3, 4, 5, 6, 7]`
            int[] numList = new int[] { 3, 4, 5, 6, 7 };
            // - Double all the values in the array
            foreach (int i in numList)
            {
                numList[i] *= 2;
            }
            
            Console.WriteLine(numList[0]);
            Console.ReadLine();
        }
    }
}
