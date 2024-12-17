namespace LeetCodeTests._2024.december.problem_1
{
    internal class Problem1
    {
        public int[] TwoSum(int[] nums, int target)
        {
            var dict = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int j = target - nums[i];
                if (dict.ContainsKey(j))
                {
                    return new int[] { dict[j], i };
                }

                dict[nums[i]] = i;
            }
            return new int[] {-1,-1};
        }
    }
}
