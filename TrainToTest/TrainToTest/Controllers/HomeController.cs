using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TrainToTest.Enity;
using TrainToTest.Models;
using TrainToTest.Service;
using TrainToTest.ViewModel;

namespace TrainToTest.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUrlService urlService;

        public HomeController(IUrlService urlService)
        {
            this.urlService = urlService;
        }

        public IActionResult Index()
        {
            ViewData["Message"] = "";
            return View();
        }

        [HttpPost("saveLink")]
        public ActionResult saveLink(CreateLinkViewModel createLinkView)
        {
            if (ModelState.IsValid)
            {
                var urlA = urlService.FindAlias(createLinkView.Alias);
                if (urlA == null)
                {
                    var newUl = new UrlAliaser(createLinkView.UrlAdress, createLinkView.Alias);
                    urlService.CreateUrlObj(newUl);
                    ModelState.Clear();
                    ViewData["Message"] = $"Your URL alias is {newUl.Alias} your secret code is {newUl.SecretCode}.";
                    return View("Index");
                }
                else
                {
                    ViewData["Message"] = "Your alias is already in use!";
                    return View("Index");
                }
            }
            return View();
        }

        [HttpGet("a/{alias}")]
        public ActionResult a(string alias)
        {
            var alis = urlService.FindAlias(alias);
            if (alis != null)
            {
                alis.HitCount += 1;
                urlService.UpdateUrl(alis);
                return View(alis);
            }
            return BadRequest();
        }






















        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
