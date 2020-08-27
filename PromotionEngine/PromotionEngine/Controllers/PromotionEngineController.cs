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

        /// <summary>
        /// CheckOutPrice
        /// </summary>
        /// <param name="inputSkuIds"> Input should be in the format: (aaabbbbbcd ....) </param>
        /// <returns></returns>
        [HttpGet("checkoutprice")]
        public ActionResult<int> CheckOutPrice([FromQuery]string inputSkuIds)
        {
            if (!string.IsNullOrEmpty(inputSkuIds))
            {
                var result =  _checkoutService.GetCheckOutPrice(inputSkuIds);
                return Ok(result); ;
            }

            return BadRequest();            
        }        
    }
}