using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace simplereplace
{
    class Program
    {
        static void Main(string[] args)
        {
            string example = "In a dishwasher far far away";

            string example2 = example.Replace("dishwasher", "galaxy");

            // I would like to replace "dishwasher" with "galaxy" in this example, but it has a problem.
            // Please fix it for me!
            // Expected ouput: In a galaxy far far away

            Console.WriteLine(example);
            Console.WriteLine(example2);
            Console.WriteLine(example.Replace("dishwasher", "Galaxy"));
        }
    }
}
