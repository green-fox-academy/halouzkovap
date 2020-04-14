namespace GardenApp
{
    public enum TypeOfRose { yellow, blue };
    class Flowers : Plant
    {

        public TypeOfRose TypeOfRose;



        public Flowers(TypeOfRose typeOfRose)
        {
            TypeOfRose = typeOfRose;
            Name = "Flowers";
            maxWater = 5;
            wateringCoeficient = 0.75;
        }
        public override void Info()
        {
            bool need = NeedWater();
            if (need)
            {
                System.Console.WriteLine($"The {TypeOfRose.ToString()} {Name} needs water");
            }
            else
            {
                System.Console.WriteLine($"The {TypeOfRose.ToString()} {Name} doesn´t need water");
            }
        }
    }
}
