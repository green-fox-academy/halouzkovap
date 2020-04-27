using System.Collections.Generic;

namespace UsefulUtility.Services
{
    public interface IStudentService
    {


        public List<string> FindAll();



        public void Save(string student);

        public void SaveToTxt(string name);
    }
}
