using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            customer Costumer1 = new customer()
            {
                ID = 101,
                Name = "Johne Doe",
                Salary = 8000
            };
            customer Costumer2 = new customer()
            {
                ID = 102,
                Name = "Dita Doe",
                Salary = 9000
            };
            customer Costumer3 = new customer()
            {
                ID = 201,
                Name = "Petra Doe",
                Salary = 8999
            };
            Dictionary<int, customer> custormerDictionary = new Dictionary<int, customer>();
            custormerDictionary.Add(Costumer1.ID, Costumer1);
            custormerDictionary.Add(Costumer2.ID, Costumer2);
            custormerDictionary.Add(Costumer3.ID, Costumer3);

            customer Costurmer201 = custormerDictionary[201];
            foreach(KeyValuePair<int,customer> costumerValueKey in custormerDictionary)
            {
                Console.WriteLine("costumer ID {0}", costumerValueKey.Key);
                customer cust = costumerValueKey.Value;
                Console.WriteLine("id:{0}, name:{1}, salary:{2}", cust.ID, cust.Name, cust.Salary);
                Console.WriteLine("--------------------------");
            }
        }
    }
    
    public class customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
    

}
