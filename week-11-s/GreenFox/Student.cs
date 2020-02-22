using System;

namespace GreenFox
{
    class Student : Person, ICloneable
    {


        private string previousOrganization;
        private int skippeddays;

        public Student() : base()
        {
            previousOrganization = "The School of Life";
            skippeddays = 0;

        }


        public Student(string name, int age, string gender, string previousOrganization) : base(name, age, gender)
        {
            this.previousOrganization = previousOrganization;
            this.skippeddays = 0;
        }

        public object Clone()
        {
            return new Student(this.Name, this.Age, this.Gender, this.previousOrganization);
        }

        public override void Introduce()
        {
            Console.WriteLine($"Helo I´m {this.Name}, {this.Age} year old {this.Gender}, from {this.previousOrganization} who skipped {this.skippeddays} days from the course already");
        }

        public override void GetGoal()
        {
            Console.WriteLine("My goal is: Be a junior software developer.");
        }

        public void SkipDays(int num)
        {
            skippeddays += num;
        }


    }
}
