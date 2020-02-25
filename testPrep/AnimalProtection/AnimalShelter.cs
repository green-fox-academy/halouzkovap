using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalProtection
{
    class AnimalShelter
    {
        private StringBuilder stringbuilder;

        public double Budget { get; set; }
        public List<Animal> Animals { get; set; }
        public List<string> Adopters { get; set; }

        public AnimalShelter()
        {
            Budget = 50.00;
            Animals = new List<Animal>();
            Adopters = new List<string>();
        }
        public int Rescue(Animal animal)
        {
            Animals.Add(animal);
            return Animals.Count;
        }
        public void AddAdopter(string name)
        {
            Adopters.Add(name);
        }
        public int Heals()
        {
            var first = Animals.First(a => a.isHealthy != true);
            if (Budget > first.healCost)
            {
                first.Heal();
                Budget -= first.healCost;
                return 1;
            }
            return 0;

        }

        //It must have a method named findNewOwner
        //this method pairs a random name with a random adoptable Animal if it is possible
        //and removes both of them from the lists
        public void FindNewOwner()
        {
            var random = new Random();
            List<Animal> newList = Animals.OrderBy(a => a.isHealthy == true).ToList();
            var count = Animals.Count(a => a.isHealthy == true);
            Console.WriteLine(count);

            while (Adopters.Count != 0 && count != 0)
            {
                int randomOwener = random.Next(0, Adopters.Count);
                int randomAnimal = random.Next(0, count);
                Adopters.RemoveAt(randomOwener);
                Animals.RemoveAt(randomAnimal);

                count--;
            }
        }
        public double EarnDonation(double money)
        {
            Budget += money;
            return Budget;
        }
        public override string ToString()
        {
            stringbuilder = new StringBuilder();

            stringbuilder.Append($"Budget: {Budget}€,\nThere are {Animals.Count} animal(s) a {Adopters.Count} potential adopter(s)\n");

            foreach (var item in Animals)
            {
                stringbuilder.Append(item.ToString());
                stringbuilder.Append("\n");
            }
            return stringbuilder.ToString();
        }

    }
}
