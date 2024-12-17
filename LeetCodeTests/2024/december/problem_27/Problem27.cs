namespace LeetCodeTests._2024.december.problem_1
{
    internal class Problem27
    {
        public int RemoveElement(int[] nums, int val)
        {
            int countK = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[countK++] = nums[i]; 
                }
            }

            return countK;
        }
    }
}
