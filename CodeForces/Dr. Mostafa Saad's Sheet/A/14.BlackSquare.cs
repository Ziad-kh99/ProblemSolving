using System.Text;

namespace Sheet.A;

public class BlackSquare
{
    public static int Run()
    {
        var strips = new int[4];
        // var blackSquare = new List<int>(100_000);
        var blackSquare = new StringBuilder();
        var calories = 0;

        for(int i = 0; i < strips.Length; ++i)
        {
            strips[i] = Convert.ToInt32(Console.ReadLine());
        }


        blackSquare.Append(Console.ReadLine());     // faster than loop!
        
        /*
        for(;;)
        {
            //> for stop enter black squares (-1)
            int val = Convert.ToInt32(Console.ReadLine());
            if(val == -1)
            {
                break;
            }
            blackSquare.Add(val);
        }
        */

        for(int i = 0; i < blackSquare.Length; ++i)
        {
            if(blackSquare[i] == '1')
                calories += strips[0];
            
            else if(blackSquare[i] == '2')
                calories += strips[1];

            else if(blackSquare[i] == '3')
                calories += strips[2];

            else if(blackSquare[i] == '4')
                calories += strips[3];
        }

        return calories;
    }
}