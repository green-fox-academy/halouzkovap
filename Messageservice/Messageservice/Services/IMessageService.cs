using Messageservice.Models;

namespace Messageservice.Services
{
    public interface IMessageService
    {
        string IsEnabled();
        void Send(Message message);
        // void Send(string textMessage);
    }
}
