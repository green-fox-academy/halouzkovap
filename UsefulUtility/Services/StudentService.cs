using System.Collections.Generic;
using System.IO;

namespace UsefulUtility.Services
{
    public class StudentService : IStudentService
    {
        private readonly List<string> names;

        public StudentService()
        {
            names = new List<string> { "Sanyi", "Lilla", "John" };
        }

        public List<string> FindAll()
        {
            return names;
        }

        public void Save(string student)
        {
            names.Add(student);
        }

        public void SaveToTxt(string name)
        {
            // ## 💪 Optional (if you're on fire)
            // - Create an interface containing the same method definitions as the service
            // - Make the service implement that (the methods already done, so just add it)
            // - Create another implementation of the service where you store the names in `names.txt` instead of a list
            // - Use the file saving service for the application
            string path = @"stuents.txt";
            File.WriteAllText(path, name);
        }
    }
}
