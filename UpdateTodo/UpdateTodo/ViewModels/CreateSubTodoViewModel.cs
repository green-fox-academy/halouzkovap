using System;

namespace UpdateTodo.ViewModels
{
    public class CreateSubTodoViewModel
    {
        public string Description { get; set; }


        public string Title { get; set; }
        public bool IsUrgent { get; set; }
        public bool IsDone { get; set; }

        public DateTime DueDate { get; set; }

        public int TodoId { get; set; }
    }
}
