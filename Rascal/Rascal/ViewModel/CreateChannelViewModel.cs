using System.ComponentModel.DataAnnotations;

namespace Rascal.ViewModel
{
    public class CreateChannelViewModel
    {
        [Required]
        public string Name { get; set; }
        [Required]

        public string Description { get; set; }
    }
}
