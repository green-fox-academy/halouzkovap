using System;

namespace Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal elephant = new Elephant();
            Animal lion = new Lion();
            Animal wolf = new Wolf();
            Console.WriteLine(elephant.GetStatus());
            Console.WriteLine(lion.GetStatus());
            Console.WriteLine(wolf.GetStatus());
            elephant.Eat(5);

            var zoo = new Zoo(100, 50);
            zoo.AddAnimal(wolf);
            zoo.AddAnimal(lion);
            zoo.AddAnimal(elephant);

            Console.WriteLine(zoo.GetTheFullestStatus());


        }
    }
}
