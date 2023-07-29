namespace LeetCode.Easy;

public class NumberOfSteps
{
    public static int Solution(int num)
    {
        int numberOfSteps = 0;

        while(num != 0)
        {
            if(num % 2 == 0)
            {
                num /= 2;
            }
            else
            {
                num -= 1;
            }

            numberOfSteps++;
        }

        return numberOfSteps;
    }
}