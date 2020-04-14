using System;

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



}

