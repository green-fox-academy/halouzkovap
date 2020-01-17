using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakesLonger2
{
    class Program
    {
        static void Main(string[] args)
        {
            string quote = "Hofstadter's Law: It you expect, even when you take into account Hofstadter's Law.";

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(quote);
            string value = "always takes longer than ";
            var it = quote.IndexOf("you") ;
            stringBuilder.Insert(it, value);

            // When saving this quote a disk error has occured. Please fix it.
            // Add "always takes longer than" to the StringBuilder (quote) between the words "It" and "you"
            // Using pieces of the quote variable (instead of just redefining the string)

            Console.WriteLine(stringBuilder);
        }
    }
}
