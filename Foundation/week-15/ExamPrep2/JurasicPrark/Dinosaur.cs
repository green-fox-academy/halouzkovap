using System;

namespace JurasicPrark
{
    public enum Type
    {
        Tyranosaurus,
        Brontosaurus,
        Terodaktil,
        Stegosaurus
    }
    public abstract class Dinosaur
    {
        public string Kind { get; set; }
        public string Name { get; set; }

        public Type TypeOfDinosaurus;
        public int Weight { get; set; }
        Random random = new Random();


        public Dinosaur(Type type)
        {
            Name = type.ToString();
            type = TypeOfDinosaurus;
            Weight = random.Next(1000, 2501);
        }
        public Dinosaur(Type type, int weight)
        {
            Name = type.ToString();
            type = TypeOfDinosaurus;
            Weight = weight;
        }

        public abstract string Roar();
        public abstract string Pet();

        public override string ToString()
        {
            return $"{Name}, {Kind}, {Weight}";
        }

    }
}
