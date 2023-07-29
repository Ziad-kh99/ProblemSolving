namespace LeetCode.Easy;

public class ValidMountainArray
{
    public static bool Solution(int[] arr)
    {
        int pointer = 0;

        if(arr.Length >= 3)
        {
             while(pointer < arr.Length -1)
            {
                if(arr[pointer] < arr[pointer+1])
                {
                    pointer++;
                    continue;
                }
                else if(arr[pointer] == arr[pointer+1])
                {
                    return false;
                }
                else 
                {
                    break;
                }
            }
 
            if(pointer == 0 || pointer == arr.Length-1)
            {
                return false;
            }

            //> Decrease:
            while(pointer < arr.Length -1)
            {
                if(arr[pointer] > arr[pointer+1])
                {
                    pointer++;
                    continue;
                }
                else
                {
                    return false;
                }
            }

            return true;
        }
        else 
        {
            return false;
        }

    }
}