namespace LeetCode.Medium;

public class HasCycle
{
    // This is my solution and it's not efficient:
    public static Node1 Solution(Node1 head)
    {
        Node1 curNode = head;
        List<Node1> visitedNodes = new List<Node1>();

        while(curNode != null)
        {
            visitedNodes.Add(curNode);

            for(int i = 0; i < visitedNodes.Count; ++i)
            {
                if(curNode.next == visitedNodes[i])
                {
                    return visitedNodes[i];
                }
            }

            curNode = curNode.next;
        }

        return null;
    }
}


public class Node1 {
    public int val;
    public Node1 next;
    public Node1(int x) {
        val = x;
        next = null;
    }
}

