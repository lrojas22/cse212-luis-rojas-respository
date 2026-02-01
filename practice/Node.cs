public class Node
{
    public char Value;
    public Node Next;
    public Node Prev;

    public Node(char value)
    {
        Value = value;
        Next = null;
        Prev = null;
    }
}
