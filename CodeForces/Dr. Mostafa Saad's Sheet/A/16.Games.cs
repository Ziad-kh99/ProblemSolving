namespace Sheet.A;


public class Games
{
    public static int Run()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int games = 0;
        int[,] arr = new int[n, 2];

        for(int i = 0; i < arr.GetLength(0); ++i)
        {
            for(int j = 0; j < arr.GetLength(1); ++j)
            {
                arr[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        for(int i = 0; i < n; ++i)
        {
            for(int j = 0; j < n; ++j)
            {
                if(arr[i, 0] == arr[j, 1])
                {
                    games++;
                }
            }
        }


        return games;
    }
}