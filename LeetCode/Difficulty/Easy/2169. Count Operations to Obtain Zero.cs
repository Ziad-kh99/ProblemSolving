namespace LeetCode.Easy;

public class P2169
{
    public static int Run()
    {
        int num1 = Convert.ToInt32(Console.ReadLine());
        int num2 = Convert.ToInt32(Console.ReadLine());
        int operations = 0;

        while(num1 != 0 && num2 != 0)
        {
            if(num1 >= num2)
            {
                num1 -= num2;
                operations++;
            }
            else
            {
                num2 -= num1;
                operations++;
            }
        }


        return operations;
    }
}