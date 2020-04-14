using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list_introduction_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> name = new List<string>();
            name.Add("William");
            name.Add("Amanda");
            name.Add("John");

            name.Remove("Amanda");
            if (name.Count > 0)
            {
                
                Console.WriteLine("in the list are " + name.Count + " names");
            }
            else
            {
                Console.WriteLine("The list is empty");
            }



            foreach (var item in name)
            {
                Console.WriteLine("{0}.{1}",name.IndexOf(item)+1,item);
            }
        }
    }
}
