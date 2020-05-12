using System.ComponentModel.DataAnnotations;

namespace Rascal.Entity
{
    public class MyChannel
    {
        [Key]
        public int Id { get; set; }
        public int IdFromApi { get; set; }
        public string Name { get; set; }
        public string Descripiton { get; set; }
        public string Admin { get; set; }
        public string Secret { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
