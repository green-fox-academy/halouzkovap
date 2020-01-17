using System;

namespace encapsulation
{
    public class Person
    {
        private DateTime _birth;
        public void SetBirthdate(DateTime birthdate)
        {
            _birth = birthdate;
        }
        public DateTime GetBirthdate()
        {
            return _birth;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.SetBirthdate(new DateTime(1987,06,27));
            Console.WriteLine(person.GetBirthdate());
        }
    }
}
