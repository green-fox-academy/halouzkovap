using System;
using System.Collections.Generic;

namespace farm
{
    class Program
    {
        static void Main(string[] args)
        {
            // new object
            var animal1 = new Animal();
            var animal2 = new Animal();

            var farm = new Farm();

            // add object to farm
            farm.Add(animal1);
            farm.Add(animal2);

            //print out my animle
            Console.WriteLine(animal1.Hunger + animal1.Thirst);
            Console.WriteLine(animal1.Hunger + animal1.Thirst);

            // animal -hunger
            animal1.eat();
            animal1.eat();
            animal1.eat();

            farm.PritnOut();

            //kill animal with hunger
            farm.Slaughter();

            farm.PritnOut();
            // born new animals
            Console.WriteLine("Breed method");
            farm.Breed();
            farm.PritnOut();

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
    class Farm
    {
        private List<Animal> farmAnimal;

        public Farm()
        {
            farmAnimal = new List<Animal>(3);
        }

        public void Add(Animal animal)
        {
            farmAnimal.Add(animal);
        }
        public void Breed()
        {
            while (farmAnimal.Count < 3)
            {
                farmAnimal.Add(new Animal());
            }
        }
        public void Slaughter()
        {
            int temp = 50;
            int min = 0;

            for (int i = 0; i < farmAnimal.Count - 1; i++)
            {

                if (farmAnimal[i].Hunger < temp)
                {
                    min = farmAnimal[i].Hunger;
                }
                temp = farmAnimal[i].Hunger;


            }
            for (int i = 0; i < farmAnimal.Count; i++)
            {
                if (farmAnimal[i].Hunger == min)
                {
                    farmAnimal.RemoveAt(i);
                    break;
                }
            }


        }
        public void PritnOut()
        {
            int num = farmAnimal.Count;
            Console.WriteLine("in farm is " + num + "animals");
        }
    }
}

