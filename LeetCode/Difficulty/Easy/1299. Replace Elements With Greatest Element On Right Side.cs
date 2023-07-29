namespace LeetCode.Easy;


public class ReplaceElementsWithGreatesElementOnRightSide
{
    public static int[] Solution0(int[] arr)
    {
        int max = 0;

        for(int i = 0; i < arr.Length-1; ++i)
        {
            for(int j = i+1; j < arr.Length; ++j)
            {
                if(arr[j] > max)
                {
                    max = arr[j];
                }
            }

            arr[i] = max;
        }

        arr[arr.Length-1] = -1;

        return arr;
    }

    public static int[] Solution(int[] arr)
    {
        int max = 0;

        for(int i = 0; i < arr.Length-1; ++i)
        {
            max = GetMax(ref arr, i+1);

            arr[i] = max;
        }

        arr[arr.Length-1] = -1; 

        return arr;
    }

    public static int GetMax(ref int[] arr, int from)
    {
        int max = 0; 

        for(int j = from; j < arr.Length; ++j)
        {
            if(arr[j] > max)
            {
                max = arr[j];
            }
        }

        return max;
    }
}