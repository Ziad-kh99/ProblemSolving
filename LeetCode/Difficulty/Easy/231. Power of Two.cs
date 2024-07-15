namespace LeetCode.Easy;


public class PowerOfTwo
{
    public static bool Solution(int n)
    {
        for(int i = 0; i < 32; ++i)
        {
            if(n == Math.Pow(2, i))
            {
                return true;
            }
        }

        return false;
    }
}