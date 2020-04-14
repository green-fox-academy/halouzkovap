﻿using System;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a very simplistic calculator: ask for two numbers and an operation (add, subtract, multiply or divide)
            // Based on the operation provided print the result of the calculation.

            Console.WriteLine("Welcome to the Calculator!");
            Console.WriteLine("Please provide the first number:");
            int number1;
            number1 = Convert.ToInt32(Console.ReadLine());
            // Get the first number:
            // int number1 = ...

            Console.WriteLine("Please provide the second number:");

            // Get the second number:
            // int number2 = ...
            int number2;
            number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please provide the operation (add, subtract, multiply or divide):");
            string operation = " ";
            operation = Console.ReadLine();
            // Get the operation from standard input:
            // string operation = ...

            // use the `switch` statement and the corresponding calculation
            // store the result of the calculation in the `result` variable

            double result = 0.0;

            switch (operation)
            {
                case "add":
                    result = number1 + number2;
                    break;
                case "subtract":
                    result = number1 - number2;
                    break;
                case "multiply":
                    result = number1 * number2;
                    break;
                case "divide":
                    result = number1 / number2;
                    break;
                default:
                    break;
            }

            Console.WriteLine($"The result of the calculation is {result}");
        }
    }
}
