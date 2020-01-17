using System;
using System.Collections.Generic;
using System.Text;

namespace textTask
{
    class Program
    {
        static void Main(string[] args)
        {
            /// <summary>
            /// Write a program and ask the user to enter a few numbers separated by a hyphen. Work out 
            /// if the numbers are consecutive. For example, if the input is "5-6-7-8-9" or
            /// "20-19-18-17-16", 
            /// display a message: "Consecutive"; otherwise, display "Not Consecutive".
            /// </summary>
            /// 

            Console.WriteLine("Write few numbers separated by a hyphen e.g. 7-8-9");
            var input = Console.ReadLine();

            var numbers = new List<int>();

            foreach (var number in input.Split("-"))
            {
                numbers.Add(Convert.ToInt32(number));
            }
            
            numbers.Sort();

            var isConsecutive = true;

            for (int i = 1; i < numbers.Count ; i++)
            {
               
                    if( numbers[i] != numbers[i-1]+1)
                    {
                    isConsecutive = false; 
                    }
                var message = isConsecutive ? "Consecutive" : "Not Consecutive";
                Console.WriteLine(message);
            }


            /// <summary>
            /// Write a program and ask the user to enter a few numbers separated by a hyphen.
            /// If the user simply 
            /// presses Enter without supplying an input, exit immediately; 
            /// otherwise, check to see if there are 
            /// any duplicates. If so, display "Duplicate" on the console.
            /// </summary>
            /// 
            Console.WriteLine("Write few numbers separated by a hyphen e.g. 7-8-9");
            var input2 = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(input2))
                return;

            var numo = new List<int>();

            foreach (var number in input2.Split("-"))
            {
                numo.Add(Convert.ToInt32(number));
            }

            var duplicate = new List<int>();

            var includeDuplicate = false;
            foreach (var item in numo)
            {
                if (!duplicate.Contains(item))
                {
                    duplicate.Add(item);
                }
                else
                {
                    includeDuplicate = true;
                    break;
                }  
            }

            if (includeDuplicate)
                Console.WriteLine("include duplicate");


            /// <summary>
            /// Write a program and ask the user to enter a time value in the 24-hour time format 
            /// (e.g. 19:00).
            /// A valid time should be between 00:00 and 23:59. If the time is valid, display "Ok";
            /// otherwise, 
            /// display "Invalid Time". If the user doesn't provide any values, consider it as invalid 
            /// time. 
            /// </summary>
            /// 
            Console.WriteLine("enter a time value in the 24-hour time format (e.g. 19:00)");
            var input3 = Console.ReadLine(); 
            var time = new TimeSpan(1,1,0);
            if (String.IsNullOrWhiteSpace(input3))
            {
                Console.WriteLine("Invalit input");
                return;
            }

            var components = input3.Split(":");
            if(components.Length!=2)
            {
                Console.WriteLine("Invalit input");
                return;
            }

            try
            { 
                var hour = Convert.ToInt32(components[0]);
                var minut = Convert.ToInt32(components[1]);
                if ( hour >= 00 && hour <= 23 && minut >= 00 && minut <= 59)
                {
                    Console.WriteLine("ok");
                }
                else
                {
                    Console.WriteLine("Invalit input");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Invalit input");
            }


            /// <summary>
            /// Write a program and ask the user to enter a few words separated by a space. Use the 
            /// words to 
            /// create a variable name with PascalCase convention. For example, if the user types: 
            /// "number of students", display "NumberOfStudents". Make sure the program is not 
            /// dependent on 
            /// the casing of the input. So if the input is "NUMBER OF STUDENTS", it should still 
            /// display 
            /// "NumberOfStudents". If the user doesn't supply any words, display "Error".
            /// </summary>
            /// 
            Console.WriteLine("enter a few words separated by a space");
            var input4 = Console.ReadLine();

            List<string> words = new List<string>();
            var words2 = input4.Split(" ");
            foreach (var item in words2)
            {
                words.Add(char.ToUpper(item[0]) + item.ToLower().Substring(1));
            }

            foreach (var item in words)
            {
                Console.Write(item);
            }
            Console.WriteLine();

            /// <summary>
            /// Write a program and ask the user to enter an English word. Count the number of vowels 
            /// (a, e, o, u, i) in the word. So, if the user enters "inadequate", the program should 
            /// display 
            /// 6 on the console. Make sure the program calculates the number of vowels irrespective of
            /// the 
            /// casing of the word (eg "Inadequate", "inadequate" and "INADEQUATE" all include 6 vowels).
            /// </summary>
            /// 

            Console.WriteLine("enter english word");
            var engWord = Console.ReadLine().ToLower();

            var vowels = new List<char>(new char[]{'a','e','o', 'u', 'i' });
            var vowelsCount = 0;
            foreach (var item in engWord)
            {
                if(vowels.Contains(item))
                vowelsCount++;
            }
            Console.WriteLine(vowelsCount);

        }
    }
}
