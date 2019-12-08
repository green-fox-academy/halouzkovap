using System;

namespace draw_triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number from the standard input, then draws a
            // triangle like this:
            //
            // *
            // **
            // ***
            // ****
            //
            // The triangle should have as many lines as the number was
            Console.WriteLine("tell me number");
            int num = Convert.ToInt32(Console.ReadLine());

            for(int i=0; i <= num; i++)
            {
                Console.WriteLine(new String('*', i));
            }
           
          
        }
    }
}
