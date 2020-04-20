namespace MvcStart.Models
{
    public class Pirate
    {
        public string Name { get; set; }
        public string Type { get; set; }

        public Pirate(string name, string type)
        {
            Name = name;
            Type = type;
        }
    }
}
