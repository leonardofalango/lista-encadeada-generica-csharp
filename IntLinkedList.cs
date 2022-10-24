using System;
public class IntLinkedList
{
    private IntLinkedListNode? first = null;
    private int count = 0;
    public int Length => count;

    public void Add(int value)
    {
        if (first == null)
        {
            first = new IntLinkedListNode();
            first.Value = value;
            count++;
            return;
        }
        var crr = first;
        while (crr.Next != null)
            crr = crr.Next;

        crr.Next = new IntLinkedListNode();
        crr.Next.Value = value;
        count++;

    }

    public int this[int index]
    {
        get
        {
            if (first == null)
                throw new IndexOutOfRangeException();
            var crr = first;
            for (int i = 0; i < index; i++)
            {
                if (crr.Next == null)
                    throw new IndexOutOfRangeException();
                crr = crr.Next;
            }
            return crr.Value;
        }
        set
        {
            if (first == null)
                throw new IndexOutOfRangeException();
            var crr = first;
            for (int i = 0; i< index; i++)
            {
                if (crr.Next == null)
                    throw new IndexOutOfRangeException();
                crr = crr.Next;
            }
            crr.Value = value;
        }
    }
}

public class IntLinkedListNode
{
    public int Value { get; set; }
    
    private IntLinkedListNode next;
    public IntLinkedListNode Next
    {
        get { return next; }
        set { next = value; }
    }
    
}