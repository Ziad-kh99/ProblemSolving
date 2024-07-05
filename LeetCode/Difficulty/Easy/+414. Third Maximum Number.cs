namespace LeetCode.Easy;


public class ThirdMaximumNumber
{
    public static int Solution1(int[] nums)
    {
        int[] threeMax = new int[3] {-2147483648,-2147483648,-2147483648};

        var x = nums.Contains(-2147483648);

        for (int i = 0; i < nums.Length; ++i)
        {
            if (nums[i] >= threeMax[0])
            {
                if (threeMax[0] == nums[i])
                {
                    continue;
                }
                else
                {
                    threeMax[1] = threeMax[0];
                    threeMax[0] = nums[i];
                }
            }
            else if (nums[i] >= threeMax[1])
            {
                if (threeMax[1] == nums[i])
                {
                    continue;
                }
                else
                {
                    threeMax[2] = threeMax[1];
                    threeMax[1] = nums[i];
                }
            }
            else if (nums[i] >= threeMax[2])
            {
                threeMax[2] = nums[i];
            }
        }

        foreach(int i in threeMax)
        {
            Console.WriteLine(i);
        }

        if (threeMax[2] != -2147483648 || x)
        {
            return threeMax[2];
        }
        else
        {
            return threeMax[0];
        }

        
    }
    public static int Solution(int[] nums)
    {
        int length = 1;
        for (int i = 1; i < nums.Length; ++i)
        {
            if (nums[i] > nums[i - 1])
            {
                Shift(ref nums, i);
                length++;
            }
        }

        for (int i = 0; i < nums.Length - 1; ++i)
        {
            if (nums[i] != nums[i + 1])
            {
                length++;
            }
        }

        if (length < 3)
        {
            return nums[0];
        }
        if (length == 3)
        {
            return nums[2];
        }

        for (int i = 0, third = 0; i < nums.Length - 1; ++i)
        {
            if (nums[i] > nums[i + 1])
            {
                third++;
            }
            else
            {
                continue;
            }

            if (third == 3)
            {
                return nums[i];
            }
        }






        foreach (int x in nums)
            Console.Write($"{x} - ");

        Console.WriteLine($"\n===========================");

        return nums[2];
    }

    public static void Shift(ref int[] nums, int from)
    {
        for (int i = from; i > 0 && nums[i - 1] <= nums[i]; --i)
        {
            int temp = nums[i - 1];
            nums[i - 1] = nums[i];
            nums[i] = temp;
        }
    }
}