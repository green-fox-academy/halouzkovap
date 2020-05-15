namespace TodoLvl3.Entity
{
    public class Mentor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Specialization { get; set; }
        public Project Project { get; set; }
        public Mentor()
        {

        }
        public Mentor(string name, string eamil, string spec)
        {
            this.Name = name;
            this.Email = eamil;
            this.Specialization = spec;
        }
    }
}
