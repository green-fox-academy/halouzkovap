using System;
using System.Collections.Generic;

namespace SharpieSet
{
    class Program
    {
        static void Main(string[] args)
        {
            var sharpie1 = new Sharpie("Green", 5.030f);
            var sharpie2 = new Sharpie("Yellow", 7);



            var sharpieSet = new SharpieSet();
            sharpieSet.Add(sharpie1);
            sharpieSet.Add(sharpie2);

            // print out sharpie
            sharpieSet.PrintOutSharpie();
            sharpieSet.CountUsable();

            //use one sharpie
            sharpie1.Use();

            sharpieSet.RemoveTrash();

            sharpieSet.CountUsable();
            sharpieSet.PrintOutSharpie();

            Console.ReadLine();
        }
    }
    class Sharpie
    {
        public string Color { get; set; }
        public float Width { get; set; }
        public float InkAmount { get; set; }

        public Sharpie(string Color, float width)
        {
            InkAmount = 1;
        }

        public void Use()
        {
            InkAmount--;
        }
    }
    class SharpieSet
    {
        private List<Sharpie> sharpSet;

        public SharpieSet()
        {
            sharpSet = new List<Sharpie>();
        }
        public void Add(Sharpie sharpie)
        {
            sharpSet.Add(sharpie);
        }
        public void CountUsable()
        {
            int usable = 0;
            foreach (var item in sharpSet)
            {
                if (item.InkAmount > 0)
                {
                    usable++;
                }
            }
            System.Console.WriteLine("There is {0} usable sharpies", usable);
        }
        public void RemoveTrash()
        {
            for (int i = 0; i < sharpSet.Count; i++)
            {
                if (sharpSet[i].InkAmount == 0)
                {
                    sharpSet.RemoveAt(i);
                }

            }

        }
        public void PrintOutSharpie()
        {
            foreach (var item in sharpSet)
            {
                Console.WriteLine("Sharpie {0}", item.Color);
            }
        }
    }
}

