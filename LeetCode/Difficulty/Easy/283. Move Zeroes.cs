namespace LeetCode.Easy;


public class MoveZeroes
{
    //> Simple and not optimal solution:
    public static void Solution1(int[] nums)
    {
        if(nums == null || nums.Length == 0)
        {
            return;
        }

        for(int i = 0; i < nums.Length; ++i)
        {
            if(nums[i] == 0)
            {
                for(int j = i+1; j < nums.Length; ++j)
                {
                    if(nums[j] != 0)
                    {
                        nums[i] = nums[j];
                        nums[j] = 0;
                        break;
                    }
                }
            }
        }

        foreach(int x in nums)
            Console.Write($"{x} - ");
    }
}