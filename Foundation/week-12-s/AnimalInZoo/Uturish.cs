namespace AnimalInZoo
{
    abstract class Uturish : Animal
    {

        private string Baby = "uterus";

        protected override string Reproduction()
        {
            return $"my {Baby}!";
        }

    }

}
