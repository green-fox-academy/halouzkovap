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

            var httpContent = new StringContent(JsonConvert.SerializeObject(new { count = getMessageViewModel.Count }), Encoding.UTF8, "application/json");
            var response = await client.PostAsync(Environment.GetEnvironmentVariable("urlBase") + "api/channel/get-messages", httpContent);
            var json = response.Content.ReadAsStringAsync().Result;

            var list = JsonConvert.DeserializeObject<ResponseMessage>(json);
            var result = new MessageViewModel() { Messages = list.Messages };
            return result;
        }

        public async Task<ResponsePostMessage> PostMessage(CreateMessageViewModel createMessageViewModel, string apikey)
        {
            var client = new HttpClient();
            var httpContent = new StringContent(JsonConvert.SerializeObject(new { content = createMessageViewModel.Chanel.Content }), Encoding.UTF8, "application/json");
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

        //Channel/ [Post]
        //Channel/user-channels [Get]
        //Channel/get-messagge [Post]

        //public List<Message> GetMessages()
        //{
        //    try
        //    {
        //        using (WebClient webClient = new WebClient())
        //        {
        //            webClient.BaseAddress = RascalService.EndPoint;
        //            var json = webClient.DownloadString("channel/get-messages");
        //            var list = JsonConvert.DeserializeObject<List<Message>>(json);
        //            return list.ToList();
        //        }
        //    }
        //    catch (WebException ex)
        //    {
        //        throw ex;
        //    }
        //}

        //public Message GetMessageForChannel(Chanel chanel)
        //{
        //    var result = new Message();
        //    try
        //    {
        //        using (WebClient webClient = new WebClient())
        //        {
        //            webClient.BaseAddress = RascalService.EndPoint;
        //            var url = "channel/get-messages";
        //            webClient.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");
        //            webClient.Headers[HttpRequestHeader.ContentType] = "application/json";
        //            string data = Newtonsoft.Json.JsonConvert.SerializeObject(chanel);
        //            var response = webClient.UploadString(url, data);
        //            result = JsonConvert.DeserializeObject<Message>(response);
        //            return result;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}



    }
}

