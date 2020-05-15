using System;

namespace TodoLvl3.Entity
{
    public class SubTask
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
        public int TaksId { get; set; }
        public Task Task { get; set; }
        public SubTask()
        {

        }
        public SubTask(string name, string description, bool isDone, bool isUrgent, DateTime timetoSovle)
        {
            this.Name = name;
            this.Description = description;
            this.IsDone = isDone;
            this.IsUrgent = IsUrgent;
            this.TimeToSolve = timetoSovle;
        }
    }
}
