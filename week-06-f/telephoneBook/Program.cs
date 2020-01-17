using System;
using System.Collections.Generic;

namespace telephoneBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> phoneList = new Dictionary<string, string>();
            phoneList.Add("William A. Lathan", "405 - 709 - 1865");
            phoneList.Add("John K. Miller", "402 - 247 - 8568");
            phoneList.Add("Hortensia E. Foster", "606 - 481 - 6467");
            phoneList.Add("Amanda D. Newland", "319 - 243 - 5613");
            phoneList.Add("Brooke P. Askew ", "307 - 687 - 2982");

            //What is John K. Miller's phone number?
            Console.WriteLine("For \"John K. Miller\" is phone number {0}.", phoneList["John K. Miller"]);

            //Whose phone number is 307 - 687 - 2982 ?
            foreach (KeyValuePair<string, string> pair in phoneList)
            {
                if (pair.Value == "307 - 687 - 2982")
                {
                    Console.WriteLine("{0}", pair.Key);
                }
            }


            //Do we know Chris E.Myers' phone number?
            try
            {
                Console.WriteLine("For Chris E.Myers phone is {0}.",
                    phoneList["Chris E.Myers"]);
            }
            catch (KeyNotFoundException)
            {
                Console.WriteLine("For Chris E.Myers we havent phone");
            }

        }
    }
}
