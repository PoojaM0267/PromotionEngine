using PromotionEngine.IServices;
using PromotionEngine.Utils;

namespace PromotionEngine.Services
{
    public class PromotionService : IPromotionService
    {
        public int GetPriceOfA(int countOfA)
        {
            return (countOfA / 3) * 130 + (countOfA % 3 * Constants.UnitPriceOfA);
        }

        public int GetPriceOfB(int countOfB)
        {
            return (countOfB / 2) * 45 + (countOfB % 2 * Constants.UnitPriceOfB);
        }
    }
}
