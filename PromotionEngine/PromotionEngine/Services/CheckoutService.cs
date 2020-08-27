using PromotionEngine.IServices;
using System.Linq;

namespace PromotionEngine.Services
{
    public class CheckoutService : ICheckoutService
    {
        public int GetCheckOutPrice(string inputSkuIds)
        {
            var listOfSkuIds = inputSkuIds.ToLower().ToCharArray();
            var countOfA = listOfSkuIds.Count(character => character == 'a');



            return 0;
        }
    }
}
