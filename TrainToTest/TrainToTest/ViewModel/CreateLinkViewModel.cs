using System.ComponentModel.DataAnnotations;

namespace TrainToTest.ViewModel
{
    public class CreateLinkViewModel
    {
        [Required]
        public string UrlAdress { get; set; }
        [Required]

        public string Alias { get; set; }
    }
}
