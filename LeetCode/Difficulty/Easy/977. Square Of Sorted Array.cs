namespace LeetCode.Easy;

public class SquareOfSortedArray
{
    public static int[] Solution(int[] nums)
    {
        for(int i = 0; i < nums.Length; ++i)
        {
            nums[i] *= nums[i];
        }

        return Sort(ref nums);
    }

    //> Sort array using InsertionSort Algorithm:
    public static int[] Sort(ref int[] nums)
    {
        for(int i = 1; i < nums.Length; ++i)
        {
            int j = i;
            while(j >= 1 && nums[j] < nums[j - 1])
            {
                int temp = nums[j];
                nums[j] = nums[j - 1];
                nums[j - 1] = temp;

                j--;
            }
        }

        return nums;
    }
}