public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        double[] result = new double[length];
        for(int i = 0; i < length; i++)
        {
            result[i] = number *( i + 1 );
        }
        return result;

        

        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // replace this return statement with your own
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    /// 
    /// 
    /// 
    /// 
   public static void RotateListRight(List<int> data, int amount)
{   
    Console.WriteLine("Hola, primero crearemos tu lista");
    Console.WriteLine("De cuantos elemento es tu lista");
    int numList = Convert.ToInt32(Console.ReadLine());

    data.Clear();  // Limpiar la lista dinámica

    Console.WriteLine("Ahora ingresa los elementos de tu Lista");
    for (int i = 0; i < numList; i++)
    {
        Console.WriteLine($"Elemento {i + 1} : ");
        int elemento = Convert.ToInt32(Console.ReadLine());
        data.Add(elemento);
    }
    Console.WriteLine("\nLista original: {" + string.Join(", ", data) + " }");

    // PLAN FOR ROTATING LIST TO THE RIGHT:
    // Step 1: Understand what "rotate right" means
    // Step 2: Calculate the split point (data.Count - amount)
    // Step 3: Extract the last 'amount' elements
    // Step 4: Remove those elements from the end
    // Step 5: Insert those elements at the beginning
    
    Console.WriteLine("\n¿Cuántas posiciones quieres rotar a la derecha?");
    amount = Convert.ToInt32(Console.ReadLine());

    // ✅ AÑADE ESTO: Validar amount
    if (amount > data.Count)
    {
        amount = amount % data.Count;
    }
    
    if (amount == 0)
    {
        Console.WriteLine("\nNo se rotó la lista (amount = 0)");
        return;
    }
    
    // Calculate where to split the list
    int splitPoint = data.Count - amount;
    
    // Get the last 'amount' elements that need to move to the front
    List<int> elementsToRotate = data.GetRange(splitPoint, amount);
    
    // Remove those elements from their current position at the end
    data.RemoveRange(splitPoint, amount);
    
    // Insert them at the beginning of the list
    data.InsertRange(0, elementsToRotate);
    
    // ✅ AÑADE ESTO: Mostrar resultado
    Console.WriteLine($"\nLista rotada {amount} posiciones a la derecha:");
    Console.WriteLine("{" + string.Join(", ", data) + "}");
}
}