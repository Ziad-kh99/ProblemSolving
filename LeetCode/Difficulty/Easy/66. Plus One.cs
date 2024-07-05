namespace LeetCode.Easy;


public class PlusOne
{
    public static int[] Sol(int[] digits)
    {
        string numberAsStr = string.Empty;

        foreach(int digit in digits)
        {
            numberAsStr += digit.ToString();
        }

        // Console.WriteLine(numberAsStr);

        int number;
        
        int.TryParse(numberAsStr, out number);

        number++;

        // Console.WriteLine(number);

        numberAsStr = number.ToString();

        char[] digitsAsChars = numberAsStr.ToCharArray();

        // foreach(char digit in digitsAsChars)
        // {
        //     Console.Write($"{digit}, ");
        // }
        // Console.WriteLine();

        int[] newDigits = new int[digitsAsChars.Length];

        for(int i = 0; i < newDigits.Length; ++i)
        {
            newDigits[i] = int.Parse(digitsAsChars[i].ToString());
        }

        // foreach(int digit in newDigits)
        // {
        //     Console.Write($"{digit}, ");
        // }

        return newDigits;
    }


    public static int[] Solution(int[] digits) 
    {
        int lastIndex = digits.Length - 1;
        bool all9 = true;

        if(digits[lastIndex] < 9)
        {
            digits[lastIndex]++;
            return digits;
        }
        else
        {
            for(int i = lastIndex; i >= 0; --i)
            {
                if(digits[i] == 9)
                {
                    digits[i] = 0;
                }
                else 
                {
                    digits[i]++;
                    all9 = false;
                    break;
                }
            }

            if(all9)
            {
                int[] newDigits = new int[lastIndex + 2];
                newDigits[0] = 1;

                return newDigits;
            }
        }

        return digits;
    }
}