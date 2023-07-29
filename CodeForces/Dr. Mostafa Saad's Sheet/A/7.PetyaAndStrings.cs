namespace Sheet.A;


public class PetyaAndStrings
{
    public static int Run()
    {
        string str1 = Console.ReadLine().ToLower();
        string str2 = Console.ReadLine().ToLower();


        int str1Count = 0;
        int str2Count = 0;
        for(int i = 0; i < str1.Length; ++i)
        {
            if(str1[i] < str2[i])
                str2Count++;
            
            else if(str2[i] < str1[i])
                str1Count++;
        }

        if(str1Count < str2Count)
            return -1;
        
        else if(str2Count < str1Count)
            return 1;
        
        else
            return 0;
    }
}