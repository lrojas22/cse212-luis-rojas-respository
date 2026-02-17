public class Node
{
    public int Value;
    
    // Propiedades para el Árbol Binario
    public Node? Left;
    public Node? Rigth; 

    // Propiedades para la Lista Doblemente Enlazada
    public Node? Next;
    public Node? Prev;

    public Node(int value)
    {
        Value = value;
        Left = null;
        Rigth = null;
        Next = null;
        Prev = null;
    }
}