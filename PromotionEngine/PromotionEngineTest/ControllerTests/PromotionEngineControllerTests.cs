using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Moq;
using PromotionEngine.Controllers;
using PromotionEngine.IServices;
using System;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace PromotionEngineTest.ControllerTests
{
    public class PromotionEngineControllerTests : IDisposable
    {
        private Mock<ICheckoutService> _checkoutMockService;

        public PromotionEngineControllerTests()
        {
            _checkoutMockService = new Mock<ICheckoutService>();
        }

        public PromotionEngineController PromotionEngineController()
        {
            return new PromotionEngineController(_checkoutMockService.Object);
        }

        public PromotionEngineController CreatePromotionEngineController(ICheckoutService checkoutMockService)
        {
            return new PromotionEngineController(checkoutMockService);
        }

        [Fact]
        public async Task CheckOutPrice_Should_Return_TotalPrice_Greater_Than_Zero_For_Valid_Input()
        {
            var input = "aaabbbcccddd";
            
            _checkoutMockService.Setup(c => c.GetCheckOutPrice(It.IsAny<string>())).Returns(280);
            var promoController = PromotionEngineController();          

            var result = promoController.CheckOutPrice(input);
            ((ObjectResult)result.Result).StatusCode.Should().Be((int)HttpStatusCode.OK);
            ((ObjectResult)result.Result).Value.Should().Be(280);
        }

        [Fact]
        public async Task CheckOutPrice_Should_Return_BadRequest_For_EmptyStringInput()
        {
            var input = string.Empty;
            var promoController = PromotionEngineController();
            var result = promoController.CheckOutPrice(input);

            result.Result.Should().BeOfType<BadRequestResult>();
        }

        public void Dispose()
        {
            _checkoutMockService = null;
        }
    }
}
