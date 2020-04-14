namespace JurasicPrark
{
    public class Carnivor : Dinosaur
    {
        public Carnivor(Type type) : base(type)
        {
            Kind = "carnivore";

        }
        public Carnivor(Type type, int weight) : base(type, weight)
        {
            Kind = "carnivore";

        }

        public override string Pet()
        {
            return "Are you crazy, he chop your arm!";
        }

        public override string Roar()
        {
            return "Roar";
        }
    }
}
