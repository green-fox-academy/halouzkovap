using Microsoft.AspNetCore.Mvc;
using Rascal.Entity;
using Rascal.Service;
using Rascal.Servise;
using Rascal.ViewModel;

namespace Rascal.Controllers
{
    public class UserController : Controller
    {

        private readonly RascalService rascalService;
        private readonly IRascalDbService rascalDb;

        public UserController(RascalService rascalService, IRascalDbService rascalDb)
        {
            this.rascalService = rascalService;
            this.rascalDb = rascalDb;
        }

        [HttpGet("Register")]

        public ActionResult Register()
        {
            return View();
        }
        [HttpPost("Register")]
        public IActionResult Register(RegisterViewModel registerViewModel)
        {
            if (ModelState.IsValid)
            {
                var user = rascalService.Register(registerViewModel);
                var NewUser = new User() { UserName = registerViewModel.Login };
                rascalDb.CreateUser(NewUser);
                return RedirectToAction("Index", "Home");
            }
            return RedirectToAction("Register");
        }

        [HttpGet("Login")]

        public ActionResult Login()
        {
            return View();
        }
        [HttpPost("Login")]
        public IActionResult Login(LoginViewModel loginViewModel)
        {
            if (ModelState.IsValid)
            {
                var apikey = rascalService.Login(loginViewModel);
                var users = rascalDb.FindUser(loginViewModel.Login);
                rascalDb.RemoveApiKey(users);
                users.UserApiKey = new UserApiKey() { apiKey = apikey.Result, UserId = users.Id };
                rascalDb.CreateApiKey(users);

                return RedirectToAction("Index", "Home");
            }

            return RedirectToAction("Login");

        }

        [HttpGet("Update")]
        public ActionResult Update()
        {
            return View();
        }
        [HttpPost("Update")]
        public IActionResult Update(UpdateUserViewModel updateUserViewModel)
        {

            var user = rascalService.Update(updateUserViewModel);
            return RedirectToAction("Index", "Home");
        }

    }
}