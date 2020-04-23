using Messageservice.Models;
using System.Collections.Generic;
using System.Linq;

namespace Messageservice.Services
{
    public class MessageProceeder
    {
        IEnumerable<IMessageService> messageService;

        public MessageProceeder(IEnumerable<IMessageService> messageService)
        {
            this.messageService = messageService;
        }

        public void SendMessage(Message message)
        {
            messageService.First(s => s.IsEnabled() == "True").Send(message);
        }
    }
}
