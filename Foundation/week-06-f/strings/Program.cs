using System;

namespace strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Petra Halouzková ";
            Console.WriteLine("My name is '{0}'", name.Trim());
            Console.WriteLine("My name is '{0}'", name.Trim().ToUpper());
            Console.WriteLine("My name is '{0}'", name.Trim().ToLower());

            int indexOf = name.IndexOf(" ");

            string firstName = name.Substring(0, indexOf);
            string lastName = name.Substring(indexOf + 1);

            Console.WriteLine("First name is " + firstName);
            Console.WriteLine("Last name is " + lastName);

            string[] names = name.Split(" ");
            Console.WriteLine("First name "  + names[0]);
            Console.WriteLine("Last name " + names[1]);

            if(string.IsNullOrEmpty(" ".Trim())) //trim protože " "  by bylo ok
                Console.WriteLine("invalid message");

            if (string.IsNullOrWhiteSpace(" "))
                Console.WriteLine("invalid message");

            string ageString = "25";
            int age = Convert.ToInt32(ageString);
            Console.WriteLine(age);

            int old = 31;
            string oldMe = Convert.ToString(old);
            Console.WriteLine(oldMe);



        }
    }
}
