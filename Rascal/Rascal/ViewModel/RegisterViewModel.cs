using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Rascal.ViewModel
{
    public class RegisterViewModel
    {
        [DisplayName("Username")]
        [Required]
        public string Login { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
