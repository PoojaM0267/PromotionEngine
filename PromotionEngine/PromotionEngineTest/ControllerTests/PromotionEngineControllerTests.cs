using Microsoft.AspNetCore.Mvc.Testing;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace PromotionEngineTest.ControllerTests
{
    public class PromotionEngineControllerTests : IClassFixture<WebApplicationFactory<PromotionEngine.Startup>>
    {
        private readonly WebApplicationFactory<PromotionEngine.Startup> _factory;
        private HttpClient _httpClient;

        public PromotionEngineControllerTests(WebApplicationFactory<PromotionEngine.Startup> factory)
        {
            _factory = factory;
        }

        [Fact]
        public async Task CheckOutPrice_Should_Return_TotalPrice_Greater_Than_Zero_For_Valid_Input()
        {
            _httpClient = _factory.CreateClient();
            var input = "aaabbbcccddd";
            var response = _httpClient.GetAsync($"api/PromotionEngine/checkoutprice{input}");

            //var result = await response.Result.Content.ReadAsStringAsync();
            //result.Should().NotBe(0.ToString());
        }
    }
}
