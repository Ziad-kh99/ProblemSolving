// Problem Link: https://leetcode.com/problems/reverse-linked-list/

namespace LeetCode.Easy;

public class ReverseLinkedList
{
    public static ListNode Solution(ListNode head)
    {
        int count = 0;
        ListNode currentNode;

        if(head == null)        
        {
            return head;
        }
        else
        {
            currentNode = head;
            do {
                count++;
                currentNode = currentNode.next;
            } while(currentNode != null);
        }

        int[] arr = new int[count];

        currentNode = head;
        for(int i = 0; i < arr.Length; ++i)
        {
            arr[i] = currentNode.val;
            currentNode = currentNode.next;
        }

        currentNode = head;
        for(int i = arr.Length - 1; i >= 0; --i)
        {
            currentNode.val = arr[i];
            currentNode = currentNode.next;
        }

        return head;
    }
}

public class ListNode 
{
    public int val;       
    public ListNode next;      

    public ListNode(int val = 0, ListNode next = null)       
    {
        this.val = val;
        this.next = next;
    }
}