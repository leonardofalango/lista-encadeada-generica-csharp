using System;
public class Lista<T>
{
    private Node<T> first = null;
    private int count = 0;
    public int Length => count;

    public void Add(T value)
    {
        if (first == null)
        {
            first = new Node<T>();
            first.Value = value;
            count++;
            return;
        }
        Node<T> crr = first;
        while (crr.Next != null)
            crr = crr.Next;

        crr.Next = new Node<T>();
        crr.Next.Value = value;
        count++;

    }

    public T this[int index]
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

public class Node<T>
{
    public T Value { get; set; }
    
    private Node<T> next;
    public Node<T> Next
    {
        get { return next; }
        set { next = value; }
    }
    
}