namespace LeetCode.Easy;


public class MissingNumber
{
    public static int Solution(int[] nums)
    {
        int p = 0;
        //> Create new array with expected range [0:n]
        int[] expectedArray = new int[nums.Length + 1];

        for(int i = 0; i < expectedArray.Length; ++i)
        {
            expectedArray[i] = i;
        }

        for(int i = 0; i < expectedArray.Length; ++i)
        {
            for(int j = 0; j < nums.Length; ++j)
            {
                if(expectedArray[i] == nums[j])
                {
                    p = 1;
                    break;
                }
                else
                {
                    p = 0;
                }
            }

            if(p == 0)
            {
                return expectedArray[i];
            }
        }

        return -1;
    }
}