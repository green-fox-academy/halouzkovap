using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace UpdateTodo.Entitiy
{
    public class SubTodo
    {
        public int Id { get; set; }
        public string Description { get; set; }


        public string Title { get; set; }
        public bool IsUrgent { get; set; }
        public bool IsDone { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime CreateAt { get; set; }
        public DateTime DueDate { get; set; }
        public int TodoId { get; set; }
        public Todo Todo { get; set; }
    }
}
