//> Problem link: https://leetcode.com/problems/remove-duplicates-from-sorted-array/

namespace LeetCode.Easy;


public class RemoveDuplicatesFormSortedArray
{
    public static int RemoveDuplicates(int[] nums)
    {
        if(nums.Length == 0)
        {
            return 0;
        }
        int currentElement = 0;
        int pointer = 1;

        while(pointer < nums.Length)
        {
            if(nums[currentElement] == nums[pointer])
            {
                pointer++;
                continue;
            }
            else 
            {
                currentElement++;
                nums[currentElement] = nums[pointer];
                pointer++;
            }
        }

        return ++currentElement;
    }
}

