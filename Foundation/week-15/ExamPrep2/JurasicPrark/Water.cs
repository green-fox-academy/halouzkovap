namespace JurasicPrark
{
    class Water : Dinosaur
    {
        public Water(Type type) : base(type)
        {
            Kind = "water";
        }
        public Water(Type type, int weight) : base(type, weight)
        {
            Kind = "water";

        }

        public override string Pet()
        {

            return "Let´s go cuddle";

        }

        public override string Roar()
        {
            return "glo glo glo";
        }
    }
}
