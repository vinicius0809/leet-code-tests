public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        Array.Sort(nums);

        int leftI = 0;
        int rightI = nums.Length - 1;
        int midI = leftI + (rightI - leftI) / 2;

        while (leftI <= rightI)
        {
            int highestSum = 0;
            int leftJ = 0;
            int rightJ = nums.Length - 1;
            while (leftJ <= rightJ)
            {
                int midJ = leftJ + (rightJ - leftJ) / 2;
                int sum = nums[midI] + nums[midJ];

                if (sum > highestSum)
                    highestSum = sum;
                if (sum == target)
                    return new int[] { midI, midJ };
                if (sum < target)
                    rightJ = midJ-1;
                else
                    leftJ = midJ+1;
            }
            if (highestSum < target)
                rightI = midI-1;
            else
                leftI = midI+1;
        }

        return null;
    }
}