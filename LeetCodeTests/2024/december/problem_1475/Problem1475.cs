namespace LeetCodeTests
{
    public class Problem1475
    {
        public int[] FinalPrices(int[] prices)
        {
            for (int i = 0; i < prices.Length; i++)
            {
                prices[i] -= GetDiscountValue(prices, i, i + 1);
            }
            return prices;
        }

        private int GetDiscountValue(int[] prices, int i, int j)
        {
            if (j >= prices.Length) return 0;

            if (prices[j] <= prices[i]) return prices[j];

            return GetDiscountValue(prices, i, j + 1);
        }
    }
}