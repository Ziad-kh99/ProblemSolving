namespace Sheet.A;


public class ColorfulStones
{
    public static int Run()
    {
        var stones = Console.ReadLine().ToList();
        var instructions = Console.ReadLine().ToList();
        var lissPosition = 0;
        // var start = 0;
        var end = 1;

        for(int i = 0;  i < instructions.Count; ++i)
        {
            for(int j = lissPosition; j < end; ++j)
            {
                if(stones[j] == instructions[i])
                {
                    lissPosition++;
                    // start++;
                    end++;
                }

                stones[j] = instructions[i];
            }
        }

        return lissPosition;
    }
}