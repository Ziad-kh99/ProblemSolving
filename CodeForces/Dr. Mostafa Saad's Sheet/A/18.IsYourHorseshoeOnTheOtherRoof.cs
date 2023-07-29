namespace Sheet.A;


public class Horseshoe
{
    public static int Run()
    {
        var colors = new int[4];
        int horseshoes = 0;

        for(int i = 0; i < colors.Length; ++i)
        {
            colors[i] = Convert.ToInt32(Console.ReadLine());
        }


        for(int i = 0; i < colors.Length -1; ++i)
        {
            for(int j = i+1; j < colors.Length; ++j)
            {
                if(colors[i] == 0)
                    break;

                if(colors[i] == colors[j])
                {
                    horseshoes++;
                    colors[j] = 0;
                }
            }
        }

        return horseshoes;
    }
}