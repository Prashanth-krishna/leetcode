public class Solution
{
    public int MajorityElement(int[] nums)
    {
        int target = nums.Length / 2;
        Dictionary<int, int> dict = new();

        for (int i = 0; i < nums.Length; i++)
        {
            int curr = nums[i];
            if (dict.ContainsKey(curr))
            {
                dict[curr] += 1;
            }
            else
            {
                dict[curr] = 1;
            }
            if (dict[curr] > target)
            {
                return curr;
            }
        }
        return nums[0];
    }
}