using System;

namespace guess_the_number
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that stores a number, and the user has to figure it out.
            // The user can input guesses, after each guess the program would tell one
            // of the following:
            //
            // The stored number is higher
            // The stried number is lower
            // You found the number: 8
            int n,i;
        start:
            Console.WriteLine("guess the number: ");
            n = Convert.ToInt32(Console.ReadLine());
            
           string answer = " ";
            
            if (n > 8)
            {
                Console.WriteLine("the stored number is lower");
                Console.WriteLine("Do you want try it again ? yes/no");
                answer = Console.ReadLine();
                switch(answer)
                {
                    case "yes":
                       
                        goto start;
                    case "no":
                        Console.WriteLine("end");
                        break;
                    default:
                        break;

                }
               
            }
            else if (n<8)
            {
                Console.WriteLine("the stored number is lower");
                Console.WriteLine("Do you want try it again ? yes/no");
                answer = Console.ReadLine();
                switch (answer)
                {
                    case "yes":

                        goto start;
                    case "no":
                        Console.WriteLine("end");
                        break;
                    default:
                        break;

                }
            }
            else if (n==8)
            {
                Console.WriteLine("You found the number: 8");
            }
        }
    }
}
