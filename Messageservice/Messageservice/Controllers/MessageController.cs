using Messageservice.Models;
using Messageservice.Services;
using Microsoft.AspNetCore.Mvc;

namespace Messageservice.Controllers
{
    public class MessageController : Controller
    {
        private readonly MessageProceeder messageService;

        public MessageController(MessageProceeder messageService)
        {
            this.messageService = messageService;
        }
        public IActionResult Message()
        {

            return View();
        }
        [HttpPost]
        public IActionResult SendMessage(Message message)
        {
            messageService.SendMessage(message);

            return RedirectToAction("Message");
        }
    }
}