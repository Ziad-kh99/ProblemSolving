/*  Idea 💡:
- To solve this problem i used a specific technique:
* To round to multiple of a specific amount(10 here):
- round (givin value, amount to round to)
    => round(x, m) == round(x/m)*m


*/


namespace Sheet.A;

public class BuyAShovel
{
    #region Wrong answer 1:
    /*
    public static int Run()
    {
        int k = Convert.ToInt32(Console.ReadLine());
        int n = Convert.ToInt32(Console.ReadLine());

        int r1, r2;
        int count = 0;
        bool x = true;
        do
        {
            r1 = (k + n) % 10;
            r2 = k % 10;
            if(r1 == 0 || r2 == 0)
            {
                x = false;
            }

            k += k;
            count++;
        }while(x);

        return count;
    }
    */
    #endregion

    public static int Run()
    {
        var k = Convert.ToDecimal(Console.ReadLine());
        var r = Convert.ToDecimal(Console.ReadLine());

        
        for(int i = 1;; ++i)
        {
            var result = Math.Floor((k*i)/10)*10;

            if(result == (k*i))
                return i;
            else
            {
                result += r;
                if(result == (k*i))
                    return i;
            }
        }
    }


}