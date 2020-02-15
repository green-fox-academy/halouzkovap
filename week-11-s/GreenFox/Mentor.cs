using System;
using System.Linq;

namespace GreenFox
{
    class Mentor : Person
    {

        private string[] LevelA = new string[] { "junior", "intermediate", "senior" };
        string _Level = "junior";
        public string Level
        {
            get
            {
                return _Level;
            }
            set
            {
                if (!LevelA.Any(x => x == value))
                    throw new ArgumentException("Not valid gender");
                _Level = value;
            }
        }

        public Mentor() : base()
        {

            Level = "intermediate";
        }

        public Mentor(string name, int age, string gender, string level) : base(name, age, gender)
        {

            this.Level = level;
        }

        public override void Introduce()
        {
            Console.WriteLine($"Helo I´m {this.Name}, {this.Age} year old {this.Gender}, {this.Level} mentor");
        }

        public override void GetGoal()
        {
            Console.WriteLine("My goal is: Educate brilliant junior software developers.");
        }
    }
}
