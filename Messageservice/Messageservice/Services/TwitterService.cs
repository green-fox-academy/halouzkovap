using Messageservice.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Diagnostics;

namespace Messageservice.Services
{
    public class TwitterService : IMessageService
    {
        public TwitterService(IConfiguration configuration)
        {
            _configuration = configuration ??
                throw new ArgumentNullException(nameof(configuration));

        }

        private readonly IConfiguration _configuration;

        public string IsEnabled()
        {
            return _configuration["mailSettings:IsAvailabel"];
        }

        public void Send(Message message)
        {


            Debug.WriteLine($"Mail to {_configuration["twitterSettings:twittFrom"]}, with Message={message.TextMessage}");


        }

    }
}
