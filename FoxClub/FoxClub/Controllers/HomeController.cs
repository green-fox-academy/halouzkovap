using FoxClub.Models;
using FoxClub.Services;
using FoxClub.ViewModel;
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

        public IActionResult Index()
        {
            var foxes = foxServices.GetFoxes();
            return View(new FoxViewModel
            {
                Foxes = foxes
            });

        }
        public IActionResult Detail(int id)
        {
            var fox = foxServices.GetFox(id);
            return View(fox);
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
