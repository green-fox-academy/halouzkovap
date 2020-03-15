namespace Zoo
{
    public class Elephant : Animal
    {
        //Elephant
        //Herbivore
        //Max food: 40
        //Consume Level: 5
        public Elephant()
        {
            Name = "Elephant";
            Herbivore = true;
            ConsumeLevel = 5;
            MaxFood = 40;
            CurrentBelly = 0;
        }

    }
}
