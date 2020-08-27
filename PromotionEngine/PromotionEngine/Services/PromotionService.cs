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

        public int GetPriceOfC(int countOfC)
        {
            return (countOfC * Constants.UnitPriceOfC);
        }

        public int GetPriceOfD(int countOfD)
        {
            return (countOfD * Constants.UnitPriceOfD);
        }

        public int GetPriceOfCandD(int countOfC, int countOfD)
        {
            var diff = 0;
            var sum = 0;
            if (countOfC >= countOfD)
            {
                diff = countOfC - countOfD;
                return (sum + countOfD * 30) + (diff * Constants.UnitPriceOfC);
            }
            else
            {
                diff = countOfD - countOfC;
                return (sum + countOfC * 30) + (diff * Constants.UnitPriceOfD);
            }
        }
    }
}
