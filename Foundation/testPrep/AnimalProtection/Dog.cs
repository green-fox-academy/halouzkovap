namespace AnimalProtection
{
    class Dog : Animal
    {
        //he healing cost should be a random number between 1 and 8
        public Dog()
        {
            name = "dog";
            healCost = rand.Next(1, 9);
        }
        public Dog(string name)
        {
            this.name = name;
            healCost = rand.Next(1, 9);
        }
    }
}
