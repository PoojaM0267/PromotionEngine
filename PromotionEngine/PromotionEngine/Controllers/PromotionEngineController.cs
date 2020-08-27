using Microsoft.AspNetCore.Mvc;

namespace PromotionEngine.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PromotionEngineController : ControllerBase
    {
        [HttpGet("checkoutprice")]
        public ActionResult<int> CheckOutPrice(string inputSkuIds)
        {
            return Ok();
        }
    }
}