namespace AnimalProtection
{
    public class Cat : Animal
    {
        //The healing cost should be a random number between 0 and 6
        public Cat()
        {
            name = "cat";
            healCost = rand.Next(0, 7);
        }
        public Cat(string name)
        {
            this.name = name;
            healCost = rand.Next(0, 7);
        }



    }
}
