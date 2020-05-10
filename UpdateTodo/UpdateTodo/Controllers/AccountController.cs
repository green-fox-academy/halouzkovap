using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using UpdateTodo.Entitiy;
using UpdateTodo.Services;
using UpdateTodo.ViewModels;

namespace UpdateTodo.Controllers
{
    public class AccountController : Controller
    {
        private readonly ITodoServise todoServise;

        public AccountController(ITodoServise todoServise)
        {
            this.todoServise = todoServise;
        }


        public ActionResult Register()
        {
            var model = new CreateUserViewModel();
            return View(model);
        }
        [HttpPost]
        public IActionResult Register([Bind]CreateUserViewModel createUserViewModel)
        {
            if (ModelState.IsValid)
            {
                var assigne = new Assignee()
                {
                    Name = createUserViewModel.Name,
                    Email = createUserViewModel.Email,
                };
                var user = new User()
                {
                    Name = createUserViewModel.Name,
                    Password = createUserViewModel.Password,
                    Email = createUserViewModel.Email,
                    assignee = assigne
                };

                todoServise.CreateUser(user);

                return RedirectToAction("Login");
            }

            ModelState.Clear();
            return RedirectToAction("RegisterCheckOutNot", "Login");
        }

        public IActionResult RegisterCheckOutNot()
        {
            ViewBag.CheckoutNotMessage = "Try another name";
            return View();
        }

        [AllowAnonymous]
        public IActionResult Login(string returnUrl = "/")
        {
            return View(new LoginViewModel { ReturnUrl = returnUrl });
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            var user = todoServise.GetByUsernameAndPassword(model.Username, model.Password);
            if (user == null)
                return Unauthorized();

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                new Claim(ClaimTypes.Name, user.Name),
            };

            var identity = new ClaimsIdentity(claims,
                CookieAuthenticationDefaults.AuthenticationScheme);
            var principal = new ClaimsPrincipal(identity);

            await HttpContext.SignInAsync(
                CookieAuthenticationDefaults.AuthenticationScheme,
                principal,
                new AuthenticationProperties { IsPersistent = model.RememberLogin });

            return RedirectToAction("Index", "Todo");
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return Redirect("/");
        }
    }
}