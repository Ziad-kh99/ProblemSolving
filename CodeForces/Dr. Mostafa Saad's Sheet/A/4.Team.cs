namespace Sheet.A;


public class Team
{
    public static int Run()
    {
        int slutions = 0;

        int n = Convert.ToInt32(Console.ReadLine());

        if(n >= 1 && n <= 1000)
        {
            int[,] arr = new int[n, 3];

            for(int i = 0; i < n; ++i)
            {
                int temp = 0;
                for(int j = 0; j < 3; ++j)
                {
                    arr[i,j] = Convert.ToInt32(Console.ReadLine());

                    if(arr[i,j] == 1)
                        temp++;
                }

                if(temp >= 2)
                    slutions++;
            }

            //** Reduce time complixty by remve nested loop for count # of slutions:
            #region Removed code..
            /*   
            for(int i = 0; i < n; ++i)
            {
                int temp = 0;
                for(int j = 0; j < 3; ++j)
                {
                    if(arr[i,j] == 1)
                    {
                        temp++;
                    }
                }

                if(temp >= 2)
                {
                    slutions++;
                }
            }
            */
            #endregion

            return slutions;
        }
        else
            return -1;
    }
}
