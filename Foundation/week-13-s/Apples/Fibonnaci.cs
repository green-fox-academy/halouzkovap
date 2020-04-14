using System.Collections.Generic;

namespace Apples
{
    public class Fibonnaci
    {
        //        Write a function that computes a member of the fibonacci sequence by a given index
        //Create tests for multiple test cases.
        public List<int> fibo(int n)
        {
            List<int> fiboList = new List<int>();
            for (int i = 0; i < n; i++)
            {
                fiboList.Add(Fibonaci(i));
            }
            return fiboList;
        }

        private int Fibonaci(int n)
        {
            int a = 0;
            int b = 1;
            // In N steps compute Fibonacci sequence iteratively.
            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;

        }
    }
}
