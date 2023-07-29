namespace Sheet.A;


public class BeautifulMatrix
{
    public static int Run()
    {
        int steps = 0,
            row = -1,
            col = -1;

        var m = new int[5,5];

        // Fill Matrix:
        for(int i = 0; i < 5; ++i)
        {
            for(int j = 0; j < 5; ++j)
            {
                m[i,j] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("===============");
        }

        
        // Find row and col:
        // NOTE: we can involve this step with filling matrix
        for(int i = 0; i < 5; ++i)
        {
            for(int j = 0; j < 5; ++j)
            {
                if(m[i, j] == 1)
                {
                    row = i; 
                    col = j;
                }
            }
        }


        // Swap rows:
        while(row != 2)
        {
            if(row == 4)
            {
                m[row, col] = 0;
                m[0, col] = 1;
                row = 0;
                steps++;
            }
            else
            {
                m[row, col] = 0;
                m[row+1, col] = 1;
                row++;
                steps++;
            }
        }

        // Swap cols:
        while(col != 2)
        {
            if(col == 4)
            {
                m[row, col] = 0;
                m[row, 0] = 1;
                steps++;
                col = 0;
            }
            else
            {
                m[row, col] = 0;
                m[row, col+1] = 1;
                steps++;
                col++;
            }
        }


        return steps;
    }
}