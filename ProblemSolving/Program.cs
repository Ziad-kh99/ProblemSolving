using LeetCode.Easy;
using LeetCode.Medium;
using Sheet.A;

using customNode = LeetCode.Easy;


customNode.ListNode head = new customNode.ListNode(1, 
    new customNode.ListNode(2, 
        new customNode.ListNode(3,
            new customNode.ListNode(4))));

var result = ReverseLinkedList.Solution2(head);

Console.WriteLine(result.val);