namespace PromotionEngine.IServices
{
    public interface IPromotionService
    {
        int GetPriceOfA(int countOfA);

        int GetPriceOfB(int countOfB);

        int GetPriceOfC(int countOfC);
        int GetPriceOfD(int countOfD);
        int GetPriceOfCandD(int countOfC, int countOfD);
    }
}
