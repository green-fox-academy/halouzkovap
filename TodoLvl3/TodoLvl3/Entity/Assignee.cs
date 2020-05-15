using System.Collections.Generic;

namespace TodoLvl3.Entity
{
    public class Assignee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public List<Task> Tasks { get; set; }
        public List<SubTask> SubTasks { get; set; }

        public Assignee()
        {

        }
        public Assignee(string name, string eamil)
        {
            this.Name = name;
            this.Email = eamil;
        }
    }
}
