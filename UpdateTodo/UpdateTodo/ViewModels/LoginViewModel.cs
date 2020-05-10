using System.ComponentModel.DataAnnotations;

namespace UpdateTodo.ViewModels
{
    public class LoginViewModel
    {
        [Required]

        public string Username { get; set; }
        [DataType(DataType.Password)]
        [Required]

        public string Password { get; set; }
        public bool RememberLogin { get; set; }
        public string ReturnUrl { get; set; }
    }
}
