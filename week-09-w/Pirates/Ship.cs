using System;
using System.Collections.Generic;

namespace Pirates
{
    class Ship
    {

        public List<Pirate> ship;
        //public string Captain { get; set; }


        public Ship()
        {
            ship = new List<Pirate>();

        }
        public void Add(Pirate animal)
        {
            ship.Add(animal);
        }

        public void fillShip()
        {
            ship.Add(new Pirate("Captain"));

            var random = new Random();
            int numOfPirates = random.Next(5, 20);


            for (int i = 0; i <= numOfPirates; i++)
            {
                ship.Add(new Pirate($"Pirate{i + 1}"));
            }


        }

        public void printOut()
        {
            foreach (var item in ship)
            {
                Console.WriteLine($"{item.Name}, {item.lives}, {item.rum}", item.Name, item.lives, item.rum);
            }
        }

        public bool Battle(List<Pirate> otherShip)
        {
            int lives1 = 0;
            int lives2 = 0;

            for (int i = 0; i < this.ship.Count; i++)
            {
                if (ship[i].lives == 1)
                {
                    lives1++;
                }
                if (otherShip[i].lives == 1)
                {
                    lives2++;
                }
            }

            if (lives1 > lives2)
            {
                return true;
            }
            return false;
        }


    }
}