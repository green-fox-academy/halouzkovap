using System;

namespace DIHelloWord.Models
{
    public class Color : IColor
    {


        public void PrintColor(string color)
        {
            Console.WriteLine(color);
        }
    }
}
