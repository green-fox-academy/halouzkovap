﻿using System;

namespace sum_elements
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `r`
            //   with the following content: `[54, 23, 66, 12]`
            // - Print the sum of the second and the third element
            int[] r = new int[] { 54, 23, 66, 12 };
            int a = r[1] + r[2];
            

            Console.WriteLine(a);
           

            Console.ReadLine();
        }
    }
}
