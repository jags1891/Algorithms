using System;

namespace AlgorithmsLibrary.DP
{
    /// <summary> 
    /// Leet code problem
    /// </summary>
    public class MaxProfit
    {
        /// <summary>
        /// Get Max profit
        /// 
        /// Best Time to Buy and Sell Stock
        /// Say you have an array for which the ith element is the price of a given stock on day i.
        /// If you were only permitted to complete at most one transaction(i.e., buy one and sell one share of the stock), design an algorithm to find the maximum profit.
        /// 
        /// Note that you cannot sell a stock before you buy one.
        /// 
        /// Example 1:
        /// Input: [7,1,5,3,6,4]
        /// Output: 5
        /// Explanation: Buy on day 2 (price = 1) and sell on day 5 (price = 6), profit = 6-1 = 5.
        ///              Not 7-1 = 6, as selling price needs to be larger than buying price.
        /// 
        /// Example 2:
        /// Input: [7,6,4,3,1]
        /// Output: 0
        /// Explanation: In this case, no transaction is done, i.e. max profit = 0.
        /// 
        /// </summary>
        /// <param name="prices"></param>
        /// <returns></returns>
        public int GetMaxProfit(int[] prices)
        {
            int minprice = Int32.MaxValue;
            int maxprofit = 0;
            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] < minprice)
                    minprice = prices[i];
                else if (prices[i] - minprice > maxprofit)
                    maxprofit = prices[i] - minprice;
            }

            return maxprofit;
        }


        /// <summary>
        /// Find maximum sum for non adjacent elements.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int HouseRob(int[] nums)
        {
            if (nums.Length < 1)
                return 0;

            int exclusive = 0;
            int inclusive = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                int temp = inclusive;
                inclusive = Math.Max(nums[i] + exclusive, inclusive);
                exclusive = temp;
            }

            return inclusive;
        }




    }
}
