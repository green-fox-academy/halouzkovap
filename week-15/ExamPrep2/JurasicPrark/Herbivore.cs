namespace JurasicPrark
{
    class Herbivore : Dinosaur
    {
        public Herbivore(Type type) : base(type)
        {
            Kind = "herbivore";

        }
        public Herbivore(Type type, int weight) : base(type, weight)
        {
            Kind = "herbivore";

        }

        public override string Roar()
        {
            return "Roar";
        }
        public override string Pet()
        {

            return "Let´s go cuddle";

        }
    }
}
