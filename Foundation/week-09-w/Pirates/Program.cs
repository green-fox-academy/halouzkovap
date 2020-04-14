using System;

namespace Pirates
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Create 2 pirate, they can fight or dring rum.");
            Console.Write("First pirate: ");
            string pirate1 = Convert.ToString(Console.ReadLine());
            var pirate = new Pirate(pirate1);
            Console.Write("Second pirate: ");
            string pirate3 = Convert.ToString(Console.ReadLine());
            var pirate4 = new Pirate(pirate3);
            //pirate.PrintOutPirate();
            //pirate4.PrintOutPirate();

            //var ship1 = new Ship();
            //var ship2 = new Ship();

            //ship1.fillShip();
            //ship2.fillShip();

            //var piratek = new Pirate("Piratek");
            //// ship1.Add(piratek);

            //var piratek2 = new Pirate("Pirat");
            ////ship2.Add(piratek);
            //piratek.DrinkSomeRum();
            //piratek.Drawl(piratek2);
            //piratek.PrintOutPirate();
            //piratek2.PrintOutPirate();
            // ship1.printOut();
            Console.WriteLine();
            //ship2.printOut();

            Console.ReadLine();
        }
    }

}

