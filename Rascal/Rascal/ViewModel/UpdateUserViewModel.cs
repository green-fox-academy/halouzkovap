using System.ComponentModel.DataAnnotations;

namespace Rascal.ViewModel
{
    public class UpdateUserViewModel
    {
        [Required]

        public string Username { get; set; }
        [Required]

        public string avatarurl { get; set; }
    }
}
