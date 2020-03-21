using System;
using System.Collections.Generic;
using System.Linq;

namespace JurasicPrark
{
    class JurasticPark
    {
        //        Jurasic Park
        //Create class JurassicPark

        //It should contains list of dinosaurs but not visible outside the class
        protected List<Dinosaur> dinosaurs;
        public JurasticPark()
        {
            dinosaurs = new List<Dinosaur>();
        }

        //It should contain those fucntions
        public void AddDino(Dinosaur dino)
        {
            dinosaurs.Add(dino);
        }

        //GetSpecies
        //This will write unique species of dinosaurs in park
        //eg Park contains this species aaaa, bbb, cccc and zzz
        public void GetSpecies()
        {
            var species = dinosaurs.Select(x => x.Name)
                .Distinct().ToList();

            foreach (var item in species)
            {
                Console.WriteLine(item.ToString());
            }
        }

        //Visit
        //Will return List of all dinosaurs if park if the par is open otherwise it will throw an error with messaga "Park is actualy closed."
        public void Visit()
        {
            TimeSpan start = new TimeSpan(10, 0, 0); //10 o'clock
            TimeSpan end = new TimeSpan(20, 0, 0); //20 o'clock
            TimeSpan now = DateTime.Now.TimeOfDay;

            // Park is open
            if ((now > start) && (now < end))
            {
                foreach (var dino in dinosaurs)
                {
                    Console.WriteLine(dino.ToString());
                }
            }
            else Console.WriteLine("The park is closed now"); //Park is closed
        }
        //Statistics
        //Will return list of all dinosaurs in park ordered by name and then by weight
        public void Statistics()
        {
            var newList = dinosaurs.OrderBy(x => x.Name)
                .ThenBy(x => x.Weight).ToList();

            foreach (var item in newList)
            {
                Console.WriteLine(item.ToString());
            }

        }

        //Adopt
        //Will adopt one dinasaur if you dont adopt any earlier.

        //GetDinosaurByName
        //This will return instance of Dinosaur by name otherwise it will return null

        //GetDinosaurByType
        //This will return all dinosaurs by passed type Carnivore, Herbivore, Waterpu
        public void GetDinosaurByType()
        {
            var NewList = dinosaurs.OrderBy(x => x.Kind).ToList();
            foreach (var item in NewList)
            {
                Console.WriteLine(item.ToString());
            }
        }

        //Deport
        //this will remove dinosaur from he park
        public void Deport(Dinosaur dinosaur)
        {
            dinosaurs.Remove(dinosaur);
        }
    }
}
