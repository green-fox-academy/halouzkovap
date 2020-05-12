using System;

namespace Rascal.Models
{
    public class ResponsePostMessage
    {
        public string Content { get; set; }
        public DateTime Created { get; set; }
        public Author Author { get; set; }
    }
}
