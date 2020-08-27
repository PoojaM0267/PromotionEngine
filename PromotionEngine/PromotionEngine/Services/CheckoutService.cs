﻿using PromotionEngine.IServices;
using System.Linq;

namespace PromotionEngine.Services
{
    public class CheckoutService : ICheckoutService
    {
        private readonly IPromotionService _promotionService;

        public CheckoutService(IPromotionService promotionService)
        {
            _promotionService = promotionService;
        }

        public int GetCheckOutPrice(string inputSkuIds)
        {
            var listOfSkuIds = inputSkuIds.ToLower().ToCharArray();
            var countOfA = listOfSkuIds.Count(character => character == 'a');
            var priceOfA = _promotionService.GetPriceOfA(countOfA);

            var countOfB = listOfSkuIds.Count(character => character == 'b');
            var priceOfB = _promotionService.GetPriceOfB(countOfB);




            return 0;
        }
    }
}
