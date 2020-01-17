using System;

namespace append_a
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `animals`
            string[] animal = new string[] { "koal", "pand", "zebr" };
            //   with the following content: `["koal", "pand", "zebr"]`
            for (int i = 0; i < animal.Length; i++)
            {
                animal[i] = animal[i] + "a";
            }


            // - Add all elements an `"a"` at the end
            for (int i = 0; i < animal.Length; i++)
            {
                Console.WriteLine(animal[i]);

            }
           
            Console.ReadLine();
        }
    }
}
