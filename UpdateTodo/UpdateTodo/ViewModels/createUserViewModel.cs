using System.ComponentModel.DataAnnotations;

namespace UpdateTodo.ViewModels
{
    public class CreateUserViewModel
    {
        [Required]
        public string Name { get; set; }
        [Required]

        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}
