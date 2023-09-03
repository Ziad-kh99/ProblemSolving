namespace LeetCode.Easy;


public class PalindromeLinkedList
{
    public static bool Solution(ListNode head)
    {
        ListNode cur = head;
        List<int> list = new List<int>();

        while (cur != null)
        {
            list.Add(cur.val);
            cur = cur.next;
        }

        var mid = Math.Ceiling(list.Count / 2.0);

        for(int s = 0, e = list.Count-1; s < mid; ++s, --e)
        {
            if(list[s] == list[e])
            {
                continue;
            }
            else 
            {
                return false;
            }
        }

        return true;
    }
}