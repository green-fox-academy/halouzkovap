using FoxClub.Models;
using FoxClub.Services;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace FoxClub.Controllers
{
    public class LoginController : Controller
    {
        private readonly IFoxServices foxServices;

        public LoginController(IFoxServices foxServices)
        {
            this.foxServices = foxServices;
        }

        [HttpGet]
        public ActionResult FoxLogin()
        {
            return View();
        }

        [HttpPost]
        public ActionResult FoxLogin([Bind] Fox Fox)
        {
            // username = anet  
            //var Foxes = new Fox();
            var allFoxex = foxServices.GetFoxes().FirstOrDefault();
            if (foxServices.GetFoxes().Any(u => u.Name == Fox.Name))
            {
                var userClaims = new List<Claim>()
                {
                new Claim(ClaimTypes.Name, Fox.Name),
                new Claim(ClaimTypes.Email, "anet@test.com"),
                 };

                var grandmaIdentity = new ClaimsIdentity(userClaims, "User Identity");

                var userPrincipal = new ClaimsPrincipal(new[] { grandmaIdentity });
                HttpContext.SignInAsync(userPrincipal);

                return RedirectToAction("List", "Home");
            }

            return RedirectToAction("Login", "Login");
        }

        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(Fox fox)
        {
            if (foxServices.CheckFox(fox))
            {
                foxServices.CreateFox(fox);
                return RedirectToAction("FoxLogin", "Login");
            }

            return RedirectToAction("LoginCheckOutNot", "Login");
        }

        public IActionResult LoginCheckOutNot()
        {
            ViewBag.CheckoutNotMessage = "Try another name";
            return View();
        }
    }
}