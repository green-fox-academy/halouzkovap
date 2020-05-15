using System;
using System.Collections.Generic;

namespace TodoLvl3.Entity
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public int MentorId { get; set; }
        public Mentor Mentor { get; set; }
        public List<Entity.Task> Tasks { get; set; }
        public Project(string name, string description, DateTime duedata)
        {
            this.Name = name;
            this.Description = description;
            this.DueDate = duedata;
        }
        public Project(string name, string description, DateTime duedata, Mentor mentor, List<Entity.Task> tasks)
        {
            this.Name = name;
            this.Description = description;
            this.DueDate = duedata;
            this.Mentor = mentor;
            this.Tasks = tasks;
        }
        public Project()
        {

        }
    }
}
