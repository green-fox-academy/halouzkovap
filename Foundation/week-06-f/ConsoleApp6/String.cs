using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            string example = "Honey";
            string example2 = "honey";
            string substringOfExample = example.Substring(0, 2);
            string stringEmpty = string.Empty;
            string example3 = example.Replace("Ho", "Ko");

            Console.WriteLine(example3);

            string example4 = "Apple, pear, grapes, ananas";

            string[] fruit = example4.Split(',');

            foreach (var item in fruit)
            {
                Console.WriteLine(item);
            }

            string example5 = String.Join(',', fruit);

            Console.WriteLine(example5);


            if (string.IsNullOrEmpty(stringEmpty))
            {
                Console.WriteLine("is empty");
            }
            
            Console.WriteLine(substringOfExample);

            if (example.Equals(example2,StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine("ok");
            }

            for (int i = 0; i < example.Length; i++)
            {
                Console.WriteLine(example[i]);
            }

            //string instruction = "Go to your C:\\ drive ";
            //string instruction = "he sad \"go home\"";
            //string instruction = "i need \n new line";   //www.is.gd/escape_sequence

            string instruction = string.Format("{0}!", "Bonsai");
            Console.WriteLine(instruction);


            //string auto = string.Format("Make: {0} - Model:{1}", "Škoda", "Octavia");

            //string auto = string.Format("{0:C}", 123.45); prevod na měnu

            //string auto = string.Format("{0:N}", 123785);

            //string auto = string.Format("{0:P}", .123); // převod na procenta

            string auto = string.Format("Phone number {0:(###) ### ### ###}", 420732566528); //www.is.gd/string_format
            Console.WriteLine(auto);

            /*
            string myString = "";
            for (int i = 0; i < 100; i++)
            {
                myString += "--" + i.ToString();
               
            }
            */

            /*
            StringBuilder myString = new StringBuilder();
            for (int i = 0; i < 100; i++)
            {
                myString.Append("--");
                myString.Append(i);
            }
            Console.WriteLine(myString.ToString());
            */
            string myString = " Hello Word ";
            myString = String.Format("Lenght before:{0} after:{1}", myString.Length, myString.Trim().Length);
            Console.WriteLine(myString);





            Console.ReadLine();
        }
    }

}
