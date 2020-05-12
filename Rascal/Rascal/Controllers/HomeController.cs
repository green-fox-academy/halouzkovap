﻿using Microsoft.AspNetCore.Mvc;
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
            var channels = rascalDb.FindChannel(id);
            var getmodel = new GetMessageViewModel();
            if (channels != null)
            {
                getmodel.ChannelId = channels.IdFromApi;
                getmodel.ChannelSecret = channels.Secret;
            }

            var result = rascal.GetMessage(getmodel, api).Result;

            return View(new DetailChannelViewModel() { ListMessages = result.Messages, Id = id });

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


            var channels = rascalDb.FindChannel(id);
            var createMessage = new CreateMessageViewModel() { Id = channels.IdFromApi, channelSecret = channels.Secret, Content = createMessageViewModel.Content };

            await rascal.PostMessage(createMessage, api);
            return RedirectToAction("Index", "Home");



            // await rascal.PostMessage(createMessageViewModel, api);
            //return RedirectToAction("Index");
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
        [HttpGet("MyChannels")]
        public IActionResult GetChannels()
        {
            var channels = rascalDb.GetMyChannels();
            return View(channels);
        }
        [HttpGet("ChannelDetail/{id}")]
        public IActionResult ChannelDetail(int id)
        {
            var channels = rascalDb.FindChannel(id);
            var getmessage = new GetMessageViewModel() { ChannelId = channels.IdFromApi, ChannelSecret = channels.Secret };
            var user = rascalDb.FindUser("Petra");
            var api = user.UserApiKey.apiKey;
            var list = rascal.GetMessage(getmessage, api).Result;
            return View(new DetailChannelViewModel() { ListMessages = list.Messages, Channel = channels });
        }






























        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
