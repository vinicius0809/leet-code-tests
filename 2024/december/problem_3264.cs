using System;

public class Solution {
    public int[] GetFinalState(int[] nums, int k, int multiplier) {      
        for (int i = 0; i < k; i++)
        {
            int lowerNumberIndex = FindLowerNumberIndex(nums);
            nums[lowerNumberIndex] = nums[lowerNumberIndex] * multiplier;
        }

        return nums;
    }

    private int FindLowerNumberIndex(int[] array){
        int lowerNumberIndex = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if(array[i] < array[lowerNumberIndex]){
                lowerNumberIndex = i;
            }
        }

        return lowerNumberIndex;
    }
}