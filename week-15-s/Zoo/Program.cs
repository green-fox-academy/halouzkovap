using System;

namespace Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            var elephant = new Elephant();
            var lion = new Lion();
            var wolf = new Wolf();


            Console.WriteLine(elephant.GetStatus());
            Console.WriteLine(lion.GetStatus());
            Console.WriteLine(wolf.GetStatus());
            elephant.Eat(5);
            lion.Eat(4);
            wolf.Eat(4);
        }
    }
}
