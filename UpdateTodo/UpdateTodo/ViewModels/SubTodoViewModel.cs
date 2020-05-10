using System;

namespace UpdateTodo.ViewModels
{
    public class SubTodoViewModel
    {
        public string Description { get; set; }


        public string Title { get; set; }
        public bool IsUrgent { get; set; }


        public DateTime DueDate { get; set; } = DateTime.UtcNow;
        public int TodoId { get; set; }
    }
}
