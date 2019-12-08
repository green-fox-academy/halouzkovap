using System;

namespace animals_and_legs
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for two integers
            int pigs;
            int chickens;
            Console.WriteLine("tell me how many chickens farmer has on farm ?");
            chickens = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("tell me how many pigs  farmer has on farm ?");
            pigs = Convert.ToInt32(Console.ReadLine());

            int pigLeg = 4;
            int chickensLeg = 2;

            int sumOfPigsLegs = pigs * pigLeg;
            int sumOfChickenLegs = chickens * chickensLeg;
            int totalSum = sumOfChickenLegs + sumOfPigsLegs;
            // The first represents the number of chickens the farmer has
            // The second represents the number of pigs owned by the farmer
            // It should print how many legs all the animals have
            Console.WriteLine("There are " + totalSum + " animal legs on the farm");

        }
    }
}
