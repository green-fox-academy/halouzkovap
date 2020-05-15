using System.Collections.Generic;
using TodoLvl3.Entity;

namespace TodoLvl3.ViewModel
{
    public class EditProjectViewModel
    {
        public Project Project { get; set; }
        public List<Entity.Task> Tasks { get; set; }

        public List<Mentor> Mentors { get; set; }


        public EditProjectViewModel()
        {
            Tasks = new List<Entity.Task>();
            Mentors = new List<Mentor>();
        }
    }
}
