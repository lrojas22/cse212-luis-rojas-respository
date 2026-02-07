using  System;
using System.Security.Cryptography.X509Certificates;
using System.Numerics;


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

public static BigInteger Factorial(BigInteger n)
{
    if (n <= 1)
    {
        return 1;
    }else
    {
        return n * Factorial(n - 1);
    }

    

}

public static long Fibonacci(int n, Dictionary<int, long>? remember = null)
    {
        // If this is the first time calling the function, then
        // we need to create the dictionary.
        if (remember == null)
        {
            remember = new Dictionary<int, long>();
        }
        //Base Case
        if (n <= 2)
        {
            return 1;
        }

        //Check if we have solved  this one before
        if (remember.ContainsKey(n))
        {
            return remember[n];
        }

        // Otherwise solve with recursion
        var result = Fibonacci(n - 1, remember) + Fibonacci(n - 2, remember);

        // Remember result for potential later use
        remember[n] = result;
        return result;
    }

public static void Permutations(string letters, string word = "")
    {
        // Try adding each of the available letters
        // to the 'word' and add up all the
        // resulting permutations.

        if (letters.Length == 0)
        {
            Console.WriteLine(word);
        }

        for (var i = 0; i< letters.Length; i++)
            {
                // Make a copy of the letters to pass to the
                // the next call to permutations.  We need
                // to remove the letter we just added before
                // we call permutations again.;   
                var lettersLeft = letters.Remove(i,1);

                 // Add the new letter to the word we have so far
                 Permutations(lettersLeft, word + letters[i]);
            }
    }

public static bool BinarySearch(int[] sortedArray, int target)
    {
        if (sortedArray.Length == 1)
        {   //Base Case
            return target == sortedArray[0];
        }
        else
        {
            //Find the middle and compare
            var middle = sortedArray.Length/2;
            if (target == sortedArray[middle])
            {
                return true;
            }
            else if(target < sortedArray[middle])
            {
                return BinarySearch(sortedArray[..middle],target);
            }
            else
            {
                return BinarySearch(sortedArray[middle..],target);// esto aplica la recursion en la 2da mitad
            }
        }
       
    }

    public static int Sum(int n)
    {
        if( n == 0)
        {
            return 0;
        }
        
        return n + Sum(n-1);
        

    }


}