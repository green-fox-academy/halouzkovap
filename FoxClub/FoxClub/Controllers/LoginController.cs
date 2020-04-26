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
            if (Fox.Name == "Admin")
            {
                var userClaims = new List<Claim>()
                {
                new Claim(ClaimTypes.Name, Fox.Name),

                 };

                var grandmaIdentity = new ClaimsIdentity(userClaims, "Admin Identity");

                var userPrincipal = new ClaimsPrincipal(new[] { grandmaIdentity });
                HttpContext.SignInAsync(userPrincipal);
                return RedirectToAction("List", "Home");
            }


            var allFoxex = foxServices.GetFoxes().FirstOrDefault();
            if (foxServices.GetFoxes().Any(u => u.Name == Fox.Name))
            {
                var userClaims = new List<Claim>()
                {
                new Claim(ClaimTypes.Name, Fox.Name),

                 };

                var grandmaIdentity = new ClaimsIdentity(userClaims, "User Identity");

                var userPrincipal = new ClaimsPrincipal(new[] { grandmaIdentity });
                HttpContext.SignInAsync(userPrincipal);

                return RedirectToAction("Fox", "Home", allFoxex);
            }
            ViewBag.UserMessage = "You dont have accont yet. Please register yourself";
            return RedirectToAction("Register", "Login");
        }

        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(Fox fox)
        {
            if (foxServices.CheckFox(fox))
            {
                foxServices.CreateFox(fox);
                return RedirectToAction("FoxLogin", "Login");
            }

            return RedirectToAction("RegisterCheckOutNot", "Login");
        }

        public IActionResult RegisterCheckOutNot()
        {
            ViewBag.CheckoutNotMessage = "Try another name";
            return View();
        }
    }
}