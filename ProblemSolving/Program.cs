using LeetCode.Easy;
using LeetCode.Medium;
using Sheet.A;

using customNode = LeetCode.Easy;


// customNode.ListNode head = new customNode.ListNode(1, 
//     new customNode.ListNode(2, 
//         new customNode.ListNode(3,
//         new customNode.ListNode(2,
//             new customNode.ListNode(1)))));



int[][] mat  = new int[5][] 
{
    new int[] {1, 2, 3, 4, 5},
    new int[] {6, 7, 8, 9, 10},
    new int[] {11, 12, 13, 14, 15},
    new int[] {16, 17, 18, 19, 20},
    new int[] {21, 22, 23, 24, 25},
};


var result = DiagonalTraverse.Solution(mat);

foreach(var r in result)
{
    Console.WriteLine($"{r}, ");
}



