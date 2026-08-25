public class Solution
{
    public int MaxProfit(int[] prices)
    {
        int diff = 0;
        int min = prices[0];

        for (int i = 0; i < prices.Length; i++)
        {
            int curr = prices[i];
            if (curr - min > diff)
            {
                diff = curr - min;
            }
            if (curr < min)
            {
                min = curr;
            }

        }
        return diff;
    }
}