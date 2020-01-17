using System;
using System.Collections.Generic;

namespace customerClass
{
   
    class Program
    {
        static void Main(string[] args)
        {
            Costumers costumers = new Costumers(1, "Petra");
            var order = new Order();
            costumers.Orders.Add(order);
            Console.WriteLine(costumers.Id);
            Console.WriteLine(costumers.Name);

        }
    }
}
