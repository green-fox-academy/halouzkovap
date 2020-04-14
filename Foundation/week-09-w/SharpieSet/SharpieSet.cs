using System;
using System.Collections.Generic;

namespace SharpieSet
{

    public class SharpieSet
    {
        private readonly List<Sharpie> sharpSet;

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
            var usable = 0;
            foreach (var item in sharpSet)
                if (item.InkAmount > 0)
                    usable++;
            Console.WriteLine("There is {0} usable sharpies", usable);
        }

        public void RemoveTrash()
        {
            for (var i = 0; i < sharpSet.Count; i++)
                if (sharpSet[i].InkAmount == 0)
                    sharpSet.RemoveAt(i);
        }

        public void PrintOutSharpie()
        {
            foreach (var item in sharpSet) Console.WriteLine("Sharpie {0}", item.Color);
        }
    }
}

