public class Solution
{
    public bool CanPartitionKSubsets(int[] nums, int k)
    {

        if (k > nums.Length) return false;
        if (nums.Sum() % k != 0) return false;

        bool[] used = new bool[nums.Length];

        int partitionSum = nums.Sum() / k;

        Array.Sort(nums);
        Array.Reverse(nums);

        bool backtrack(int startIndex, int remainingPartitions, int subsetSum)
        {
            if (remainingPartitions == 0)
            {
                return true;
            }
            if (subsetSum == partitionSum)
            {
                return backtrack(0, remainingPartitions - 1, 0);
            }
            for (int i = startIndex; i < nums.Length; i++)
            {
                if (used[i] || subsetSum + nums[i] > partitionSum)
                {
                    continue;
                }
                // set used to true
                used[i] = true;

                // call backtrack
                if (backtrack(i + 1, remainingPartitions, subsetSum + nums[i]))
                {
                    return true;
                }

                // set used to false
                used[i] = false;

            }
            return false;
        }

        return backtrack(0, k, 0);

    }
}