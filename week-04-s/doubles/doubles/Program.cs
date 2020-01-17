using System;

namespace doubles
{
    class Program
    {
        static void Main(string[] args)
        {

            // - Create an integer variable named `baseNum` and assign the value `123` to it
            // - Create a function called `Doubling` that doubles it's input parameter and returns with an integer
            // - Create a function called `Doubling` that doubles it's input parameter and returns with an integer
            // - Print the result of `Doubling(baseNum)`
            int baseNum = 123;
            int b;

            b = Doubling(123);
            Console.WriteLine(b);
           
            Console.ReadLine();
        }
       
        public static int Doubling(int a)
        {
             a*=2;
            return a;
        }
    }
}
