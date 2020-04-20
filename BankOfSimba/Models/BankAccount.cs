using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;

namespace BankOfSimba.Models
{
    public class BankAccount
    {
        [BindNever]
        public int Id { get; set; }


        [Required(ErrorMessage = "Please enter name")]
        [StringLength(100)]
        [Display(Name = "Name")]
        public string Name { get; set; }




        [Required(ErrorMessage = "Please enter balanc")]
        [Display(Name = "Balance")]
        public decimal Balance { get; set; }



        [Required(ErrorMessage = "Please enter your type")]
        [StringLength(100)]
        [Display(Name = "Kind of Animal")]
        public string AnimalType { get; set; }
    }
}
