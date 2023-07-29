namespace Sheet.A;

/* 
* TODO:
- Number on cards are distinct, so we need to insure that our list is a set(no repeatatoin).
- Insure that # of cards (1 <= n <= 1000), and each card's number is (1 : 1000),

* TRY:
- try to find a more fast solve. 
- think in Datastructure we use and the algorithm to Get elements form that datastructure.
*/


public class SerejaAndDima
{
    public static (int, int) Run()
    {
        var n = Convert.ToInt32(Console.ReadLine());
        var list = new List<int>();
        var SerejaScore = 0;
        var DimaScore = 0;
        int left;
        int right;

    
        // list.First();
        // list.Last();
        // list.ElementAt(0);

        for(int i = 0; i < n; ++i)
        {
            list.Add(Convert.ToInt32(Console.ReadLine()));
        }

        left = 0;
        right = list.Count - 1;

        for(int i = 0; i < list.Count; ++i)
        {
            if(i % 2 == 0)  // Sereja Move:
            {
                if(list[left] > list[right])
                {
                    SerejaScore += list[left];
                    left++;
                }
                else
                {
                    SerejaScore += list[right];
                    right--;
                }
            }
            else    // Dima Move:
            {
                if(list[left] > list[right])
                {
                    DimaScore += list[left];
                    left++;
                }
                else
                {
                    DimaScore += list[right];
                    right--;
                }
            }
        }

        return (SerejaScore, DimaScore);
    }
}