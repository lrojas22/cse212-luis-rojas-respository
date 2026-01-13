Console.WriteLine("Ingresa el número del cual deseas obtener los multiplos: ");
double number = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Ingresa cuántos múltiplos deseas: ");
int length = Convert.ToInt32(Console.ReadLine());

double[] multiples = Arrays.MultiplesOf(number, length);
    Console.WriteLine($"Multiples of {number}: ");
    Console.WriteLine("{" + string.Join(", ",multiples) + "}");






List<int> myList = new List<int>();

Arrays.RotateListRight(myList, 0);