namespace LeetCode.Easy;


public class IntersectionOfTwoLinkedLists
{
    public static ListNode Solution(ListNode headA, ListNode headB)
    {   
        ListNode PointerA = headA;
        ListNode PointerB = headB;

        while(PointerA != null)
        {
            while(PointerB != null)
            {
                if(PointerB == PointerA)
                {
                    return PointerA;
                }
                else {
                    PointerB = PointerB.next;
                }
            }
            PointerA = PointerA.next;
        }

        return null;
    }
}