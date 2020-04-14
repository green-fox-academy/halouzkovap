using System;

namespace classes
{

    public class Person
    {
        public string Name;

        public void Interduce(string to)
        {
            Console.WriteLine("Hi {0}, I´m {1} ", to, Name);
        }

        public static Person Parse(string str)
        {
            Person person = new Person();
            person.Name = str;
            return person;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var p = Person.Parse("Petra");
            Console.WriteLine("tell me your name");
            var to = Console.ReadLine();
            p.Interduce(to);


        }
    }
}
