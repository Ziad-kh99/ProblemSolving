namespace LeetCode.Easy;


public class RunningSumOf1DArray
{
    public static int[] Solution(int[] nums)
    {
        for(int i = 1; i < nums.Length; ++i)
        {
            nums[i] += nums[i-1];
        }

        return nums;
    }
}