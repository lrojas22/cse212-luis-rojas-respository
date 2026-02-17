using System.Xml;

class BinarySearchTree
{
    private Node? _root;


    public void Insert(int value)
    {
        _root = InsertRecursive(_root, value);
    }

    private Node InsertRecursive(Node? node, int value)
    {
        if (node == null)
            return new Node(value);
    
        if (value < node.Value)
        node.Left = InsertRecursive(node.Left,value);
        else
        node.Rigth = InsertRecursive(node.Rigth,value);

        return node;
    }
    
    
    public void PrintInOrder()
    {
        PrintInOrder(_root);
    }

    private void PrintInOrder(Node? node)
    {
        if (node == null) return;
        
        PrintInOrder(node.Left);
        Console.WriteLine(node.Value + " ");
        PrintInOrder(node.Rigth);
    }

//ALTURA DEL ARBOL, OSEA CUANOS NIVELES TIENE

    public int Height()
    {
        return Height(_root);
    }

    private int Height(Node? node)
    {
        if (node == null)
        {
            return 0;
        }
        int leftHeight = Height(node.Left);
        int rightHeight = Height(node.Right);

        return 1 + Math.Max(leftHeight,rightHeight);
    }
}