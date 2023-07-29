namespace LeetCode.Medium;

#region Simple version:
// Have an access to head:

public class DeleteNodeInLinkedList
{
    public static void DeleteNode(ListNode head, ListNode node)
    {
        var currentNode = head;
        ListNode previousNode = null;
        ListNode nextNode = node.next;

        while(currentNode.next != null)
        {
            if(currentNode.next == node)
            {
                previousNode = currentNode;
                break;
            }

            currentNode = currentNode.next;
        }

        previousNode.next = nextNode;

        currentNode = head;
        //> Print for ensureance:
        while(currentNode != null)
        {
            Console.WriteLine(currentNode.val);
            currentNode = currentNode.next;
        }
    }
}


#endregion




//> Definition for singly-linked list.
// public class ListNode {
//     public int val;
//     public ListNode next;
//     public ListNode(int x) { val = x; }
// }
