using System.Collections.Generic;
using System.ComponentModel;

namespace TodoList.Models
{
    public class User
    {
        public int Id { get; set; }
        [DisplayName("Assignee")]
        public string Name { get; set; }
        public List<Todo> Todos { get; set; }
    }
}
