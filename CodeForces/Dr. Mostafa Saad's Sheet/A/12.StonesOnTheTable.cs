namespace Sheet.A;



public class StonesOnTheTable
{
    public static int Run()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        var s = new char[n];
        var count = 0;


        for(int i = 0; i < s.Length; ++i)
        {
            s[i] = Convert.ToChar(Console.ReadLine());
        }


        for(int i = 0; i < s.Length - 1; ++i)
        {
            if(s[i] == s[i+1]){
                count++;
            }
        }

        return count;
    }
}