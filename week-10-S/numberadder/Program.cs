using System;
using System.Collections.Generic;

namespace numberadder
{
    class Program
    {
        static void Main(string[] args)
        {

            int num = 10;
            List<int> range = RecursFun(num);
            foreach (int item in range)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
        //Write a recursive function that takes one parameter: n and adds numbers from 1 to n.
        public static List<int> RecursFun(int num)
        {
            List<int> numbers = new List<int>();
            for (int i = 1; i <= num; i++)
            {
                numbers.Add(i);
            }

            return numbers;
        }
    }
}
