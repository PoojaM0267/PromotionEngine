using FluentAssertions;
using Moq;
using PromotionEngine.IServices;
using PromotionEngine.Services;
using Xunit;

namespace PromotionEngineTest.ServiceTests
{
    public class CheckOutServiceTests
    {
        private Mock<IPromotionService> _promoMockService;

        public CheckOutServiceTests()
        {
            _promoMockService = new Mock<IPromotionService>();
        }

        [Fact]
        public void GetCheckOutPrice_Should_Return_TotalPrice()
        {
            var checkOutService = new CheckoutService(_promoMockService.Object);
            var input = "aaabbbcccddd";
            _promoMockService.Setup(p => p.GetPriceOfA(It.IsAny<int>())).Returns(130);
            _promoMockService.Setup(p => p.GetPriceOfB(It.IsAny<int>())).Returns(130);

            _promoMockService.Setup(p => p.GetPriceOfCandD(It.IsAny<int>(), It.IsAny<int>())).Returns(130);

            var result = checkOutService.GetCheckOutPrice(input);
            result.Should().Be(390);
        }
    }
}
