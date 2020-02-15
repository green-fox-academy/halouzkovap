namespace GardenApp
{
    public enum TypeOfTree { purple, orange }
    class Tree : Plant
    {
        public TypeOfTree TypeOfTree;


        public Tree(TypeOfTree typeOfTree) : base()
        {
            TypeOfTree = typeOfTree;
            Name = "Tree";
            maxWater = 10;
            wateringCoeficient = 0.4;
        }

        public override void Info()
        {
            bool need = NeedWater();
            if (need)
            {
                System.Console.WriteLine($"The {TypeOfTree.ToString()} {Name} needs water");
            }
            else
            {
                System.Console.WriteLine($"The {TypeOfTree.ToString()} {Name} doesn´t need water");
            }
        }

    }
}
