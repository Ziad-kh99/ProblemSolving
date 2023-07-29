namespace LeetCode.Easy;

public class RansomNote
{
    public static void Solution(string ransomNote, string magazine)
    {
        Dictionary<int, char> dic = new Dictionary<int, char>();

        for(int i = 0; i < ransomNote.Length; ++i)
        {
            if(magazine.Contains(ransomNote[i]))
            {
                // magazine.Contains(ransomNote[i]).ToString().in
                dic.Add(i, ransomNote[i]);
            }
        }
    }
}