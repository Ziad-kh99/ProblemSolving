namespace LeetCode.Easy;


public class LargestNumberAtLeastTwice
{
    public static int Solution(int[] nums)
    {
        int largest = nums[0];
        int position = 0;

        for(int i = 1; i < nums.Length; ++i)
        {
            //> Special Case: first element.
            if(position == 0 && nums[0] / 2 < nums[i])
            {
                position = -1;
            }
            if(nums[i] > largest)
            {
                if((nums[i] / 2) >= largest)
                {
                    largest = nums[i];
                    position = i;
                }
                else {
                    largest = nums[i];
                    position = -1;
                }
            }

            //Speical Case: last element
            if(position != i && largest / 2 < nums[i])
            {
                position = -1;
            }
        }

        return position;
    }
}