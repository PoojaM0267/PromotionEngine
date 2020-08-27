using FluentAssertions;
using PromotionEngine.Services;
using Xunit;

namespace PromotionEngineTest.ServiceTests
{
    public class PromotionServiceTests
    {
        [Fact]
        public void GetPriceOfA_Should_Return_Price_GreaterThan_Zero()
        {
            var promotionService = new PromotionService();
            var result = promotionService.GetPriceOfA(30);
            result.Should().Be(1300);
        }
    }
}
