namespace AnimalInZoo
{
    abstract class Eggish : Animal
    {


        private string Baby = "eggs";

        protected override string Reproduction()
        {
            return $"an {Baby}!";
        }

    }
}
