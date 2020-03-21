using System;

namespace Zoo2
{
    class Program
    {
        static void Main(string[] args)
        {
            var elephnat = new Elephant();
            elephnat.Eat(5);
            Console.WriteLine(elephnat.ToString());

        }
    }
}
