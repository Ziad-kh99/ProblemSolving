namespace LeetCode.Easy;

public class HasCycle
{
    // More ifficient solution using two-pointers technique
    public static bool Solution(Node head)
    {
        Node fastP = head;
        Node slowP = head;

        do 
        {
            slowP = slowP.next;         // Shifted by one
            fastP = fastP.next.next;    // Shifted by two

            if(fastP == slowP)
            {
                return true;
            }

        } while(fastP != null && fastP.next != null);    //* Because we shift fastP by Two in each iteration.


        return false;
    }


    // This is my solution and it's not efficient:
    public static bool Solution2(Node head)
    {
        Node curNode = head;
        List<Node> visitedNodes = new List<Node>();

        while(curNode != null)
        {
            visitedNodes.Add(curNode);

            for(int i = 0; i < visitedNodes.Count; ++i)
            {
                if(curNode.next == visitedNodes[i])
                {
                    return true;
                }
            }

            curNode = curNode.next;
        }

        return false;
    }
}


public class Node {
    public int val;
    public Node next;
    public Node(int x) {
        val = x;
        next = null;
    }
}

