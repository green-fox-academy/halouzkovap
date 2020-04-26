using FoxClub.Models;

using FoxClub.Services;
using FoxClub.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace FoxClub.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IFoxServices foxServices;

        public HomeController(ILogger<HomeController> logger, IFoxServices foxServices)
        {
            _logger = logger;
            this.foxServices = foxServices;
        }


        [Authorize]
        public IActionResult Index()
        {
            return View();
        }


        [Authorize]
        public IActionResult List()
        {
            var foxes = foxServices.GetFoxes();
            return View(new FoxViewModel
            {
                Foxes = foxes
            });

        }

        [Authorize]
        public IActionResult Detail(int id)
        {
            var fox = foxServices.GetFox(id);
            return RedirectToAction("Fox", fox);
        }
        [Authorize]
        public IActionResult Fox(Fox fox)
        {

            var ida = fox.Id;
            var foxes = foxServices.GetFox(ida);
            var numOfTrick = foxes.Tricks.Count;
            var numOfNutritions = foxes.Nutritions.Count;
            if (numOfTrick > 0)
            {
                ViewBag.UserMessage = "You know no tricks, yet. Go and Learn some.";
            }
            if (numOfNutritions > 0)
            {
                ViewBag.UserMessage2 = "This Fox currently living on salad and water.";
            }
            return View(new DetailViewModel
            {
                FoxDetail = foxes
            });
        }

        [Authorize]
        public IActionResult AddTrick(int id)
        {
            return View();
        }

        [HttpPost]
        [Authorize]
        public IActionResult AddTrick(Trick trick)
        {
            var id = trick.Id;
            var fox = foxServices.GetFox(id);
            var nameOfTrick = trick.NameTrick;
            foxServices.AddFoxTrick(id, nameOfTrick);
            return RedirectToAction("Fox", fox);
        }

        [Authorize]
        public IActionResult AddNutrition(int id)
        {
            return View();
        }

        [HttpPost]
        [Authorize]
        public IActionResult AddNutrition(Nutrition nutrition)
        {
            var id = nutrition.Id;
            var fox = foxServices.GetFox(id);
            var food = nutrition.Food;
            foxServices.AddFoxTrick(id, food);
            return RedirectToAction("Fox", fox);

        }




        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
