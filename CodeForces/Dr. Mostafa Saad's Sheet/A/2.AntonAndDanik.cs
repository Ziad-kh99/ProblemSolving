using static System.Console;
namespace Sheet.A;

public class AntonAndDanik
{
    public static void Run()
    {
        var Anton = 0;
        var Danik = 0;

        int n = Convert.ToInt32(Console.ReadLine());
        var s1 = Console.ReadLine();

        string s = s1.Substring(0, n);    

        for(int i = 0; i < s.Length; ++i)
        {
            if(s[i] == 'A')
                Anton++;
            else
                Danik++;
        }

        if(Anton > Danik)
            WriteLine("Anton");
        else if(Danik > Anton)
            WriteLine("Danik");
        else    
            WriteLine("Friendship");

    }
}