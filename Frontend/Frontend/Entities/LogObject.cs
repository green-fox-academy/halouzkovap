using System;

namespace Frontend.Entities
{
    public class LogObject
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Endpoint { get; set; }
        public string Data { get; set; }
        public LogObject()
        {

        }
        public LogObject(string data, string endpoint)
        {
            this.Data = data;
            this.Endpoint = endpoint;
        }
    }
}
