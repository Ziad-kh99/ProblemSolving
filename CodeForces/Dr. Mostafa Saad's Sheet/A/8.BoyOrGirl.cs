namespace Sheet.A;


public class BoyOrGirl
{
    public static string Run()
    {
        string username = Console.ReadLine();

        var newList = new List<char>();
        var count = 0;

        newList.Add(username[0]);
        for(int i = 1; i < username.Length; ++i)
        {
            count = 0;
            for(int j = 0; j < newList.Count; ++j)
            {
                if(username[i] == newList[j])
                {
                    count = -1;
                    break;
                }
            }
            if(count == 0)  // not repeated
                {
                    newList.Add(username[i]);
                }
        }

        // foreach(var x in newList)
        // {
        //     Console.Write(x);
        // }

        if(newList.Count % 2 == 0)
        {
            return "Chat with her!";
        }
        
        return "Igonre him!";
    }

}