namespace LeetCode.Easy;

public class FindAllNumbersDisappearedInAnArray
{
    public static List<int> Solution(int[] nums)
    {
        List<int> result = new List<int>();

        for(int i = 1; i <= nums.Length; ++i)
        {
            bool isExist = false;

            for(int j = 0; j < nums.Length; ++j)
            {
                if(i == nums[j])
                {
                    isExist = true;
                    break;
                }
            }

            if(!isExist)
            {
                result.Add(i);
            }
        }

        return result;
    }
}