using Microsoft.AspNetCore.Mvc.Testing;
using System.Threading.Tasks;
using UpdateTodo;
using Xunit;

namespace XUnitTestProject1
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
    }
}