namespace Sheet.A;


public class Word
{
    public static string Run()
    {
        var str = Console.ReadLine();
        var lower = 0;
        var upper = 0;
        for(var i = 0; i < str.Length; ++i)
        {
            var x = str[i].ToString().ToLower();

            if(str[i].ToString() == x)      // Lower
            {
                lower++;
            }
            else if(str[i].ToString() == x.ToUpper())       // Uppercase
            {
                upper++;
            }
        }

        if(upper > lower)
        {
            return str.ToUpper();
        }
        else        //> lower > upper || lower == upper
        {
            return str.ToLower();
        }
    }

}