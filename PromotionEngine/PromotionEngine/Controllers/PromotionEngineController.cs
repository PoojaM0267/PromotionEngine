using Microsoft.AspNetCore.Mvc;
using PromotionEngine.IServices;

namespace PromotionEngine.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PromotionEngineController : ControllerBase
    {
        private readonly ICheckoutService _checkoutService;

        public PromotionEngineController(ICheckoutService checkoutService)
        {
            _checkoutService = checkoutService;
        }

        [HttpGet("checkoutprice")]
        public ActionResult<int> CheckOutPrice(string inputSkuIds)
        {
            return Ok();
        }        
    }
}