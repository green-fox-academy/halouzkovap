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
        public ActionResult Fox()
        {
            var fox = foxServices.GetOnlyFoxes();
            return View(fox);
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
            return View(new DetailViewModel
            {
                Detail = fox
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
            var nameOfTrick = trick.NameTrick;
            foxServices.AddFoxTrick(id, nameOfTrick);
            return RedirectToAction("List");
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
            var food = nutrition.Food;
            foxServices.AddFoxTrick(id, food);
            return RedirectToAction("List");
        }




        [Authorize]
        public IActionResult ListOfTricksAndNutrition()
        {
            var trick = foxServices.GetTricks();
            var foxes = foxServices.GetNutritions();
            return View();


        }













        [Authorize]

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
