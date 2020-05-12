using Newtonsoft.Json;
using Rascal.Models;
using Rascal.ViewModel;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Rascal.Servise
{
    public class RascalService
    {

        //Api/User/register[Post]
        public async Task<UserFromApi> Register(RegisterViewModel registerViewModel)
        {
            var client = new HttpClient();
            var httpContent = new StringContent(JsonConvert.SerializeObject(registerViewModel), Encoding.UTF8, "application/json");
            var response = await client.PostAsync(Environment.GetEnvironmentVariable("urlBase") + "api/user/register", httpContent);

            var json = response.Content.ReadAsStringAsync().Result;
            var responseM = JsonConvert.DeserializeObject<UserFromApi>(json);


            return responseM;
        }

        public async Task<string> Login(LoginViewModel loginViewModel)
        {
            var client = new HttpClient();
            var httpContent = new StringContent(JsonConvert.SerializeObject(loginViewModel), Encoding.UTF8, "application/json");
            var response = await client.PostAsync(Environment.GetEnvironmentVariable("urlBase") + "api/user/login", httpContent);

            var json = response.Content.ReadAsStringAsync().Result;
            var responseM = JsonConvert.DeserializeObject<ResponseLogin>(json);



            return responseM.ApiKey;
        }

        public async Task<string> Update(UpdateUserViewModel updateUserViewModel, string apiKey)
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Add("apiKey", apiKey);
            var httpContent = new StringContent(JsonConvert.SerializeObject(updateUserViewModel), Encoding.UTF8, "application/json");
            var response = await client.PostAsync(Environment.GetEnvironmentVariable("urlBase") + "api/user/update", httpContent);

            var json = response.Content.ReadAsStringAsync().Result;
            var responseM = JsonConvert.DeserializeObject<UserFromApi>(json);

            return responseM.UserName;

        }

        public async Task<bool> Logout()
        {
            var client = new HttpClient();
            var httpContent = new StringContent("application/json");
            var response = await client.PostAsync(Environment.GetEnvironmentVariable("urlBase") + "api/user/logout", httpContent);
            var json = response.Content.ReadAsStringAsync().Result;
            var responseM = JsonConvert.DeserializeObject<bool>(json);
            return responseM;
        }

        public async Task<MessageViewModel> GetMessage(GetMessageViewModel getMessageViewModel, string apiKey)
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Add("apiKey", apiKey);

            if (getMessageViewModel.ChannelId != 0)
            {
                var Content = new StringContent(JsonConvert.SerializeObject(new { channelId = getMessageViewModel.ChannelId, count = getMessageViewModel.Count, channelSecret = getMessageViewModel.ChannelSecret }), Encoding.UTF8, "application/json");
                var responseC = await client.PostAsync(Environment.GetEnvironmentVariable("urlBase") + "api/channel/get-messages", Content);
                var jsonC = responseC.Content.ReadAsStringAsync().Result;

                var listC = JsonConvert.DeserializeObject<ResponseMessage>(jsonC);
                var resut = new MessageViewModel() { Messages = listC.Messages };
                return resut;
            }

            var httpContent = new StringContent(JsonConvert.SerializeObject(new { count = getMessageViewModel.Count, channelSecret = getMessageViewModel.ChannelSecret }), Encoding.UTF8, "application/json");
            var response = await client.PostAsync(Environment.GetEnvironmentVariable("urlBase") + "api/channel/get-messages", httpContent);
            var json = response.Content.ReadAsStringAsync().Result;

            var list = JsonConvert.DeserializeObject<ResponseMessage>(json);
            var result = new MessageViewModel() { Messages = list.Messages };
            return result;
        }

        public async Task<ResponsePostMessage> PostMessage(CreateMessageViewModel createMessageViewModel, string apikey)
        {
            var client = new HttpClient();
            var httpContent = new StringContent(JsonConvert.SerializeObject(new { channelId = createMessageViewModel.Id, channelSecret = createMessageViewModel.channelSecret, content = createMessageViewModel.Content }), Encoding.UTF8, "application/json");
            client.DefaultRequestHeaders.Add("apiKey", apikey);
            var response = await client.PostAsync(Environment.GetEnvironmentVariable("urlBase") + "api/message", httpContent);
            var json = response.Content.ReadAsStringAsync().Result;
            var responseMessage = JsonConvert.DeserializeObject<ResponsePostMessage>(json);

            return responseMessage;
        }

        public async Task<Chanel> CreateChannel(CreateChannelViewModel channelViewModel, string apiKey)
        {
            var client = new HttpClient();
            var httpContent = new StringContent(JsonConvert.SerializeObject(channelViewModel), Encoding.UTF8, "application/json");
            client.DefaultRequestHeaders.Add("apiKey", apiKey);
            var response = await client.PostAsync(Environment.GetEnvironmentVariable("urlBase") + "api/channel", httpContent);
            var json = response.Content.ReadAsStringAsync().Result;
            var responseMessage = JsonConvert.DeserializeObject<Chanel>(json);

            return responseMessage;
        }



    }
}

