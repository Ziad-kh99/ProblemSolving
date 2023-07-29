namespace LeetCode.Easy;


public class P13
{
    public static int Run(string s)
    {
        var result = 0;

        for(int i = 0; i < s.Length; ++i)
        {
            if(i == s.Length - 1)
            {
                if(s[i] == 'I')
                {
                    result += 1;
                }

                else if(s[i] == 'V')
                {
                    result += 5;
                }

                else if(s[i] == 'X')
                {
                    result += 10;
                }

                else if(s[i] == 'L')
                {
                    result += 50;
                }

                else if(s[i] == 'C')
                {
                    result += 100;
                }

                else if(s[i] == 'D')
                {
                    result += 500;
                }

                else if(s[i] == 'M')
                {
                    result += 1000;
                }
            }

            else if(s[i] == 'I')
            {
                if(s[i+1] == 'V')
                {
                    result += 4;
                }
                else if(s[i+1] == 'X')
                {
                    result += 9;
                }
                else
                {
                    result += 1;
                }
            }

            else if(s[i] == 'V')
            {
                result += 5;
            }

            else if(s[i] == 'X')
            {
                if(s[i+1] == 'L')
                {
                    result += 40;
                }
                else if(s[i+1] == 'C')
                {
                    result += 90;
                }
                else
                {
                    result += 10;
                }
            }

            else if(s[i] == 'L')
            {
                result += 50;
            }

            else if(s[i] == 'C')
            {
                if(s[i+1] == 'D')
                {
                    result += 400;
                }
                else if(s[i+1] == 'M')
                {
                    result += 900;
                }
                else
                {
                    result += 100;
                }
            }

            else if(s[i] == 'D')
            {
                result += 500;
            }

            else if(s[i] == 'M')
            {
                result += 1000;
            }
        }

        return result;

    }


}