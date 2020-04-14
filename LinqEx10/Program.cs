using System.Collections.Generic;
using System.Linq;

namespace LinqEx10
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Exercise 10
            //Create a Fox class with 3 properties: name, type and color.

            //Fill a list with at least 5 foxes, it's up to you how you name/create them.

            var fox1 = new Fox("Pet", "junior", "green");
            var fox2 = new Fox("Pet", "pallida", "yellow");
            var fox3 = new Fox("Pet", "junior", "red");
            var fox4 = new Fox("Pet", "junior", "lila");
            var fox5 = new Fox("Kam", "pallida", "green");
            List<Fox> Foxes = new List<Fox>();
            Foxes.Add(fox1);
            Foxes.Add(fox2);
            Foxes.Add(fox3);
            Foxes.Add(fox4);
            Foxes.Add(fox5);

            //Write a LINQ Expression to find the foxes with green color.
            var greenOne = Foxes.FindAll(x => x.Color == "green").ToList();
            //Write a LINQ Expression to find the foxes with green color and pallida type.
            var greenAndPalidaOne = Foxes.FindAll(x => x.Color == "green" && x.Type == "pallida").ToList();
            foreach (var item in greenOne)
            {
                System.Console.WriteLine(item.Name);
            }
            foreach (var item in greenAndPalidaOne)
            {
                System.Console.WriteLine(item.Name);
            }



        }
    }

    class Fox
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Color { get; set; }


        public Fox(string name, string type, string color)
        {
            Name = name;
            Type = type;
            Color = color;

        }

    }
}
