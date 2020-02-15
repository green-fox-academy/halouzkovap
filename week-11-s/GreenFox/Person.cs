using System;
using System.Linq;

namespace GreenFox
{
    class Person
    {

        protected string Name { get; set; }
        protected int Age;
        protected string[] AllowedG = new string[] { "male", "female" };
        string _Gender = "male";
        public string Gender
        {
            get
            {
                return _Gender;
            }
            set
            {
                if (!AllowedG.Any(x => x == value))
                    throw new ArgumentException("Not valid gender");
                _Gender = value;
            }
        }

        public Person()
        {
            Name = "Jane Doe";
            Age = 30;
            Gender = "female";

        }


        public Person(string name, int age, string gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }

        public virtual void Introduce()
        {
            Console.WriteLine($"Helo I´m {this.Name}, {this.Age} year old {this.Gender}");
        }

        public virtual void GetGoal()
        {
            Console.WriteLine("My goal is: Live for the moment.");
        }
    }
}
