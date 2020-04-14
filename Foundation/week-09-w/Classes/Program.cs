using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            var animal1 = new Animal();
            Console.WriteLine(animal1.Hunger + animal1.Thirst);

            animal1.eat();
            Console.WriteLine(animal1.Hunger + animal1.Thirst);

            Console.ReadLine();
        }
    }

    class Animal
    {
        public int Hunger { get; set; }
        public int Thirst { get; set; }
        public Animal()
        {
            Hunger = 50;
            Thirst = 50;
        }
        public void eat()
        {
            Hunger--;
        }
        public void drink()
        {
            Thirst--;
        }
        public void play()
        {
            Hunger++;
            Thirst++;
        }

    }
}
