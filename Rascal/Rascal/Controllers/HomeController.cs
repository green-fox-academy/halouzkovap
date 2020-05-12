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


        [HttpGet("Index")]
        public IActionResult Index()
        {
            var getmodel = new GetMessageViewModel();
            var user = rascalDb.FindUser("Petra");
            var api = user.UserApiKey.apiKey;
            var result = rascal.GetMessage(getmodel, api).Result;
            return View(result);
        }


        [HttpGet("PostMessage")]
        public IActionResult PostMessage()
        {
            return View();
        }
        //Message/ [Post]
        [HttpPost("PostMessage")]
        public async Task<ActionResult> PostMessage(CreateMessageViewModel createMessageViewModel)
        {
            var user = rascalDb.FindUser("Petra");
            var api = user.UserApiKey.apiKey;
            await rascal.PostMessage(createMessageViewModel, api);
            return RedirectToAction("Index");
        }

        [HttpGet("CreateChannel")]
        public IActionResult CreateChannel()
        {
            return View();
        }

        [HttpPost("CreateChannel")]
        public async Task<ActionResult> CreateChannel(CreateChannelViewModel createChannel)
        {
            if (ModelState.IsValid)
            {
                var user = rascalDb.FindUser("Petra");
                var api = user.UserApiKey.apiKey;
                var chanel = await rascal.CreateChannel(createChannel, api);
                //rascalDb.CreateChannel(chanel);
                return RedirectToAction("Index");
            }
            return View("CreateChannel");
        }






























        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
