using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using UpdateTodo.Entitiy;

namespace UpdateTodo.ViewModels
{
    public class CreateTodoViewModel
    {
        [Required]

        public string Description { get; set; }
        [Required]

        public string Title { get; set; }
        [Required]

        public bool IsUrgent { get; set; } = false;
        [Required]

        public bool IsDone { get; set; } = false;

        [Required]
        public DateTime DueDate { get; set; } = DateTime.UtcNow;

        public List<Assignee> Assignees { get; set; }
        public int ChoosenId { get; set; }


    }
}
