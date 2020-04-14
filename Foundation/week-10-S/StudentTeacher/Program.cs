namespace StudentTeacher
{
    class Program
    {
        static void Main(string[] args)
        {
            var student1 = new Student("Petra");
            var teacher1 = new Teacher("Kolínková");

            student1.Qustion(teacher1);
            student1.Learn();
        }
    }
}
