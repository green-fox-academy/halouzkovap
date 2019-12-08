using System;

namespace ConditionalVariableMutation
{
    class Program
    {
        static void Main(string[] args)
        {
           
            double a = 24;
            int out1 = 0;
            // if a is even increment out by one
            if (a % 2 == 0)
            {

                out1 += 1;
            }
            Console.WriteLine(out1);

            
            
            int b = 13;
            string out2 = "";
            if (b < 20 && b >10)
            // if b is between 10 and 20 set out2 to "Sweet!"
            {
                out2 = "sweet";
            }
           
            // if less than 10 set out2 to "Less!",
            else if (b <10)
            {
                out2 = "Less !";
            }
            // if more than 20 set out2 to "More!"
            else if (b > 20)
            {
                out2 = "More !";
            }

            Console.WriteLine(out2);

            int c = 123;
            int credits = 100;
            bool isBonus = false;
            // if credits are at least 50,
            // and isBonus is false decrement c by 2
            // if credits are smaller than 50,
            // and isBonus is false decrement c by 1
            // if isBonus is true c should remain the same

            Console.WriteLine(c);

            int d = 8;
            int time = 120;
            string out3 = "";
            // if d is dividable by 4
            // and time is not more than 200
            // set out3 to "check"
            // if time is more than 200
            // set out3 to "Time out"
            // otherwise set out3 to "Run Forest Run!"

            Console.WriteLine(out3);
            
        }
    }
}
