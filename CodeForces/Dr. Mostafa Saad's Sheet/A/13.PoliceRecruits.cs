namespace Sheet.A;


class PoliceRecruits
{
    public static int Run()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int crimes = 0;
        int ActiveRecruits = 0;
        int[] arr = new int[n];

        for(int i = 0; i < n; ++i)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }




        for(int i = 0; i < n; ++i)
        {
            if(arr[i] == -1)
            {
                if(ActiveRecruits > 0)
                {
                    ActiveRecruits--;
                    continue;
                }
                else
                    crimes++;
            }
            else
            {
                ActiveRecruits += arr[i];
            }
        }

        return crimes;
    }
} 