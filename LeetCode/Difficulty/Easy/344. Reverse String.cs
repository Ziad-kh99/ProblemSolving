namespace LeetCode.Easy;


public class ReverseString
{
    public static void Solution(char[] s)
    {
        int startP = 0;
        int endP = s.Length - 1;

        while(startP < endP)
        {
            //> we can use tuple in modern C# to swap values:
            (s[startP], s[endP]) = (s[endP], s[startP]);

            /* 
             - Old way to swap elements:
            char temp = s[startP];
            s[startP] = s[endP];
            s[endP] = temp;
            */

            startP++;
            endP--;
        }

        foreach(var x in s)
        {
            Console.Write(x);
        }
    }
}