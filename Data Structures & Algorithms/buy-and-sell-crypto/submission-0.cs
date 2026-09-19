public class Solution {
    public int MaxProfit(int[] prices) {
        int profit = 0;
        if (prices != null && prices.Length > 1){
            int bestPriceToBuy = prices[0];

            for (int i=1; i<prices.Length; i++){
                profit = Math.Max(profit, prices[i]-bestPriceToBuy);
                bestPriceToBuy = Math.Min(bestPriceToBuy, prices[i]);
            }
        }
        return profit;
    }
}
