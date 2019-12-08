using System;

namespace cuboid
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that stores 3 sides of a cuboid as variables (doubles)
            // The program should write the surface area and volume of the cuboid like:
            Console.WriteLine("tell me side a");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("tell me side b");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("tell me side c");
            double c = Convert.ToDouble(Console.ReadLine());

            double surfaceArea;
            surfaceArea = 2 * (a * b + b * c + c * a);

            double volume;
            volume = a * b * c;
            // Surface Area: 600
            // Volume: 1000
            Console.WriteLine("Surface area is " + surfaceArea);
            Console.WriteLine("volume is " + volume );
        }
    }
}
