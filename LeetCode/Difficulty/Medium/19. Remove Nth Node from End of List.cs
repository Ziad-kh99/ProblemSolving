namespace LeetCode.Medium;

public class RemoveNthNodeFromEndOfList
{
    public static ListNode Solution(ListNode head, int n)
    {
        ListNode P1 = head;
        ListNode P2 = head;
        int count = 0;

        do {
            count++;
            P1 = P1.next;
        }while(P1 != null);

        n = count - n;

        if(n == 0)   // first node
        {
            head = head.next;
            return head;
        }

        for(int i = 1; i <= n; ++i)
        {
            if(i == n)
            {
                P2.next = P2.next.next;
            }
            else 
            {
                P2 = P2.next;
            }
        }

        return head;
    }
}

