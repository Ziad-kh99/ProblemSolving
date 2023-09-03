namespace LeetCode.Medium;

//> Solution one from tutorial on YouTube: https://youtu.be/NTF7sDU0IWA?si=8pu-NHEjP2j6QJ9y

public class DiagonalTraverse
{
    public static int[] Solution1(int[][] mat)
    {
        int m = mat.Length, n = mat[0].Length;
        int[] result = new int[m*n];
        int row = 0, col = 0, x = 0;

        bool up = true;

        while(row < m && col < n)
        {
            if(up)
            {
                while(row > 0 && col < n-1)
                {
                    result[x++] = mat[row--][col++];
                }
                result[x++] = mat[row][col];

                if(col == n-1)
                {
                    row++;
                }
                else
                {
                    col++;
                }
            }
            else
            {
                while(col > 0 && row < m-1)
                {
                    result[x++] = mat[row++][col--];
                }
                result[x++] = mat[row][col];

                if(row == m-1)
                {
                    col++;
                }
                else
                {
                    row++;
                }
            }

            up = !up;
        }

        return result;
    }


    public static int[] Solution2(int[][] mat)
    {
        int m = mat.Length, n = mat[0].Length;
        int[] result = new int[m*n];
        int row = 0, col = 0, x = 0;

        result[x++] = mat[0][0];
        col++;
        while(x < result.Length)
        {   
            if(col == mat.Length)
            {
                row = 1;
            }
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