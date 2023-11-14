namespace RoadmapExercises.SlidingWindow
{
    //https://leetcode.com/problems/best-time-to-buy-and-sell-stock
    public static class BestTimeToBuyAndSellStock
    {
        public static int Logic1(int[] prices)
        {
            var result = 0;

            var minValue = prices[0];
            foreach ( var pr in prices )
            {
                minValue = Math.Min(minValue, pr);
                result = Math.Max(result, pr - minValue);
            }

            return result;
        }

    }
}