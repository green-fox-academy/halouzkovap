using System;
using System.Collections.Generic;

namespace isInList
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int> { 2, 4, 6, 8, 10, 12, 14, 16 };
            var blist = new List<int> { 4, 8, 1, 16 };

            // Check if list contains all of the following elements: 4,8,12,16
            // Create a method that accepts list as an input
            // it should return "true" if it contains all, otherwise "false"
            CheckNums(list, blist);
        }
        static void CheckNums(List<int> alist, List<int> containList)
        {
            var result = true;
            for (int i = 0; i < containList.Count; i++)
            {
                if (!alist.Contains(containList[i]))
                {
                    result = false;
                    break;
                }

            }

            Console.WriteLine(result);

        }
    }
}
