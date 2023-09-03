namespace LeetCode.Easy;


public class FindPivotIndex 
{
    public static int Solution(int[] nums) 
    {
        int leftSum = 0;
        int rightSum = 0;

        for(int i = 0; i < nums.Length; ++i)
        {
            // Left side:
            for(int l = i-1; l >= 0; --l)
            {
                leftSum += nums[l];
            }

            // Right side:
            for(int r = i+1; r < nums.Length; ++r)
            {
                rightSum += nums[r];
            }

            if(leftSum == rightSum) 
            {
                return i;
            }
            else {
                leftSum = 0;
                rightSum = 0;
            }
        }

        return -1;
    }

    public static int Solution2(int[] nums)
    {
        int[] sumLeft = new int[nums.Length];

        for(int i = 0; i < nums.Length; ++i)
        {
            sumLeft[i] = nums[i-1];
        }

        return -1;
    }
}