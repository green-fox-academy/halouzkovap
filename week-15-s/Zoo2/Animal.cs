namespace Zoo2
{
    public class Animal
    {
        protected string Name;
        protected int HungerLevel;
        protected int MaxConsumed;
        protected int CurrentBelly;

        public void Eat(int food)
        {
            int foodToEat = food;
            CurrentBelly += foodToEat;
        }

        public override string ToString()
        {
            return $"{Name} hunger level {HungerLevel}, current belly {CurrentBelly} max consumed {MaxConsumed}";
        }
    }
}
