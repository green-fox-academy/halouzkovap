using System;

namespace introduce_yourself
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that prints a few details to the terminal window about you
            // It should print each detail to a new line.
            //  - Your name
            //  - Your age
            //  - Your height in meters (as a decimal fraction)
            //
            //  Example output:
            //  John Doe
            //  31
            //  1.87

            string name = "Petra";
            int age = 30;
            double height = 1.68;

            Console.WriteLine(name);
            Console.WriteLine(age);
            Console.WriteLine(height);
        }
    }
}
