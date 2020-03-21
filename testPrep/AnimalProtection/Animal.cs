using System;

namespace AnimalProtection
{
    public class Animal
    {
        //Animal
        //It must have ownerName and stores it's health's state isHealthy(true or false) and a healCost.
        protected string ownerName { get; set; }
        protected int health { get; set; }
        public bool isHealthy { get; set; }
        public int healCost { get; set; }

        //The animal's name is the same as the class name by default, but it can be set trough constructor as well
        protected string name { get; set; }
        protected Random rand;


        public Animal()
        {
            name = "Animal";
            rand = new Random();
            healCost = rand.Next();
            isHealthy = false;


        }
        public Animal(string name)

        {
            this.name = name;
            rand = new Random();
            isHealthy = false;
        }


        //It must have a method named heal(), that sets the isHealthy field's status to true

        public void Heal()
        {
            isHealthy = true;
        }


        //It must have a method named isAdoptable that returns a boolean value whether it can be 
        //adopted or not - an animal can be adopted if it is healthy
        public bool isAdoptabel()
        {
            if (isHealthy)
            {
                return true;
            }
            return false;
        }


        //It must have a method named toString() that represents the Animal in the following format:
        //<name> is not healthy(<heal cost>€), and not adoptable
        //<name> is healthy, and adoptable

        public override string ToString()
        {

            return $"{name} " + (!isHealthy ? $"is not healthy (healing would cost:" +
                    $" {healCost}€) and not adoptable" : "is healthy and adoptable");
        }



    }
}
