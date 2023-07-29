namespace LeetCode.Easy;


public class ThirdMaximumNumber
{
    public static int Solution(int[] nums)
    {
        int length = 1;
        for(int i = 1; i < nums.Length; ++i)
        {
            if(nums[i] > nums[i-1])
            {
                Shift(ref nums, i);
                length++;
            }
        }

        for(int i = 0; i < nums.Length-1; ++i)
        {
            if(nums[i] != nums[i+1])
            {
                length++;
            }
        }

        if(length < 3)
        {
            return nums[0];
        }
        if(length == 3)
        {
            return nums[2];
        }

        for(int i = 0, third = 0; i < nums.Length-1; ++i)
        {
            if(nums[i] > nums[i+1])
            {
                third++;
            }
            else
            {
                continue;
            }

            if(third == 3)
            {
                return nums[i];
            }
        }
        
        
        

        

        foreach(int x in nums)
            Console.Write($"{x} - ");

        Console.WriteLine($"\n===========================");

        return nums[2];
    }

    public static void Shift(ref int[] nums, int from)
    {
        for(int i = from; i > 0 && nums[i-1] <= nums[i]; --i)
        {
            int temp = nums[i-1];
            nums[i-1] = nums[i];
            nums[i] = temp;
        }
    }
}