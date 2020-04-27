using Microsoft.AspNetCore.Mvc;
using UsefulUtility.Models;
using UsefulUtility.Services;
using UsefulUtility.ViewModels;

namespace UsefulUtility.Controllers
{
    public class UsefulController : Controller
    {
        private readonly IUtilityService utilityService;
        private readonly IEmailValidator emailValidator;

        public UsefulController(IUtilityService utilityService, IEmailValidator emailValidator)
        {
            this.utilityService = utilityService;
            this.emailValidator = emailValidator;
        }
        public IActionResult Colored()
        {
            var color = utilityService.RandomColor();
            return View(new ColoredViewModel
            {
                Color = color
            });
        }

        public IActionResult Email()
        {
            return View();
        }
        [HttpPost]
        public IActionResult EmailChecked(Email email)
        {
            var color = emailValidator.Email(email);
            return View(new EmailViewModel
            {
                Email = email,
                Color = color
            });

        }
    }
}