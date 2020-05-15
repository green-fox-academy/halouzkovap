using System;
using System.Collections.Generic;
using TodoLvl3.Entity;

namespace TodoLvl3.ViewModel
{
    public class CreateProjectViewModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public List<Entity.Task> Tasks { get; set; }
        public int ChoosenTask { get; set; }
        public List<Mentor> Mentors { get; set; }
        public int ChoosenMentor { get; set; }

        public CreateProjectViewModel()
        {
            Tasks = new List<Task>();
            Mentors = new List<Mentor>();
        }

    }
}
