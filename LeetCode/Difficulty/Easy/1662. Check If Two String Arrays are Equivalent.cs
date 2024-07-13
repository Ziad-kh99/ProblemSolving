namespace LeetCode.Easy;


public class CheckIfTwoStringArraysAreEquivalent
{
    public static bool Solution(string[] word1, string[] word2)
    {
        /* Approache One:
        string firstWord = String.Join(" ", word1).Replace(" ", "");
        string secondWord = String.Join(" ", word2).Replace(" ", "");
        bool EquivalentString = firstWord == secondWord;
        // return EquivalentString;
        */

        //> Approache Two:
        return String.Join(' ', word1).Replace(" ", "") == String.Join(' ', word2).Replace(" ", "");
    }
}