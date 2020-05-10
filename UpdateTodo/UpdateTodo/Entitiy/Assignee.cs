using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace UpdateTodo.Entitiy
{
    public class Assignee
    {
        public int Id { get; set; }
        [Required]

        public string Name { get; set; }
        [Required]

        public string Email { get; set; }

        public List<Todo> Todos { get; set; }
        public int UserId { get; set; }
    }
}
