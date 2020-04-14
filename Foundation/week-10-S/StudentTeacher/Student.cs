using System;

namespace StudentTeacher
{
    public class Student
    {
        public string Name { get; set; }
        public Student(string name)
        {
            this.Name = name;
        }

        public void Learn()
        {
            Console.WriteLine("student is learning something new");
        }
        public void Qustion(Teacher teacher)
        {

            teacher.Answer();
        }
    }

}
