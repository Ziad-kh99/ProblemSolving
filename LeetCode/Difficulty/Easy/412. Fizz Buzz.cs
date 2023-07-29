namespace LeetCode.Easy;

public class FizzBuzz
{
    public static List<string> Solution(int n)
    {
        List<string> answer = new List<string>();

        for(int i = 1; i <= n; ++i)
        {
            if(i % 3 == 0 && i % 5 == 0)
            {
                answer.Add("FizzBuzz");
            }
            else if(i % 3 == 0)
            {
                answer.Add("Fizz");
            }
            else if(i % 5 == 0)
            {
                answer.Add("Buzz");
            }
            else
            {
                answer.Add(i.ToString());
            }
        }

        return answer;
    }

    public static List<string> Solution2(int n)
    {
        List<string> answer = new List<string>();

        for(int i = 1; i <= n; ++i)
        {
            bool divisibleBy3 = i % 3 == 0;
            bool divisibleBy5 = i % 5 == 0;

            string currentStr = "";

            if(divisibleBy3)
            {
                currentStr += "Fizz";
            }
            if(divisibleBy5)
            {
                currentStr += "Buzz";
            }
            if(string.IsNullOrEmpty(currentStr))
            {
                currentStr += i.ToString();
            }

            answer.Add(currentStr);
        }

        return answer;
    }
}