namespace Sheet.A;

public class VanyeAndFence
{

    // We can cotomize it by integrate two loops..
    //      - cont eatch fh after enter if emediatlly

    public static int Run()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int h = Convert.ToInt32(Console.ReadLine());
        int w = 0;
        var fhs = new List<int>();

        for(int i = 0; i < n; i++)
        {
            var x = Convert.ToInt32(Console.ReadLine());
            fhs.Add(x);
        }

        for(int i = 0; i < n; ++i)
        {
            if(fhs[i] <= h)
            {
                w++;
            }
            else
            {
                w += 2;
            }
        }

        return w;
    }
}







