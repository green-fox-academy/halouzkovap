using System;

namespace ConsoleApp1
{
    class Dog
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Dog(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public override string ToString()
        {
            return $"woof woof i m  {Name} ";
        }

    }
    class Humen
    {
        public string Name { get; set; }
        public Dog Dog;
        public Humen(string name, Dog dog)
        {
            Name = name;
            Dog = dog;
        }
        public override string ToString()
        {
            return $"my name is {Name} and i have a {Dog}";
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            var dog1 = new Dog("Boris", 7);
            var human1 = new Humen("joe", dog1);
            Console.WriteLine(human1);
            Console.ReadLine();
        }
    }
}
