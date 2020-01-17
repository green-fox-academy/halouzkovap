using System;
using System.Collections.Generic;
using System.Text;

namespace customerClass
{
    class Costumers
    {
        public int Id;
        public string Name;
        public List<Order> Orders;

        public Costumers()
        {
            Orders = new List<Order>();  // always have to initialize empty list
                
        }

        public Costumers(int id)
            : this()
        {
            this.Id = id;
        }
        public Costumers(int id, string name)
            :this()
        {
            this.Name = name;
            this.Id = id;
        }
    }
}
