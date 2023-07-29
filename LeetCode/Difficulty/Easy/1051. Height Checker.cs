namespace LeetCode.Easy;


public class HeightChecker
{
    public static int Solution(int[] heights)
    {
        if(heights == null || heights.Length < 1)
        {
            return 0;
        }

        int indices = 0;
        int[] realHeights = new int[heights.Length];
        heights.CopyTo(realHeights, 0);

        for(int i = 1; i < heights.Length; ++i)
        {
            

            if(heights[i] < heights[i-1])
            {
                Shift(ref heights, i);
            }

            // if(heights[i] != realHeights[i])
            // {
            //     indices++;
            // }
        }

        for(int i = 0; i < heights.Length; ++i)
        {
            if(heights[i] != realHeights[i])
            {
                indices++;
            }
        }

        foreach(int x in heights)
            Console.Write($"{x} - ");

        Console.WriteLine($"===========================");

        foreach(int x in realHeights)
            Console.Write($"{x} - ");    

        return indices;
    }

    public static void Shift(ref int[] arr, int from)
    {
        for(int i = from; i > 0 && arr[i-1] > arr[i]; --i)
        {
            int temp = arr[i-1];
            arr[i-1] = arr[i];
            arr[i] = temp;
        }
    }
}