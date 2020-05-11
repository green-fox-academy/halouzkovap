using Microsoft.AspNetCore.Mvc;
using Rascal.Models;
using Rascal.Service;
using Rascal.Servise;
using Rascal.ViewModel;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Rascal.Controllers
{
    public class HomeController : Controller
    {

        private readonly RascalService rascal;
        private readonly IRascalDbService rascalDb;

        public HomeController(RascalService rascal, IRascalDbService rascalDb)
        {
            this.rascal = rascal;
            this.rascalDb = rascalDb;
        }



        public IActionResult Index()
        {
            var getmodel = new GetMessageViewModel();
            var user = rascalDb.FindUser("Petra");
            var api = user.UserApiKey.apiKey;
            var result = rascal.GetMessage(getmodel, api).Result;
            return View(result);
        }


        [HttpGet("Message")]
        public IActionResult PostMessage()
        {

            return PartialView();
        }
        //Message/ [Post]
        [HttpPost("Message")]
        public async Task<ActionResult> PostMessage(CreateMessageViewModel createMessageViewModel)
        {
            await rascal.PostMessage(createMessageViewModel);
            return RedirectToAction("Index");
        }





























        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
