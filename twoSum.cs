public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        List<int> result = new();
        Dictionary<int, int> dict = new();

        for (int i = 0; i < nums.Length; i++)
        {
            int total = target - nums[i];
            if (dict.ContainsKey(total))
            {
                result.Add(dict[total]);
                result.Add(i);
            }
            else
            {
                dict[nums[i]] = i;
            }
        }

        return result.ToArray();
    }
}