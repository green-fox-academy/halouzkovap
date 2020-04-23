using Messageservice.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Diagnostics;

namespace Messageservice.Services
{
    public class EmailService : IMessageService
    {
        public EmailService(IConfiguration configuration)
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


            Debug.WriteLine($"Mail to {_configuration["mailSettings:mailToAddress"]}, with Message={message.TextMessage}");


        }
    }
}
