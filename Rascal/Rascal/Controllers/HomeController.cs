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


        [HttpGet("Index/{id?}")]
        public IActionResult Index(int id)
        {
            var user = rascalDb.FindUser("Petra");
            var api = user.UserApiKey.apiKey;
            var getChannel = rascalDb.FindChannel(id);
            var getmodel = new GetMessageViewModel();
            if (getChannel != null)
            {
                getmodel.ChannelId = getChannel.IdFromApi;
                getmodel.ChannelSecret = getChannel.Secret;
            }
            var channelFromDb = rascalDb.GetMyChannels();
            var result = rascal.GetMessage(getmodel, api).Result;

            return View(new DetailChannelViewModel()
            {
                ListMessages = result.Messages,
                Id = id,
                ChannelsDb = channelFromDb
            });

        }



        [HttpGet("PostMessage/{id?}")]
        public IActionResult PostMessage()
        {
            return View();
        }
        //Message/ [Post]
        [HttpPost("PostMessage/{id?}")]
        public async Task<ActionResult> PostMessage(int id, CreateMessageViewModel createMessageViewModel)
        {
            var user = rascalDb.FindUser("Petra");
            var api = user.UserApiKey.apiKey;
            if (id != 0)
            {
                var channels = rascalDb.FindChannel(id);
                var createMessage = new CreateMessageViewModel()
                {
                    Id = channels.IdFromApi,
                    channelSecret = channels.Secret,
                    Content = createMessageViewModel.Content
                };

                await rascal.PostMessage(createMessage, api);
                return RedirectToAction("Index", "Home", channels);

            }

            return RedirectToAction("Index", "Home");
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
                var myChannel = new Rascal.Entity.MyChannel()
                {
                    Admin = chanel.Admin,
                    Name = chanel.Name,
                    Descripiton = chanel.Description,
                    Secret = chanel.Secret,
                    IdFromApi = chanel.Id,
                    User = user
                };
                rascalDb.CreateChannel(myChannel);
                return RedirectToAction("Index");
            }
            return View("CreateChannel");
        }

        [HttpGet("UpdateChannel/{id}")]
        public IActionResult UpdateChannel(int id)
        {
            var channel = rascalDb.FindChannel(id);
            var UpdateChannel = new UpdateChannelViewModel()
            {
                Name = channel.Name,
                Id = channel.IdFromApi,
                Description = channel.Descripiton,
                IconUrl = channel.IconUrl
            };
            return View(UpdateChannel);
        }


        [HttpPost("UpdateChannel/{id}")]
        public async Task<ActionResult> UpdateChannel(UpdateChannelViewModel updateChannel)
        {
            var user = rascalDb.FindUser("Petra");
            var api = user.UserApiKey.apiKey;
            var responseChannel = await rascal.UpdateChanel(updateChannel, api);
            rascalDb.UpdateChannel(responseChannel);
            return RedirectToAction("Index", "Home");
        }




























        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
