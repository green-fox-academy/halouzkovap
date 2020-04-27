using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FoxClub.Models
{
    public class Fox
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public List<Trick> Tricks { get; set; }
        public List<Nutrition> Nutritions { get; set; }
    }
}
