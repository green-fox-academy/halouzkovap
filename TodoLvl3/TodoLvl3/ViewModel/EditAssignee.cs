using System.ComponentModel.DataAnnotations;

namespace TodoLvl3.ViewModel
{
    public class EditAssignee
    {
        [Required]
        public string Name { get; set; }
        [Required]
        [DataType("Email")]
        public string Email { get; set; }

    }
}
