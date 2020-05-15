using System;
using System.Collections.Generic;

namespace TodoLvl3.Entity
{
    public class Task
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsDone { get; set; }
        public bool IsUrgent { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime TimeToSolve { get; set; }
        public int AssignneId { get; set; }
        public Assignee Assignee { get; set; }
        public int ProjectId { get; set; }
        public Project Project { get; set; }
        public List<SubTask> SubTasks { get; set; }

        public Task()
        {

        }
        public Task(string name, string description, bool isDone, bool isUrgent, DateTime timetoSovle)
        {
            this.Name = name;
            this.Description = description;
            this.IsDone = isDone;
            this.IsUrgent = IsUrgent;
            this.TimeToSolve = timetoSovle;
        }
    }

}
