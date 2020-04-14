using System;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a simple calculator application which reads the parameters from the prompt
            // and prints the result to the prompt.
            // It should support the following operations,
            // reate a method named "Calculate()":
            // +, -, *, /, % and it should support two operands.
            // The format of the expressions must be: {operation} {operand} {operand}.
            // Examples: "+ 3 3" (the result will be 6) or "* 4 4" (the result will be 16)
            Console.WriteLine("Please type operation(+, -, *, /, %):");
            var operation = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Please type operand A:");
            var operandA = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please type operand B:");
            var operandB = Convert.ToDouble(Console.ReadLine());



            Calculat(operation, operandA, operandB);
            // You can use the Scanner class
            // It should work like this:

            // Start the program
            // It prints: "Please type in the expression:"
            // Waits for the user input
            // Print the result to the prompt
            // Exit
        }
        static void Calculat(char operation, double operandA, double operandB)
        {

            if (operation == '+')
            {
                Console.WriteLine("result is :" + ((double)operandA + (double)operandB));
            }
            else if (operation == '-')
            {
                Console.WriteLine("result is :" + ((double)operandA - (double)operandB));
            }
            else if (operation == '/')
            {
                Console.WriteLine("result is :" + ((double)operandA / (double)operandB));
            }
            else if (operation == '%')
            {
                Console.WriteLine("result is :" + ((double)operandA % (double)operandB));
            }
            else if (operation == '*')
            {
                Console.WriteLine("result is :" + ((double)operandA * (double)operandB));
            }
        }
    }
}
