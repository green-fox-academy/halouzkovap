using System;
using System.Text;

namespace AnimalProtection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            var shelter = new AnimalShelter();
            var dog = new Dog();
            var dog2 = new Dog();
            var dog3 = new Dog();
            Console.WriteLine(dog.ToString());
            Console.WriteLine(dog2.ToString());
            Console.WriteLine(dog3.ToString());

            shelter.Rescue(dog);
            shelter.Rescue(dog3);
            shelter.Rescue(dog2);

            Console.WriteLine(shelter.Heals());
            Console.WriteLine(shelter.Heals());

            shelter.AddAdopter("petra");
            shelter.AddAdopter("petr");
            shelter.FindNewOwner();

            Console.WriteLine(dog.ToString());
            Console.WriteLine(dog2.ToString());
            Console.WriteLine(dog3.ToString());

            //shelter.FindNewOwner();


            Console.WriteLine(shelter.EarnDonation(50));
            Console.WriteLine(shelter.ToString());
        }
    }
}
