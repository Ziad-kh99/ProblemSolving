namespace LeetCode.Easy;


public class NumberOfRectangles
{
    public static int Solution(int[][] rectangles)
    {
        int rectanglesLength = rectangles.GetLength(0);
        int maxLength;
        int[] sideLength = new int[rectanglesLength];
        int squares = 0;

        
            for(int i = 0; i < rectanglesLength; ++i)
            {
                if(rectangles[i][0] != rectangles[i][1])
                {
                    sideLength[i] = rectangles[i][0];
                    if(rectangles[i][1] <= sideLength[i])
                    {
                        sideLength[i] = rectangles[i][1];
                    }
                }
            }

            maxLength = sideLength[0];

            for(int i = 0; i < rectanglesLength; ++i)
            {
                if(sideLength[i] > maxLength)
                {
                    maxLength = sideLength[i];
                    squares = 0; 
                }
                else if(sideLength[i] < maxLength)
                {
                    continue;
                }

                squares++;
            }  
        

        return squares;
    }
}