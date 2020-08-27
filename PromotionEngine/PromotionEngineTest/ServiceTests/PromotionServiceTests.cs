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

        [Fact]
        public void GetPriceOfB_Should_Return_Price_GreaterThan_Zero()
        {
            var promotionService = new PromotionService();
            var result = promotionService.GetPriceOfB(30);
            result.Should().Be(675);
        }

        [Fact]
        public void GetPriceOfCandD_Should_Return_Price_GreaterThan_Zero()
        {
            var promotionService = new PromotionService();

            var result = promotionService.GetPriceOfCandD(30, 30);

            result.Should().Be(900);
        }

        [Fact]
        public void GetPriceOfCandD_Should_Return_Price_As_1125()
        {
            var promotionService = new PromotionService();

            var result = promotionService.GetPriceOfCandD(30, 45);

            result.Should().Be(1125);
        }


        [Fact]
        public void GetPriceOfCandD_Should_Return_Price_As_1200()
        {
            var promotionService = new PromotionService();

            var result = promotionService.GetPriceOfCandD(45, 30);

            result.Should().Be(1200);
        }
    }
}
