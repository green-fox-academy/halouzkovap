using System;
using System.Collections.Generic;

namespace GreenFox
{
    class Cohort
    {
        public string Name;
        public List<Student> Students;
        public List<Mentor> Mentors;

        public Cohort(string name)
        {
            Name = name;
            Students = new List<Student>();
            Mentors = new List<Mentor>();
        }

        public void AddStudent(Student student)
        {
            Students.Add(student);
        }

        public void AddMentor(Mentor mentor)
        {
            Mentors.Add(mentor);

        }

        public void Info()
        {
            Size();


        }

        private void Size()
        {
            Console.WriteLine($"We have students: {Students.Count}.");
            Console.WriteLine($"We have mentors: {Mentors.Count}.");

        }
    }
}
