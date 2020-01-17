using System;
using System.Collections.Generic;
using System.Linq;

namespace armstrong_numbe
{
    class Program
    {
        static void Main(string[] args)
        {
            ArmstrongN("12");
        }
        static void ArmstrongN(string number)
        {
            List<int> result = number.Select(c => int.Parse(c.ToString())).ToList();

            double sum = 0;
            for (int i = 0; i < result.Count; i++)
            {
                sum += (Math.Pow(result[i], result.Count));
            }


            string newNum = sum.ToString();

            if (number == newNum)
            {
                Console.WriteLine("it is armstrong number");
            }
            else
            {
                Console.WriteLine("it s not armstrong number");
            }


        }
    }
}
