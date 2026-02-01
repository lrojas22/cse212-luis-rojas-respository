public class DoublyLinkedList
{
    public Node Head;
    public Node Tail;

    public DoublyLinkedList()
    {
        Head = null;
        Tail = null;
    }

    public void AddFirst(char value)
    {
        Node newNode = new Node(value);

        if (Head == null)
        {
            Head = newNode;
            Tail = newNode;
            return;
        }

        newNode.Next = Head;
        Head.Prev = newNode;
        Head = newNode;
    }

    public void AddLast(char value)
    {
        Node newNode = new Node(value);

        if (Tail == null)
        {
            Head = newNode;
            Tail = newNode;
            return;
        }

        Tail.Next = newNode;
        newNode.Prev = Tail;
        Tail = newNode;
    }

    public void Print()
    {
        Node current = Head;

        while (current != null)
        {
            Console.Write(current.Value + " ");
            current = current.Next;
        }

        Console.WriteLine();
    }
}
