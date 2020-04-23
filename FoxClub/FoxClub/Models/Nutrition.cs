using System.ComponentModel.DataAnnotations;

namespace FoxClub.Models
{
    public class Nutrition
    {
        public int Id { get; set; }
        [Required]
        public string Food { get; set; }
        public Fox Fox { get; set; }
    }
}
