using System;

namespace Pirates
{
    class Pirate
    {
        public string Name { get; set; }
        public int rum { get; private set; }
        public int lives { get; set; }

        public Pirate(string name)
        {
            Name = name;
            lives = 1;
            rum = 0;
        }
        public void DrinkSomeRum()
        {
            rum++;
            DecreseLive(this);
            Die();
        }
        public string HowsItGoingMate()
        {

            if (rum <= 4)
            {
                return "Pour me anudder!";
            }
            else
            {
                return "Arghh, I'ma Pirate. How d'ya d'ink its goin?";
            }

        }
        public void Die()
        {
            Console.WriteLine("you are dead");
        }
        public void Die(Pirate Pirate)
        {
            Console.WriteLine($"{Pirate.Name} dies", Pirate.Name);
        }

        private void DecreseLive(Pirate pirate)
        {
            pirate.lives--;
        }
        public void Drawl(Pirate pirate1)
        {
            if (pirate1.lives == 0)
            {
                Console.WriteLine($"This Pirate is winner : {this.Name}", this.Name);
            }
            else if (this.lives == 0)
            {
                Console.WriteLine($"This Pirate is winner : {pirate1.Name}", pirate1.Name);
            }
            else
            {
                var random = new Random();
                int num = random.Next(1, 3);
                if (num == 1)
                {
                    Die(this);
                    DecreseLive(this);

                }
                else if (num == 2)
                {
                    Die(pirate1);
                    DecreseLive(pirate1);
                }
                else
                {
                    DecreseLive(this);
                    DecreseLive(pirate1);
                    Console.WriteLine("both of you are dead");
                }
            }

        }

        public void PrintOutPirate()
        {
            Console.WriteLine($"Name: {this.Name}, lives: {this.lives}, rum: {this.rum}.", this.Name, this.lives, this.rum);
        }

    }
}
