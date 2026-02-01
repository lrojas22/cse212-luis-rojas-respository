
/*
public class SetLearn
{
public static void mostrarSet(){
HashSet<int> numeros = new HashSet<int>();
numeros.Add(10);
numeros.Add(20);
numeros.Add(30);
numeros.Add(20);
numeros.Add(40);
numeros.Add(10);
numeros.Add(5);
numeros.Add(8);
numeros.Add(1);
numeros.Add(5);
numeros.Add(8);
numeros.Add(1);
numeros.Add(5);
numeros.Add(8);
numeros.Add(1);
numeros.Add(12587934);

numeros.Remove(20);
Console.WriteLine("Mi set: " + string.Join(", ", numeros));

int search= 20;


if (numeros.Contains(search) == true)
{
    Console.WriteLine($"El número {search} sí existe en tu SET");
}
else
{
    Console.WriteLine($"El número {search} NO existe en tu SET");
};
}


public static void UnionSet()
    {
        HashSet<int> setA = new HashSet<int>() { 1, 2, 3 };
        HashSet<int> setB = new HashSet<int>() { 3, 4, 5 };

    var union = setA.Union(setB);
    Console.WriteLine(string.Join(",",union));

    }



public static void Duplicados()
{
    int[] numeros = { 1, 3, 5, 3, 7, 1, 9, 5 };
    HashSet<int> vistos = new HashSet<int>();
    HashSet<int> duplicados = new HashSet<int>();
    foreach (int n in numeros)
    {
        if (!vistos.Add(n))
        {
            duplicados.Add(n);
           
        }
    }
    Console.WriteLine("Duplicados: " + string.Join(", ", duplicados));

}
public static void SinDuplicados(){
string[] palabras = { "apple", "banana", "apple", "orange", "banana" };
    HashSet<string> frutas = new HashSet<string>();
    foreach (string i in palabras)

    {
        frutas.Add(i);
    }
    Console.WriteLine("Frutas:  " + string.Join(", ", frutas));



int[] numeros3 = { 1, 2, 3, 2, 4, 1, 5, 3, 6 };
Dictionary<int,int> conteo = new Dictionary<int,int>();
    HashSet<int> seen = new HashSet<int>();
    HashSet<int> sinduplicados = new HashSet<int>();
HashSet<int> duplicados = new HashSet<int>();


    foreach (int i in numeros3)
    {
        
        if (seen.Add(i))
        {
            sinduplicados.Add(i);
        }else
        {
           duplicados.Add(i) ;
           contar++;
        }

    }
    Console.WriteLine("Sin duplicar:  " + string.Join(", ", sinduplicados));
    Console.WriteLine("duplicados:  " + string.Join(", ",   duplicados));
    Console.WriteLine($"Hubieron { contar} duplicados");
    Console.WriteLine($"Los numeros que se repitieron fueron {duplicados.Count()}");
}
}


 // true
 */