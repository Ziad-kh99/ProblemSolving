namespace Sheet.A;

public class BearAndBigBrother
{
    public static int Run()
    {
        int years= 0;  
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());

        if(a >= 1 && a <= b && b <= 10)
        {
            while(a <= b)
            {
                a *= 3;
                b *= 2;
                years++;
            }

            return years;
        }
        else
            return -1;
    }
}
