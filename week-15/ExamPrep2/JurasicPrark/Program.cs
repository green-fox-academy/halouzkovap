namespace JurasicPrark
{
    class Program
    {
        static void Main(string[] args)
        {
            var dino = new Water(Type.Brontosaurus);
            var dino2 = new Herbivore(Type.Tyranosaurus);
            var dino3 = new Carnivor(Type.Terodaktil);
            var dino4 = new Carnivor(Type.Terodaktil);


            var jurastic = new JurasticPark();
            jurastic.AddDino(dino);
            jurastic.AddDino(dino2);
            jurastic.AddDino(dino3);
            jurastic.AddDino(dino4);

            System.Console.WriteLine("by name and weight:");
            jurastic.Statistics();

            System.Console.WriteLine("by type:");
            jurastic.GetDinosaurByType();

            System.Console.WriteLine("spicies");
            jurastic.GetSpecies();


        }
    }
}
