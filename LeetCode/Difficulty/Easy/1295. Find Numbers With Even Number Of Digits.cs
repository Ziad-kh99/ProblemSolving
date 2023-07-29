namespace LeetCode.Easy;

public class FindNumbersWithEventNumberOfDigits
{
    public static int Solution(int[] nums)
    {
        int count = default;

        for(int i = 0; i < nums.Length; ++i)
        {
            if(nums[i] > 9 && nums[i] < 100)
            {
                count++;
            }
            else if(nums[i] > 999 && nums[i] < 10000)
            {
                count++;
            }
            else if(nums[i] > 99999 && nums[i] < 1000000)
            {
                count++;
            }
        }

        return count;
    }

    public static int Solution2(int[] nums)
    {
        // TODO: Try to use Switch instead of If statements:
        int count = default;

        for(int i = 0; i < nums.Length; ++i)
        {
            // switch(nums[i]) {}
        }

        return count;
    }
}