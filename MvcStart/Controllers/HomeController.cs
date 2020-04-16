using Microsoft.AspNetCore.Mvc;
using MvcStart.Models;

namespace MvcStart.Controllers
{

    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            var pirate = new Pirate("Petra", "Captain");
            return View(pirate);
        }
    }
}