using FoxClub.Models;
using FoxClub.Services;
using Microsoft.AspNetCore.Mvc;

namespace FoxClub.Controllers
{
    public class LoginController : Controller
    {
        private readonly IFoxServices foxServices;

        public LoginController(IFoxServices foxServices)
        {
            this.foxServices = foxServices;
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(Fox fox)
        {
            if (foxServices.CheckFox(fox))
            {
                foxServices.CreateFox(fox);
                return RedirectToAction("LoginCheckOutOk");

            }
            return RedirectToAction("LoginCheckOutNOT");
        }
        public IActionResult LoginCheckOutOk()
        {
            ViewBag.CheckoutOKMessage = "Thank you for your registration";
            return View();
        }
        public IActionResult LoginCheckOutNOT()
        {
            ViewBag.CheckoutNotMessage = "This name is already used, choose another one";
            return View();
        }
    }
}