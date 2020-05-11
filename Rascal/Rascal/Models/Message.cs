using System;

namespace Rascal.Models
{
    public class Message
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime Created { get; set; }
        public Author Author { get; set; }

    }
}
