namespace StudentTeacher
{
    public class Teacher
    {
        public string Name { get; set; }

        public Teacher(string name)
        {
            Name = name;
        }

        public void Teach(Student student)
        {
            student.Learn();
        }
        public void Answer()
        {
            System.Console.WriteLine("the teacher is answering a question");
        }
        //        Teach(student) -> calls the students learn method
        //Answer() -> prints the teacher is answering a question
    }
}
