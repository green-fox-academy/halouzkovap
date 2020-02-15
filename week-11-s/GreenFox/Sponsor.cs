using System;

namespace GreenFox
{
    class Sponsor : Person
    {

        private string company;
        private int hireStudents;

        public Sponsor() : base()
        {

            company = "Google";
            hireStudents = 0;
        }

        public Sponsor(string name, int age, string gender, string company) : base(name, age, gender)
        {

            this.company = company;
            this.hireStudents = 0;
        }

        public override void Introduce()
        {
            Console.WriteLine($"Helo I´m {this.Name}, {this.Age} year old {this.Gender} who represent {this.company} and hired {this.hireStudents} students so far");
        }

        public void Hire()
        {
            hireStudents++;
        }

        public override void GetGoal()
        {
            Console.WriteLine("My goal is: Hire brilliant junior software developers.");
        }
    }
}
