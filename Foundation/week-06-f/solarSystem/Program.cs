using System;
using System.Collections.Generic;

namespace solarSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            var planetList = new List<string> { "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Uranus", "Neptune" };


            // Saturn is missing from the planetList
            // Insert it into the correct position
            // Create a method called PutSaturn() which has list parameter and returns the correct list of planets as a string.

            PutSaturn(planetList);
            // Expected output: "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Saturn", "Uranus", "Neptune"
        }
        static void PutSaturn(List<string> a)
        {
            string saturn = "Saturn";
            a.Insert(5, saturn);
            foreach (var item in a)
            {
                Console.WriteLine(item);
            }

        }
    }
}
