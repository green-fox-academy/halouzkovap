namespace GardenApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var rose = new Flowers(TypeOfRose.blue);
            var rose2 = new Flowers(TypeOfRose.blue);
            var tree = new Tree(TypeOfTree.orange);
            var tree2 = new Tree(TypeOfTree.orange);
            var garden = new Garden();

            garden.Add(rose);
            garden.Add(rose2);
            garden.Add(tree);
            garden.Add(tree2);
            garden.GardenInfo();
            System.Console.WriteLine();

            garden.FeedGarden(40);
            garden.GardenInfo();
            System.Console.WriteLine();


            garden.FeedGarden(70);
            garden.GardenInfo();
            System.Console.WriteLine();
        }
    }
}
