using System;
using System.Linq;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Exercise 1
            //Write a LINQ Expression to get the even numbers from the following array:

            int[] n1 = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };
            var n1EvenNumber = n1.Where(x => x % 2 == 0).ToList();
            //Console.WriteLine("Even number");
            //n1EvenNumber.ForEach(n => Console.WriteLine(n));


            //            Exercise 2
            //Write a LINQ Expression to get the average value of the odd numbers from the following array:

            int[] n2 = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };
            var n2OddNumber = n2.Where(x => x % 2 != 0).Average();
            //Console.WriteLine(n2OddNumber);


            //            Exercise 3
            //Write a LINQ Expression to get the squared value of the positive numbers from the following array:

            int[] n3 = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };
            var n3SquaredNumber = n3.Where(x => x > 0).Select(x => Math.Pow(x, 2)).ToList();
            // n3SquaredNumber.ForEach(n => Console.WriteLine(n));

            //            Exercise 4
            //Write a LINQ Expression to find which number squared value is more then 20 from the following array:

            int[] n4 = new[] { 3, 9, 2, 8, 6, 5 };
            var n4SquaredNumber = n4.Where(x => Math.Pow(x, 2) > 20).ToList();
            //n4SquaredNumber.ForEach(n => Console.WriteLine(n));


            //            Exercise 5
            //Write a LINQ Expression to find the frequency of numbers in the following array:

            int[] n5 = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };
            var query = n5.GroupBy(x => x).Select(x => new { key = x.Key, val = x.Count() });
            foreach (var item in query)
            {
                Console.WriteLine(item.key + ":" + item.val);
            }
            //            Exercise 6
            //Write a LINQ Expression to find the frequency of characters in a given string.
            string frequency = "Frequency";
            var charFrequency = frequency.ToCharArray().GroupBy(x => x).Select(x => new { key = x.Key, val = x.Count() });
            foreach (var item in charFrequency)
            {
                Console.WriteLine(item.key + ":" + item.val);
            }
            //Exercise 7
            //Write a LINQ Expression to find the strings which starts with A and ends with I in the following array:

            string[] cities = { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };
            var newCities = cities.Where(c => c.StartsWith("A") && c.EndsWith("I")).ToList();
            foreach (var item in newCities)
            {
                Console.WriteLine(item);
            }

            //            Exercise 8
            //Write a LINQ Expression to find the uppercase characters in a string.
            string upperChar = "Hello FiGurka";
            var linqUpperCHar = upperChar.ToCharArray().Where(x => x == char.ToUpper(x)).ToList();
            foreach (var item in linqUpperCHar)
            {
                Console.WriteLine(item);
            }
            //Exercise 9
            //Write a LINQ Expression to convert a char array to a string.
            char[] charArray = { 'h', 'e', 'l', 'l', 'o' };
            var newString = new string(charArray);
            var otherWay = string.Concat(charArray);
            Console.WriteLine(newString);
            Console.WriteLine(otherWay);
        }
    }
}
