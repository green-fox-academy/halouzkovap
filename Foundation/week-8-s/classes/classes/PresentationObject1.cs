using System;

namespace classes
{

    public class PresentationObject
    {

        public int Weight { get; set; }
        public int Height { get; set; }
        public void Copy()
        {
            Console.WriteLine("Object was copied");
        }

        public void Duplicate()
        {
            Console.WriteLine("Object was duplicate");
        }
    }
}

