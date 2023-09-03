namespace LeetCode.Medium;

public class DiagonalTraverse
{
    public static int[] Solution(int[][] mat)
    {
        int[] result = new int[mat.Length*mat.Length];
        int row = 0, col = 0, x = 0;

        result[x++] = mat[0][0];
        col++;
        while(x < result.Length)
        {   
            for(; col >= 0; col--, row++)
            {
                result[x++] = mat[row][col];
            }
            
            col++;
            for(; row >= 0; row--, col++)
            {
                result[x++] = mat[row][col];
            }
            

            row = 0;

#warning: (OUT OF RANGE EXCEPTION!) - What about the second half of the matrix??

            if(col == mat.Length)
            {
                row = 1; col = 1;

                for(; col >= 1; col--, row++)
                {
                    result[x++] = mat[row][col];
                }
            
            
                col++;
                for(; row >= 1; row--, col++)
                {
                    result[x++] = mat[row][col];
                }
            

            row = 0;


            }
        }



        return result;
    }
}