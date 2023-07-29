namespace LeetCode.Easy;

public class DuplicateZeros
{
    public static void Solution(int[] nums)
    {
        for(int i = 0; i < nums.Length; ++i)
        {
            if(nums[i] == 0)
            {
                Shift(ref nums, i);
                ++i;
            }
        }

        foreach(var i in nums)
        {
            Console.Write($"{i} - ");
        }
    }

    public static void Shift(ref int[] nums, int from)
    {
        for(int i = nums.Length - 1; i > from; --i)
        {
            nums[i] = nums[i - 1];
        }
    }
}