namespace LeetCode.Easy;


public class NumberOfDaysBetweenTwoDates
{
    public static int Solution(string date1, string date2)
    {
        bool validDate1 = DateTime.TryParse(date1, out DateTime startDate);
        bool validDate2 = DateTime.TryParse(date2, out DateTime endDate);
        int status = DateTime.Compare(startDate, endDate);

        if(validDate1 && validDate2)
        {
            TimeSpan difference = new TimeSpan();
            switch(status)
            {
                case 1:
                    difference = startDate - endDate;
                    break;
                case -1:
                    difference = endDate - startDate;
                    break;
            }

            return difference.Days;
        }

        else return -1;
    }
}