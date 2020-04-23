using System.ComponentModel.DataAnnotations;

namespace FoxClub.Models
{
    public class Trick
    {
        public int Id { get; set; }
        [Required]
        public string NameTrick { get; set; }
        public Fox Fox { get; set; }
        public int FoxId { get; set; }
    }
}
