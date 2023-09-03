namespace LeetCode.Easy;


public class PlusOne
{
    public static int[] Solution(int[] digits) 
    {
        if(digits[digits.Length-1] < 9)
        {
            digits[digits.Length-1]++;
            return digits;
        }
        else {
            int[] newArr = new int[digits.Length+1];
            for(int i = 0; i < digits.Length - 1; ++i)
            {
                newArr[i] = digits[i];
            }
            
            return newArr;
        }
        
    }
}