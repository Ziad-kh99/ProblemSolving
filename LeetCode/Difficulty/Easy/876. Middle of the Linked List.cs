// Problem link: https://leetcode.com/problems/middle-of-the-linked-list/

// namespace LeetCode.Easy;
public class MiddelOfTheLinkedList
{
    public static ListNode MiddleNode(ListNode head)
    {
        int length = 0;
        ListNode currentNode = head;

        do {
            length++;
            currentNode = currentNode.next;
        } while(currentNode != null);

        int mid = (int)Math.Floor((double)length/2) + 1;

        currentNode = head;

        for(int i = 1; i <= mid; ++i)
        {
            if(i == mid)
            {
               break;
            }
            else {
                currentNode = currentNode.next;
            }
        }
         
        return currentNode;
    }
}


//>Definition for singly-linked list.
public class ListNode 
{
    public int val;
    public ListNode next;
    public ListNode(int val=0, ListNode next=null) 
    {
        this.val = val;
        this.next = next;
    }
 }
