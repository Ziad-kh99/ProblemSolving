//> Problem Link: https://leetcode.com/problems/max-consecutive-ones/description/

namespace LeetCode.Easy;

public class MaxConsecutiveOnes
{
    public static int Solution(int[] nums)
    {
        int max = 0;
        for(int i = 0; i < nums.Length; ++i)
        {
            if(nums[i] == 1)
            {
                max++;
                if(i == nums.Length - 1)
                {
                    nums[i] = max;
                }
            }
            else
            {
                nums[i] = max;
                max = 0;
            }
        }

        // nums[nums.Length-1] = max;

        max = getMax(nums);

        return max;
    }

    public static int getMax(int[] maximums)
    {
        int max = maximums[0];
        for(int i = 1; i < maximums.Length; ++i)
        {
            if(maximums[i] > max)
            {
                max = maximums[i];
            }
        }

        return max;
    }
}