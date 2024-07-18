namespace LeetCode.Easy;


public class ValidPalindrome
{
    public static bool Solution(string s)
    {
        Console.WriteLine(s.Length);
        for (int i = 0; i < s.Length; ++i)
        {
            if (char.IsLetterOrDigit(s[i]) == false)
            {
                s = s.Remove(i, 1);
                i--;
            }
        }

        s = s.Replace(" ", "").ToLower();

        Console.WriteLine(s);

        for(int start = 0, end = s.Length - 1; start <= end; ++start, --end)
        {
            if(s[start] != s[end])
            {
                return false;
            }
        }

        return true;
    }

}