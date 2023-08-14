namespace LeetCode.Easy;


public class RemoveLinkeListElements
{
    public static ListNode Solution(ListNode head, int val)
    {
        while(head != null && head.val == val)
        {
            head = head.next;
        }
        
        if(head == null)
        {
            return head;
        }

        ListNode cur = head;

        while(cur != null)
        {
            if(cur.next != null && cur.next.val == val)
            {
                cur.next = cur.next.next;
                // cur = cur.next;
            }
            else 
            {
                cur = cur.next;
            }
        }

        return head;
    }
}