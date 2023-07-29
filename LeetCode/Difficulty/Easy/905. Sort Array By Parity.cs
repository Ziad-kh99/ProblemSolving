namespace LeetCode.Easy;

public class SortArrayByParity
{
    public static int[] Solution1(int[] nums)
    {
        for(int i = 0; i < nums.Length; ++i)
        {
            if(nums[i] % 2 == 0)
            {
                Shift(ref nums, i);
            }
        }
        
        return nums;
    }

    public static void Shift(ref int[] nums, int from)
    {
        for(int i = from; i > 0 && nums[i-1] % 2 != 0; --i)
        {
            int temp = nums[i-1];
            nums[i-1] = nums[i];
            nums[i] = temp;
        }
    }
}