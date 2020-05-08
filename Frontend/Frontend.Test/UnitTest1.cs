using Frontend.Models;
using Microsoft.AspNetCore.Mvc.Testing;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Frontend.Test
{
    public class UnitTest1 : IClassFixture<WebApplicationFactory<Startup>>
    {
        private readonly WebApplicationFactory<Startup> factory;

        public UnitTest1(WebApplicationFactory<Startup> factory)
        {
            this.factory = factory;
        }

        [Fact]
        public async Task MainPageLoadsSuccessfully()
        {
            var responseMessage = await factory.CreateClient().GetAsync("/");

            responseMessage.EnsureSuccessStatusCode();
        }

        [Theory]
        [InlineData(1, 2)]
        [InlineData(5, 10)]
        [InlineData(10, 20)]
        public async Task Doubling_RandomInput_Success(int input, int expect)
        {
            var responseMessage = await factory.CreateClient().GetAsync($"/doubling/{input}");
            var json = responseMessage.Content.ReadAsStringAsync().Result;
            var dictionary = JsonConvert.DeserializeObject<Dictionary<string, int>>(json);

            dictionary.TryGetValue("result", out int actual);
            Assert.Equal(expect, actual);

        }

        [Fact]
        public async Task Doubling_NullInput_BadRequest()
        {
            var responseMessage = await factory.CreateClient().GetAsync($"/doubling/{null}");
            Assert.Equal(HttpStatusCode.BadRequest, responseMessage.StatusCode);
        }

        [Theory]
        [InlineData("Petra", "Lady", "Oh, hi there Petra, my dear Lady!")]
        public async Task Greeting_InputNameAndTitel_Succes(string name, string title, string expected)
        {
            var responseMessage = await factory.CreateClient().GetAsync($"/greeter?name={name}&title={title}");
            var json = responseMessage.Content.ReadAsStringAsync().Result;
            var dictionary = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);

            dictionary.TryGetValue("welcome_message", out string actuall);
            Assert.Equal(expected, actuall);

        }

        [Fact]
        public async Task Greetin_NullNameAndTitul_BadRequest()
        {
            var responseMessage = await factory.CreateClient().GetAsync($"/greeter?name={null}&title={null}");
            Assert.Equal(HttpStatusCode.BadRequest, responseMessage.StatusCode);
        }
        [Fact]
        public async Task Greetin_NullNameAndInputTitul_BadRequest()
        {
            var responseMessage = await factory.CreateClient().GetAsync($"/greeter?name={null}&title=Lady");
            Assert.Equal(HttpStatusCode.BadRequest, responseMessage.StatusCode);
        }
        [Fact]
        public async Task Greetin_InputNameAndNullTitul_BadRequest()
        {
            var responseMessage = await factory.CreateClient().GetAsync($"/greeter?name=Petra&title={null}");
            Assert.Equal(HttpStatusCode.BadRequest, responseMessage.StatusCode);
        }

        //appenda/{appendable
        [Theory]
        [InlineData("Jahod", "Jahoda")]
        public async Task Appenda_Input_Succes(string appendable, string expected)
        {
            var responseMessage = await factory.CreateClient().GetAsync($"/appenda/{appendable}");
            var json = responseMessage.Content.ReadAsStringAsync().Result;
            Assert.Equal(expected, json);
        }

        [Fact]
        public async Task Appenda_NullInput_BadRequest()
        {
            var responseMessage = await factory.CreateClient().GetAsync($"/appenda/{null}");
            Assert.Equal(HttpStatusCode.BadRequest, responseMessage.StatusCode);
        }

        [Theory]
        [InlineData("sum", 5, 15)]
        [InlineData("factor", 5, 120)]
        public async Task DoUnitl_InputNotNull_Succes(string acion, int data, int expected)
        {
            var toSend = JsonConvert.SerializeObject(new JsonObject { Until = data });
            var httpContent = new StringContent(toSend, Encoding.UTF8, "application/json");
            var response = await factory.CreateClient().PostAsync($"/dountil/{acion}", httpContent);
            var json = response.Content.ReadAsStringAsync().Result;
            var dictionary = JsonConvert.DeserializeObject<Dictionary<string, int>>(json);
            dictionary.TryGetValue("result", out int actual);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public async Task DoUnitl_InputNull_BadRequest()
        {
            var toSend = JsonConvert.SerializeObject(new JsonObject(0));
            var httpContent = new StringContent(toSend, Encoding.UTF8, "application/json");

            var responseMessage = await factory.CreateClient().PostAsync($"/dountil/factor", httpContent);
            Assert.Equal(HttpStatusCode.BadRequest, responseMessage.StatusCode);
        }
    }
}
