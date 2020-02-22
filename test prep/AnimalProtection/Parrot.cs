namespace AnimalProtection
{
    //The healing cost should be a random number between 4 and 10
    class Parrot : Animal
    {
        public Parrot()
        {
            name = "parrot";
            healCost = rand.Next(4, 11);
        }
        public Parrot(string name)
        {
            this.name = name;
            healCost = rand.Next(4, 11);
        }
    }
}
