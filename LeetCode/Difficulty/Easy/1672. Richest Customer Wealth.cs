namespace LeetCode.Easy;


public class RichestCustomerWealth
{
    public static int Solution(int[][] accounts)
    {
        int maximum = 0;
        int value = 0;

        for(int i = 0; i < accounts.Length; ++i)
        {   
            value = 0;
            for(int j = 0; j < accounts[i].Length; ++j)
            {
                value += accounts[i][j];
            }

            if(value > maximum)
            {
                maximum = value;
            }
        }

        return maximum;
    }
}