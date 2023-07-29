namespace LeetCode.Easy;


public class PalindromeNumber
{
    public static bool Run(int x)
    {
        var str = x.ToString();
        int s = 0, 
            e = str.Length - 1;
        
        while(s < str.Length / 2)
        {
            if(str[s] == str[e])
            {
                s++;
                e--;
                continue;
            }
            else
            {
                return false;
            }
        }

        return true;
    }
}