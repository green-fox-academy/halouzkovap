using System;

namespace HelloOthers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Greet 3 of your classmates with this program, in three separate lines
            // like:
            //
            // Hello, Esther!
            // Hello, Mary!
            // Hello, Joe!
            

            string[] classmate = {"Ester", "Mary", "Joe" };

            foreach ( string item in classmate)
            {
                Console.WriteLine("Hello, " + item + " !");
            }

        }
    }
}
