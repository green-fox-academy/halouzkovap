using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> costumers = new List<string>();
            costumers.Add("Marry");
            costumers.Add("John");
            costumers.Add("Kenny");

            costumers.Insert(2, "Heather");

            foreach (var item in costumers)
            {
                Console.WriteLine(item);
            }

            

            Hashtable mTable = new Hashtable();
            mTable.Add(100, "Petra");
            mTable.Add(101, "Jane");
            mTable.Add(99, "John");

            foreach (var ID in mTable.Keys)
            {
                Console.WriteLine(ID);
            }

            foreach (var name in mTable.Values)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine(mTable[100]);

            if(mTable.Contains(99))
            {
                Console.WriteLine("yes");
            }

            Console.ReadLine();
        }
    }
}
