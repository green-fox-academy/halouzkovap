using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UpdateTodo.Entitiy
{
    public class Todo
    {
        public int Id { get; set; }
        [Required]

        public string Description { get; set; }
        [Required]

        public string Title { get; set; }
        public bool IsUrgent { get; set; }
        public bool IsDone { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime CreateAt { get; set; }
        public DateTime DueDate { get; set; }
        public int AssigneeId { get; set; }
        public Assignee Assignee { get; set; }
        public List<SubTodo> SubTodos { get; set; }

    }
}
