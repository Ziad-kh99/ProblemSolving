namespace LeetCode.Medium;


public class Node
{
    public Node(int val) 
    {
        this.val = val;
    }

    public int val;
    public Node prev;
    public Node next;
}

public class MyLinkedList
{
    private Node left;
    private Node right;
    public MyLinkedList()
    {
        this.left = new Node(-100);
        this.right = new Node(-100);

        left.next = right;
        right.prev = left;
    }

    public int Get(int index)
    {
        Node cur = left.next;
        int idx = 0;

        while(idx >= 0 && cur != right)
        {
            if(idx == index)
            {
                return cur.val;
            }
            else 
            {
                idx++;
                cur = cur.next;
            }
        }

        return -1;
    }

    public void AddAtHead(int val)
    {
        Node head = new Node(val);
        left.next.prev = head;
        head.next = left.next;
        head.prev = left;
        left.next = head;
    }

    public void AddAtTail(int val)
    {
        Node tail = new Node(val);

        right.prev.next = tail;
        tail.next = right;
        tail.prev = right.prev;
        right.prev = tail;
    }

    public void AddAtIndex(int index, int val)
    {
        Node cur = left.next;
        int idx = 0;

        while(idx >= 0 && cur != null)
        {
            if(idx == index)
            {
                Node newNode = new Node(val);
                cur.prev.next = newNode;
                newNode.next = cur;
                newNode.prev = cur.prev;
                cur.prev = newNode;
                return;
            }
            // else if(cur == right)
            // {
            //     AddAtTail(val);
            //     return;
            // }
            else 
            {
                idx++;
                cur = cur.next;
            }
        }
    }

    public void DeleteAtIndex(int index)
    {
        Node cur = left.next;
        int idx = 0;

        while(idx >= 0 && cur != right)
        {
            if(idx == index)
            {
                cur.prev.next = cur.next;
                cur.next.prev = cur.prev;
                return;
            }
            else 
            {
                idx++;
                cur = cur.next;
            }
        }
    }
}