using  System;
using System.Security.Cryptography.X509Certificates;

class Recursion
{

public static void sayHello(int n)
{
    if (n <= 0)
    {
        return;
    }else
    {
        Console.WriteLine("Hola");
        sayHello(n - 1);
    }
}

public static int Factorial(int n)
{
    if (n <= 1)
    {
        return 1;
    }else
    {
        return n * Factorial(n - 1);
    }

    

}


}