namespace LeetCode.Easy;


public class PascalTriangle
{
    public static IList<IList<int>> Solution(int numRows)
    {
        IList<IList<int>> result = new List<IList<int>>();

        result.Add(new List<int> {1});
        if(numRows == 1)
        {
            return result;
        }

        result.Add(new List<int> {1,1});
        if(numRows == 2)
        {
            return result;
        }

        for(int i = 2; i < numRows; ++i)
        {
            List<int> inner = new List<int>();
            result.Add(inner);
            inner.Add(1);
            for(int j = 1; j < i; ++j)
            {
                inner.Add(result[i-1][j-1] + result[i-1][j]);
            }
            inner.Add(1);
        }

        return result;
    }
}