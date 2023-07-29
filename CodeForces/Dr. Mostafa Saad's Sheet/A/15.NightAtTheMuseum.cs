/*  TODO:
- Try to use binary search for search on letters
- Hint: make an array and fill it by position for each char in your word, and then
    use these values to search throw out letter's array.

*/


namespace Sheet.A;


public class NightAtTheMuseum
{
    public static int Run()
    {
        string word = Console.ReadLine();

        var letters = new[] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j',
            'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};

        int last_position = 0;
        int rotations = 0;
        int count_r = 0;
        int count_l = 0;

        for(int i = 0; i < word.Length; ++i)
        {
            count_r = 0; count_l = 0;       // This line take me about 40 min in Debugging. 😂

            //> Right side:
            for(int j = last_position; ; ++j)
            {
                if(word[i] == letters[j])
                {
                    break;
                }
                else if(j == letters.Length-1)
                {
                    j = -1;
                    count_r++;
                }
                else
                {
                    count_r++;
                }
            }
            

            //> Left side:
            for(int j = last_position; ; --j)
            {
                if(word[i] == letters[j])
                {
                    last_position = j;
                    break;
                }
                else if(j == 0)
                {
                    j = letters.Length;
                    count_l++;
                }
                else
                {
                    count_l++;
                }
            }

            if(count_r <= count_l)
                rotations += count_r;
            else
                rotations += count_l;

        }

        return rotations;
    }
}