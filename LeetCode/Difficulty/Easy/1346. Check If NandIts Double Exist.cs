namespace LeetCode.Easy;


public class CheckIfExist
{
    public static bool Solution(int[] arr)
    {
        for(int i = 0; i < arr.Length; ++i)
        {
            for(int j = 0; j < arr.Length; ++j)
            {
                if(arr[i] == 0 && i == j)
                {
                    continue;
                }
                
                if(arr[i] == 2 * arr[j])
                {
                    return true;
                }
            }
        }

        return false;
    }
}