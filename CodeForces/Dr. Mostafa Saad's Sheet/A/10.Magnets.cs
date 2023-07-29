namespace Sheet.A;

/* TODO: 
- Try to count groups from second magnet, i strt form 1(second element) 
    => magnets[i, 1] != magnets[i-1, 0]
- and see if this apprach will count group correctly without add 1 after loop [A]
*/
public class Magnets
{
    public static int Run()
    {
        var n = Convert.ToInt32(Console.ReadLine());

        var groups = 0;

        var magnets = new int[n, 2];

        for(int i = 0; i < n; ++i)
        {
            for(int j = 0; j < 2; ++j)
            {
                magnets[i, j] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
        }

        for(int i = 0; i < n - 1; ++i)
        {
            if(magnets[i, 1] != magnets[i+1, 0])
            {
                continue;
            }
            else
            {
                groups++;
            }     
        }

        ++groups;       // [A] to count last group

        return groups;
    }

}